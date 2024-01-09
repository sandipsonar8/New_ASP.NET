using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}
public partial class DataList_DataGridExample : System.Web.UI.Page
{
    private List<Product> products;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Sample data
            products = new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Laptop", Price = 1200.50M },
                new Product { ProductID = 2, ProductName = "Smartphone", Price = 699.99M },
                new Product { ProductID = 3, ProductName = "Tablet", Price = 299.99M }
            };

            BindDataGrid();
        }
    }

    private void BindDataGrid()
    {
        dataGridProducts.DataSource = products;
        dataGridProducts.DataBind();
    }

    protected void dataGridProducts_EditCommand(object source, DataGridCommandEventArgs e)
    {
        dataGridProducts.EditItemIndex = e.Item.ItemIndex;
        BindDataGrid();
    }

    protected void dataGridProducts_CancelCommand(object source, DataGridCommandEventArgs e)
    {
        dataGridProducts.EditItemIndex = -1;
        BindDataGrid();
    }

    protected void dataGridProducts_UpdateCommand(object source, DataGridCommandEventArgs e)
    {
        TextBox txtProductName = (TextBox)e.Item.FindControl("txtProductName");
        TextBox txtPrice = (TextBox)e.Item.FindControl("txtPrice");

        int index = e.Item.ItemIndex;
        products[index].ProductName = txtProductName.Text;
        products[index].Price = decimal.Parse(txtPrice.Text);

        dataGridProducts.EditItemIndex = -1;
        BindDataGrid();
    }
}