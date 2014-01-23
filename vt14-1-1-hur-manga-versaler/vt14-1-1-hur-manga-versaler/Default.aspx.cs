using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vt14_1_1_hur_manga_versaler {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Count_Click(object sender, EventArgs e) {
            TextBox.Enabled = false;
            Label.Text = String.Format("Texten inehåller {0} versaler.",
                    Model.TextAnalyzer.GetNumberOfCapitals(TextBox.Text)
                );
            Count.Visible = false;
            Clear.Visible = true;
        }

        protected void Clear_Click(object sender, EventArgs e) {
            TextBox.Text = "";
            TextBox.Enabled = true;
            Label.Text = "";
            Count.Visible = true;
            Clear.Visible = false;
        }
    }
}