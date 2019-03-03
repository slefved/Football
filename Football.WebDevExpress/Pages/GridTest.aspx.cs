using Football.WebDevExpress.ModelView;
using System;
using System.Linq;

namespace Football.WebDevExpress.Page
{
    public partial class GridTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var playerList = from player in new Football.Domain.Repository.PlayerRepository().GetAll()
                        select new PlayerModelView
                        {
                            PlayerID = player.PlayerID,
                            Name = player.Name,
                            DateOfBirth = player.DateOfBirth,
                            Height = player.Height,
                            AnnualSalary = player.AnnualSalary
                        };

            gv.DataSource = playerList;
            gv.DataBind();
        }

        protected void gv_DataBinding(object sender, EventArgs e)
        {
            
        }
    }
}