using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace repeater
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                int i = 0;
                try { i = Int16.Parse(TextBox1.Text); }
                catch { }
                TextBox Txt;
                if (i > 0)
                {
                    for (int I = 0; I < i; I++)
                    {
                        Txt = new TextBox();
                        Txt.Text = I.ToString();
                        pnl1.Controls.Add(Txt);
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            try { i = Int16.Parse(TextBox1.Text); }
            catch { }
            TextBox Txt;
            if (i > 0)
            {
                for (int I = 0; I < i; I++)
                {
                    Txt = new TextBox();
                    Txt.Text = I.ToString();
                    pnl1.Controls.Add(Txt);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double dSum = 0;
            TextBox Txt;
            foreach (Control Ctl in pnl1.Controls) {
                if (Ctl is TextBox) {
                    Txt = (TextBox)Ctl;
                    try { dSum += double.Parse(Txt.Text); }
                    catch{}
                }
            }
            Button2.Text = dSum.ToString();
        }
        
    }

}