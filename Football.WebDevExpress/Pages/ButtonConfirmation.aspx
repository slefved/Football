<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonConfirmation.aspx.cs" Inherits="Football.WebDevExpress.Page.ButtonConfirmation" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function Confirmation(s, e) {
            var e = s.mainElement.innerText.toLowerCase();
            e.processOnServer = confirm("Are you sure want to " + e + "?")
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxButton ID="btnSave" Text="Save" runat="server" OnClick="btn_Click" ClientSideEvents-Click="Confirmation" />
            <dx:ASPxButton ID="btnDelete" Text="Delete" runat="server" OnClick="btn_Click" ClientSideEvents-Click="Confirmation" />
            <dx:ASPxButton ID="btnCancel" Text="Cancel" runat="server" OnClick="btn_Click" ClientSideEvents-Click="Confirmation" />
        </div>
        <div>
            <dx:ASPxLabel ID="lblInfo" ForeColor="Red" runat="server" />
        </div>
    </form>
</body>
</html>
