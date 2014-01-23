<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="vt14_1_1_hur_manga_versaler.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox" runat="server" TextMode="MultiLine"></asp:TextBox><br />
        <asp:Label ID="Label" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="Count" runat="server" Text="Bestäm antalet versaler" OnClick="Count_Click" />
        <asp:Button ID="Clear" runat="server" Text="Rensa" Visible="false" OnClick="Clear_Click" />
    </div>
    </form>
</body>
</html>
