<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <%--<asp:Label ID="Lbl1" runat="server" Text="UserName"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtuname" runat="server" Width="214px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Lbl2" runat="server" Text="Password"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtpswd" runat="server" Width="211px"></asp:TextBox>
            <br />
            <br />
            <asp:Button  ID="BtnRedirect" runat="server" Text="Submit" OnClick="Btn_Click" PostBackUrl="~/homePage.aspx" />&nbsp;&nbsp;&nbsp;--%>

            <table style="width:40%;">
                <tr>
                    <td>Username</td>
                    <td><asp:TextBox ID="username" runat="server" /></td>
                    
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox ID="password" runat="server" /></td>
                    
                </tr>
                <tr>
                    <td colspan="2">&nbsp;<asp:Button ID="loginbtn" Text="Login" runat="server" PostBackUrl="~/homePage.aspx" OnClick="loginbtn_Click"/></td>
                   
                   
                </tr>
        </div>
    </form>
</body>
</html>
