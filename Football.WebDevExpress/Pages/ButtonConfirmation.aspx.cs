using System;
using DevExpress.Web;

namespace Football.WebDevExpress.Page
{
    public partial class ButtonConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            ASPxButton button = (ASPxButton)sender;
            lblInfo.Text = String.Format("Button {0} just pressed!", button.Text);
        }
    }
}