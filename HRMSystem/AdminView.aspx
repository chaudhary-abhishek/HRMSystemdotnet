<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="HRMSystem.AdminView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Employee Details " />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Payroll " />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button1_Click" Text="Training" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button1_Click" Text="Performance" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button1_Click" Text="Resignation" />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" OnClick="Button1_Click" Text="Resume Tracking" />
        </div>
    </form>
</body>
</html>
