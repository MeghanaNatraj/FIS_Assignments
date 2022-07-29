<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fruits.aspx.cs" Inherits="Assignment1.fruits" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="21px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="156px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="75px" Width="164px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
