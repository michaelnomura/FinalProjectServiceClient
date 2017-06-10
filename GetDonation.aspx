<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetDonation.aspx.cs" Inherits="GetDonation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donations</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Donations</h1>
        <asp:GridView ID="GridView" runat="server" OnSelectedIndexChanged="GridView_SelectedIndexChanged"></asp:GridView>
    </div>
    </form>
</body>
</html>
