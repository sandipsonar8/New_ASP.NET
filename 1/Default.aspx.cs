using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_Default : System.Web.UI.Page
{
    protected void Page_PreInit(object sender,EventArgs e)
    {
        lb.Text = lb.Text+"PreInit<br/>";
    }
    protected void Page_Init(object sender,EventArgs e)
    {
        lb.Text = lb.Text + "Init<br/>";
    }
    protected void Page_InitComplete(object sender, EventArgs e)
    {
        lb.Text = lb.Text + "InitComplete<br/>";
    }
    protected void Page_PreLoad(object sender, EventArgs e)
    {
        lb.Text = lb.Text + "PreLoad<br/>";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lb.Text = lb.Text + "Load<br/>";
    }
    protected void Page_LoadComplete(object sender,EventArgs e)
    {
        lb.Text = lb.Text + "LoadComplete<br/>";
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        lb.Text = lb.Text + "PreRender<br/>";
    }
    protected void Page_PreRenderComplete(object sender, EventArgs e)
    {
        lb.Text = lb.Text + "PreRenderComplete<br/>";
    }
    protected void Page_SaveStateComplete(object sender, EventArgs e)
    {
        lb.Text = lb.Text + "SaveStateComplete<br/>";
    }
    protected void Page_Render(object sender, EventArgs e)
    {
        lb.Text = lb.Text + "Render<br/>";
    }
    protected void Page_Unload(object sender, EventArgs e)
    {
        lb.Text = lb.Text + "Unload<br/>";
    }

}