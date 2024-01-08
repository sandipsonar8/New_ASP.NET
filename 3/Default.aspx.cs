using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _3_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bind1();
        bind2();
    }

    private void bind1()
    {
        ListItem l1 = new ListItem("Pune");
        ListItem l2 = new ListItem("Dhule");
        ListItem l3 = new ListItem("Nashik");

        DropDownList1.Items.Add(l1);
        DropDownList1.Items.Add(l2);
        DropDownList1.Items.Add(l3);
    }

    private void bind2()
    {
        ListItem l1 = new ListItem("Pune");
        ListItem l2 = new ListItem("Dhule");
        ListItem l3 = new ListItem("Nashik");

        DropDownList2.Items.Add(l1);
        DropDownList2.Items.Add(l2);
        DropDownList2.Items.Add(l3);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // You can add logic here for the button click event
    }
}