using HealthOnlineShop.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthOnlineShop
{
    public enum categories { Drink, Bread, Snack, Cereal, Ingredient }
    public partial class ucItems : UserControl
    {
        public event EventHandler onSelect = null;
        public int id { get; set; }
        public double price { get; set; }
        public string Description { get; set; }
        private Product _product;
        public string Category { get; set; }
        public Product Product { get; set; } 
        public ucItems()
        {
            InitializeComponent();
        }
        public string PName
        {
            get{ return txtPName.Text; }
            set {txtPName.Text = value; }
        }
        public double PPrice
        {
            get { return price; }
            set { price = value; txtPrice.Text ="$"+price.ToString(); }
        }
        public  Image PImage
        {
            get { return imgProduct.Image; }
            set { imgProduct.Image = value; }
        }
        private void imgProduct_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void imgProduct_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(imgProduct, Description);
        }
    }
}
