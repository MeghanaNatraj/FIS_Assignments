<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Supplier_ID"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Please enter a valid ID" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;<br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="SupplierName"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Enter Name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="ProductName"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please Enter the product Name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Cannot be empty" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter a number between 100-1000" ForeColor="#CC0000" MaximumValue="1000" MinimumValue="100" Type="Integer"></asp:RangeValidator>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Supplydate"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Date" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="annot be empty" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="DateVal" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="Enter a valid date" ForeColor="#CC0000" Type="Date" ></asp:RangeValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label6" runat="server" Text="RecievedBy(e-mail)"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" style="margin-bottom: 5px" TextMode="Email"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Cannot be empty" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Enter a email" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        RecievedBy (Name)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="140px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="RecieverNumber"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" TextMode="Phone"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Enter a valid phone number" OnServerValidate="CustomValidator1_ServerValidate" ValidationExpression="^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}" ControlToValidate="TextBox6" Display="Dynamic" ForeColor="#CC0000"></asp:CustomValidator>
&nbsp;
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text="IsInvoiced"/>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label8" runat="server" Text=" "></asp:Label>
        <br />
        <br />

        <br />
&nbsp;&nbsp;
        <br />
    </form>
</body>
</html>
