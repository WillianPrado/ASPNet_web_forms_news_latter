using sucesso_e_motivacao.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sucesso_e_motivacao.Views
{
    public partial class CaseTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var contexto = new NewsLatterContext())
            {
                CaseTypesView.DataSource = contexto.CaseTypes.ToList();
                CaseTypesView.DataBind();
            }
        }
    }
}