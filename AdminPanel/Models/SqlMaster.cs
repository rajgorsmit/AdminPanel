using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class SqlMaster
    {
        public bool SQLBoolOutput(string Case, string DataConn, string Query, string ValueJson)
        {
            string str = DataConn;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(Query, con);
            for (int i = 0; i <= 10; i++) { 
                
            }
            con.Open();
            var nId = cmd.ExecuteScalar();
            if (nId != null)
            { return true; }
            else
            { return false; }
        }

        public string LogIn(string Case, string DataConn, string Query, string ValueJson) {
            string[] Keys = [];
            string[] Vals = [];
            JObject obj = JObject.Parse(JsonLog);            
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mr\\source\\repos\\AdminWeb\\AdminWeb\\App_Data\\MainData.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("CustSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            int i;
            for (i=0; i <= Keys.GetValue(); i++) {
                Keys.SetValue(                
            }
            for (i=0; i <= Keys.GetValue(); i++)
            {       
                    CannotUnloadAppDomainException
            }   
            //cmd.Parameters.AddWithValue("@case", 1);
            //cmd.Parameters.AddWithValue("@id", custdb.ID = (string)obj["Id"]);
            //cmd.Parameters.AddWithValue("@fname", custdb.FName = (string)obj["Fname"]);
            //cmd.Parameters.AddWithValue("@lname", custdb.LName = (string)obj["Lname"]);
            //cmd.Parameters.AddWithValue("@number", custdb.Number = (string)obj["Number"]);
            //cmd.Parameters.AddWithValue("@email", custdb.Email = (string)obj["Email"]);
            //cmd.Parameters.AddWithValue("@State", custdb.StateUT = (string)obj["State"]);
            //cmd.Parameters.AddWithValue("@city", custdb.City = (string)obj["City"]);
            //cmd.Parameters.AddWithValue("@age", custdb.Age = (string)obj["Age"]);
            //cmd.Parameters.AddWithValue("@IsActive", custdb.IsActive = "1");
            //cmd.Parameters.AddWithValue("@Password", custdb.Password = (string)obj["Password"]);
            //cmd.Parameters.AddWithValue("@AccType", custdb.AccType = (string)obj["AccType"]);
            //cmd.Parameters.AddWithValue("@UName", custdb.AccType = (string)obj["UName"]);
            //cmd.Parameters.Add("@InsertedId", SqlDbType.Int).Direction = ParameterDirection.Output;
            //cn.Open();
            cmd.ExecuteNonQuery();
                cn.Close();
                Session["ID"] = cmd.Parameters["@InsertedId"].Value.ToString();
                return Convert.ToString(JsonLog);
            }

        public string LogIn(int Case, string DataConn, string Query, string ValueJson)
        {               
            string[] Keys = [];
            string[] Vals = [];
            JObject obj = JObject.Parse(JsonLog);
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mr\\source\\repos\\AdminWeb\\AdminWeb\\App_Data\\MainData.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("CustSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            int i=0;
            for (i; i <= Keys.GetValue(); i++)
            {
                Keys.SetValue("Uname:");
                Keys.SetValue("Fname");
                Keys.SetValue("Lname");
                Keys.SetValue("Age");
                Keys.SetValue("Number");
                Keys.SetValue("Email");
                Keys.SetValue("State");
                Keys.SetValue("City");
                Keys.SetValue("Password");
                Keys.SetValue("AccType");
                Keys.SetValue("Date");
            }
            for (i; i <= Keys.GetValue(); i++)
            {
                Vals.SetValue((string)obj.UName);
                Vals.SetValue((string)obj.Fname);
                Vals.SetValue((string)obj.Lname);
                Vals.SetValue((string)obj.Age);
                Vals.SetValue((string)obj.Number);
                Vals.SetValue((string)obj.Email);
                Vals.SetValue((string)obj.State);
                Vals.SetValue((string)obj.City);
                Vals.SetValue((string)obj.Password);
                Vals.SetValue((string)obj.AccType);
                Vals.SetValue((string)obj.Date);
            }
            //cmd.Parameters.AddWithValue("@case", 1);
            //cmd.Parameters.AddWithValue("@id", custdb.ID = (string)obj["Id"]);
            //cmd.Parameters.AddWithValue("@fname", custdb.FName = (string)obj["Fname"]);
            //cmd.Parameters.AddWithValue("@lname", custdb.LName = (string)obj["Lname"]);
            //cmd.Parameters.AddWithValue("@number", custdb.Number = (string)obj["Number"]);
            //cmd.Parameters.AddWithValue("@email", custdb.Email = (string)obj["Email"]);
            //cmd.Parameters.AddWithValue("@State", custdb.StateUT = (string)obj["State"]);
            //cmd.Parameters.AddWithValue("@city", custdb.City = (string)obj["City"]);
            //cmd.Parameters.AddWithValue("@age", custdb.Age = (string)obj["Age"]);
            //cmd.Parameters.AddWithValue("@IsActive", custdb.IsActive = "1");
            //cmd.Parameters.AddWithValue("@Password", custdb.Password = (string)obj["Password"]);
            //cmd.Parameters.AddWithValue("@AccType", custdb.AccType = (string)obj["AccType"]);
            //cmd.Parameters.AddWithValue("@UName", custdb.AccType = (string)obj["UName"]);
            //cmd.Parameters.Add("@InsertedId", SqlDbType.Int).Direction = ParameterDirection.Output;
            //cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            Session["ID"] = cmd.Parameters["@InsertedId"].Value.ToString();
            return Convert.ToString(JsonLog);
        }
    }
}