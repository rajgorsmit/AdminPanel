using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Models;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;

namespace AdminPanel.Controllers
{
    public class CustController : Controller
    {
        // GET: Cust
        public void Index()
        {
            Response.Redirect("https://localhost:44371/RegisterForm.aspx");
        }

        public bool CheckIfEmailExist(string Email) {
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mr\\source\\repos\\AdminWeb\\AdminWeb\\App_Data\\MainData.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("Select id from Users where Email= @Email", con);
            cmd.Parameters.AddWithValue("@Email", Email);
            con.Open();
            var nId = cmd.ExecuteScalar();
            if (nId != null)
            { return true;  }
            else
            { return false; }            
        }

        public string InsertCustReg(CustDB custdb, string JsonLog)
        {
            JObject obj = JObject.Parse(JsonLog);
            if (!CheckIfEmailExist((string)obj["Email"]))
            {
                string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mr\\source\\repos\\AdminWeb\\AdminWeb\\App_Data\\MainData.mdf;Integrated Security=True";
                SqlConnection cn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("CustSP", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@case", 1);
                cmd.Parameters.AddWithValue("@id", custdb.ID = (string)obj["Id"]);
                cmd.Parameters.AddWithValue("@fname", custdb.FName = (string)obj["Fname"]);
                cmd.Parameters.AddWithValue("@lname", custdb.LName = (string)obj["Lname"]);
                cmd.Parameters.AddWithValue("@number", custdb.Number = (string)obj["Number"]);
                cmd.Parameters.AddWithValue("@email", custdb.Email = (string)obj["Email"]);
                cmd.Parameters.AddWithValue("@State", custdb.StateUT = (string)obj["State"]);
                cmd.Parameters.AddWithValue("@city", custdb.City = (string)obj["City"]);
                cmd.Parameters.AddWithValue("@age", custdb.Age = (string)obj["Age"]);
                cmd.Parameters.AddWithValue("@IsActive", custdb.IsActive = "1");
                cmd.Parameters.AddWithValue("@Password", custdb.Password = (string)obj["Password"]);
                cmd.Parameters.AddWithValue("@AccType", custdb.AccType = (string)obj["AccType"]);
                cmd.Parameters.AddWithValue("@UName", custdb.AccType = (string)obj["UName"]);
                cmd.Parameters.Add("@InsertedId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Session["ID"] = cmd.Parameters["@InsertedId"].Value.ToString();
                return Convert.ToString(JsonLog);
            }
            else {
                Response.Write("");
                return "Error : { ErrorCode:404, ErrorStatus='Email Already Exist' }";
            }
        }

        public ActionResult LogInFunc(CustDB custdb, string JsonLog)
        {
            JObject obj = JObject.Parse(JsonLog);
            Session["ID"] = custdb.ID;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AccTypeReg"].ToString());
            try
            {
                con.Open();
                string qry = "select * from Users where Email='" + custdb.Email + "' and Password='" + custdb.Password + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Session["ID"] = custdb.ID;
                    con.Close();
                    return View("/Dashboard.aspx");
                }
                else
                {
                    con.Close();
                    //Account does'nt exists
                    return null;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
                return View("/.aspx");
            }
        }

        public string GetDataForStateDD()
        {
            string retJson = string.Empty;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AccTypeReg"].ToString());
            try
            {
                con.Open();
                string qry = "select * from States";
                SqlCommand cmd = new SqlCommand(qry, con);
                //SqlDataReader sdr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                retJson = JsonConvert.SerializeObject(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
            }
            return retJson;
        }

        public string GetDataForProfile(CustDB custdb)
        {
            string retJson = string.Empty;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AccTypeReg"].ToString());
            try
            {
                con.Open();
                string qry = $"select FirstName, LastName, Age, AccountType, Number, City, State, IsActive, Date, Password, Email, UName, Reported from Users where id={Session["ID"]}";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                retJson = JsonConvert.SerializeObject(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
            }
            return retJson;
        }


        public string GetCity(string StateId)
        {
            string retJson = string.Empty;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AccTypeReg"].ToString());
            try
            {
                con.Open();
                string qry = $"select * from Cities where StateId={StateId}";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                retJson = JsonConvert.SerializeObject(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
            }
            return retJson;
        }

        public string RetCityTable()
        {
            string retJson = string.Empty;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AccTypeReg"].ToString());
            try
            {
                con.Open();
                string qry = "select * from Cities";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                retJson = JsonConvert.SerializeObject(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
            }
            return retJson;
        }


        public string GetAccTypes()
        {
            string retJson = string.Empty;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AccTypeReg"].ToString());
            try
            {
                con.Open();
                string qry = "select * from AccountTypes";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                retJson = JsonConvert.SerializeObject(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
            }
            return retJson;
        }

        public void LogOutFunc()
        {
            Session["ID"] = null;
            Response.Redirect("/RegisterForm.aspx");
        }

        public string UpdateUserProfile(CustDB custdb, string JsonLog)
        {
            JObject obj = JObject.Parse(JsonLog);
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mr\\source\\repos\\AdminWeb\\AdminWeb\\App_Data\\MainData.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("CustSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@case", 1);
            cmd.Parameters.AddWithValue("@id", custdb.ID = (string)obj["Id"]);
            cmd.Parameters.AddWithValue("@fname", custdb.FName = (string)obj["Fname"]);
            cmd.Parameters.AddWithValue("@lname", custdb.LName = (string)obj["Lname"]);
            cmd.Parameters.AddWithValue("@number", custdb.Number = (string)obj["Number"]);
            cmd.Parameters.AddWithValue("@email", custdb.Email = (string)obj["Email"]);
            cmd.Parameters.AddWithValue("@State", custdb.StateUT = (string)obj["State"]);
            cmd.Parameters.AddWithValue("@city", custdb.City = (string)obj["City"]);
            cmd.Parameters.AddWithValue("@age", custdb.Age = (string)obj["Age"]);
            cmd.Parameters.AddWithValue("@IsActive", custdb.IsActive = "1");
            cmd.Parameters.AddWithValue("@Password", custdb.Password = (string)obj["Password"]);
            cmd.Parameters.AddWithValue("@AccType", custdb.AccType = (string)obj["AccType"]);
            cmd.Parameters.AddWithValue("@UName", custdb.AccType = (string)obj["UName"]);
            cmd.Parameters.Add("@InsertedId", SqlDbType.Int).Direction = ParameterDirection.Output;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            Session["ID"] = cmd.Parameters["@InsertedId"].Value.ToString();
            return Convert.ToString(JsonLog);
        }

        public void DeleteUserProfile()
        {
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mr\\source\\repos\\AdminWeb\\AdminWeb\\App_Data\\MainData.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("CustSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@case", 2);
            cmd.Parameters.AddWithValue("@id", Session["ID"]);            
            cmd.Parameters.Add("@InsertedId", SqlDbType.Int).Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            Session["ID"] = cmd.Parameters["@InsertedId"].Value.ToString();
            Response.Redirect("Dashboard.aspx");            
        }

        public string UpdateUser(CustDB custdb, string JsonLog)
        {
            JObject obj = JObject.Parse(JsonLog);
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mr\\source\\repos\\AdminWeb\\AdminWeb\\App_Data\\MainData.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("CustSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@case", 3);
            cmd.Parameters.AddWithValue ("@id", custdb.ID = (string)Session["ID"]);
            cmd.Parameters.AddWithValue("@fname", custdb.FName = (string)obj["Fname"]);
            cmd.Parameters.AddWithValue("@lname", custdb.LName = (string)obj["Lname"]);
            cmd.Parameters.AddWithValue("@number", custdb.Number = (string)obj["Number"]);
            cmd.Parameters.AddWithValue("@email", custdb.Email = (string)obj["Email"]);
            cmd.Parameters.AddWithValue("@State", custdb.StateUT = (string)obj["State"]);
            cmd.Parameters.AddWithValue("@city", custdb.City = (string)obj["City"]);
            cmd.Parameters.AddWithValue("@age", custdb.Age = (string)obj["Age"]);
            cmd.Parameters.AddWithValue("@IsActive", custdb.IsActive = "1");
            cmd.Parameters.AddWithValue("@Password", custdb.Password = (string)obj["Password"]);
            cmd.Parameters.AddWithValue("@AccType", custdb.AccType = (string)obj["AccType"]);
            cmd.Parameters.AddWithValue("@UName", custdb.AccType = (string)obj["UName"]);
            cmd.Parameters.Add("@InsertedId", SqlDbType.Int).Direction = ParameterDirection.Output;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();            
            return Convert.ToString(JsonLog);
        }

        public string ReportUser(CustDB custdb, string JsonLog)
        {
            JObject obj = JObject.Parse(JsonLog);
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mr\\source\\repos\\AdminWeb\\AdminWeb\\App_Data\\MainData.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("CustSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@case", 4);
            cmd.Parameters.AddWithValue("@id", custdb.ID = (string)Session["ID"]);            
            cmd.Parameters.Add("@InsertedId", SqlDbType.Int).Direction = ParameterDirection.Output;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            return Convert.ToString(JsonLog);
        }

    }
}