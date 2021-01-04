using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PotrosuvackaKosnicka.Models;

namespace PotrosuvackaKosnicka
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            this.addToProducts.Click += new EventHandler(AddProductEvent);
            this.CloseButton.Click += new EventHandler(CloseEvent);
        }

        private void AddProductEvent(object sender, EventArgs e)
        {
            Products.ProductsList.Add(new ProductModel()
            {
                Name = this.productNameText.Text,
                Price = double.Parse(this.productPriceText.Text),
                Category = this.productCategoryText.Text
            });

            this.Close();
        }

        private void CloseEvent(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
