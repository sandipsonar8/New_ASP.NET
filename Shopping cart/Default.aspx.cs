using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Reflection;

public partial class Shopping_cart_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Initial data binding
            BindShoppingCart();
        }
    }

    private void BindShoppingCart()
    {
        DataTable dtCart = GetShoppingCart();
        GridView1.DataSource = dtCart;
        GridView1.DataBind();
    }

    private DataTable GetShoppingCart()
    {
        // Check if the shopping cart exists in session
        if (Session["ShoppingCart"] == null)
        {
            // If not, create a new shopping cart
            Session["ShoppingCart"] = new List<CartItem>();
        }

        // Return the shopping cart from session
        return ((List<CartItem>)Session["ShoppingCart"]).ToDataTable();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Remove")
        {
            int productId = Convert.ToInt32(e.CommandArgument);

            // Remove the item from the shopping cart
            List<CartItem> cartItems = (List<CartItem>)Session["ShoppingCart"];
            var itemToRemove = cartItems.FirstOrDefault(item => item.ProductID == productId);
            if (itemToRemove != null)
            {
                cartItems.Remove(itemToRemove);
                Session["ShoppingCart"] = cartItems;
                BindShoppingCart();
            }
        }
    }

    protected void btnCheckout_Click(object sender, EventArgs e)
    {
        // Implement the checkout logic here
        // This could include processing the order, updating the database, etc.
        // For demonstration purposes, we'll just clear the shopping cart in session
        Session["ShoppingCart"] = null;
        BindShoppingCart();
    }

    public class CartItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

public static class ListExtensions
{
    public static DataTable ToDataTable<T>(this List<T> items)
    {
        DataTable dataTable = new DataTable(typeof(T).Name);

        // Get all the properties
        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var prop in properties)
        {
            // Setting column names as Property names
            dataTable.Columns.Add(prop.Name);
        }

        foreach (T item in items)
        {
            var values = new object[properties.Length];

            for (var i = 0; i < properties.Length; i++)
            {
                // Inserting property values to datatable rows
                values[i] = properties[i].GetValue(item, null);
            }

            dataTable.Rows.Add(values);
        }

        return dataTable;
    }
}