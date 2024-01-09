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

public partial class DataList_DataList : System.Web.UI.Page
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

            BindDataList();
        }
    }

    private void BindDataList()
    {
        dataListProducts.DataSource = products;
        dataListProducts.DataBind();
    }

    protected void dataListProducts_EditCommand(object source, DataListCommandEventArgs e)
    {
        dataListProducts.EditItemIndex = e.Item.ItemIndex;
        BindDataList();
    }

    protected void dataListProducts_CancelCommand(object source, DataListCommandEventArgs e)
    {
        dataListProducts.EditItemIndex = -1;
        BindDataList();
    }

    protected void dataListProducts_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        TextBox txtProductName = (TextBox)e.Item.FindControl("txtProductName");
        TextBox txtPrice = (TextBox)e.Item.FindControl("txtPrice");

        int index = e.Item.ItemIndex;
        products[index].ProductName = txtProductName.Text;
        products[index].Price = decimal.Parse(txtPrice.Text);

        dataListProducts.EditItemIndex = -1;
        BindDataList();
    }
}