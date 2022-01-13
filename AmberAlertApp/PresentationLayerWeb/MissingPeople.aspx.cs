using AmberAlertBusiness;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class MissingPeople : System.Web.UI.Page
    {
        
         private readonly MissingBusiness missingBusiness;

        public MissingPeople()
        {
            this.missingBusiness = new MissingBusiness();
        }
         


        protected void Page_Load(object sender, EventArgs e)
        {
            
           RefreshData();
            
        }

        //Button Get All Missing People
        protected void btnget_Click(object sender, EventArgs e)
        {

            RefreshData();

        }

        protected void ListBoxMissingPeople_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void RefreshData()
        {
            List<Missing> missings = this.missingBusiness.MissingAll();
            ListBoxMissingPeople.Items.Clear();
            foreach (Missing m in missings)
            {
                ListBoxMissingPeople.Items.Add(string.Format("{0}. {1} - {2} : {3} - {4} - {5} : {6} --- {7} {8}",m.IdMiss, m.FirstName, m.SurName, m.JMBG, m.DateOfBirth, m.Address, m.Gender, m.DateOfDisappearance, m.ImageOfPerson));
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            Missing m = new Missing();
            m.IdMiss = int.Parse(ListBoxMissingPeople.SelectedItem.ToString().Split('.')[0]);
            this.missingBusiness.DeleteMissing(m);
            RefreshData();
        }
    }
}