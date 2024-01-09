using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _5_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dl.Text = DropDownList1.SelectedValue.ToString();

        cb.Text = "Selected Items:<br/>";
        for(int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected)
            {
                cb.Text += CheckBoxList1.Items[i].Text + "<br/>";
            }
        }

        rb.Text = "Selected Items:<br/>";
        for(int i = 0; i < RadioButtonList1.Items.Count; i++)
        {
            if (RadioButtonList1.Items[i].Selected)
            {
                rb.Text += RadioButtonList1.Items[i].Text + "<br/>";
            }
        }
    }
}