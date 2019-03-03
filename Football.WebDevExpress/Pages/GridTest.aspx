<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridTest.aspx.cs" Inherits="Football.WebDevExpress.Page.GridTest" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxGridView ID="gv" OnDataBinding="gv_DataBinding" runat="server" />
        </div>
    </form>
</body>
</html>
