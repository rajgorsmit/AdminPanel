<script language="JavaScript" type="text/javascript">
    window.onbeforeunload = confirmExit;
    function confirmExit() {
    return "Are you sure you want to Quit?";
    }
    $(function() {
        $("a").click(function() {
            window.onbeforeunload = null;
        });
        $("input").click(function() {
            window.onbeforeunload = null;
        });
    });
</script>
