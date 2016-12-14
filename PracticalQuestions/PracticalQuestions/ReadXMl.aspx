<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadXMl.aspx.cs" Inherits="PracticalQuestions.ReadXMl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 40px">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Click" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
    </div>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
