using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PotrosuvackaKosnicka.Models;

namespace PotrosuvackaKosnicka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.productList.Items.AddRange(Products.GetProductsForListBox().ToArray());
            
            this.productList.SelectedIndexChanged += new EventHandler(ProductListEvent);
            this.addToCard.Click += new EventHandler(AddToCardEvent);
            this.removeFromCard.Click += new EventHandler(RemoveFromCardEvent);
            this.addNewProduct.Click += new EventHandler(AddNewProductEvent);
            this.deleteProduct.Click += new EventHandler(RemoveProductEvent);
            this.deleteProductsList.Click += new EventHandler(RemoveAllProductEvent);
            this.removeAllFromCard.Click += new EventHandler(RemoveAllCardEvent);
        }

        private void ProductListEvent(object sender, EventArgs e)
        {
            if (this.productList.SelectedItem == null) return;

            var element = Products.GetProducts()
                .FirstOrDefault(item => string.Equals(item.Name, this.productList.SelectedItem.ToString(), 
                    StringComparison.CurrentCultureIgnoreCase));

            this.productNameText.Text = element.Name;
            this.productCategoryText.Text = element.Category;
            this.productPriceText.Text = element.Price.ToString(CultureInfo.InvariantCulture);
        }
        private void AddToCardEvent(object sender, EventArgs e)
        {
            Card.CardList.Add(new ProductModel()
            {
                Name = this.productNameText.Text,
                Price = double.Parse(this.productPriceText.Text),
                Category = productCategoryText.Text
            });

            RefreshCardList();
            CalculateTotalPrice();
        }
        private void RemoveFromCardEvent(object sender, EventArgs e)
        {
            if (this.cardList.SelectedItem == null) return;

            var element = Card.CardList
                .FirstOrDefault(item => string.Equals(item.Name, this.productList.SelectedItem.ToString(),
                    StringComparison.CurrentCultureIgnoreCase));

            Card.CardList.Remove(element);
            RefreshCardList();
            CalculateTotalPrice();
        }
        private void AddNewProductEvent(object sender, EventArgs e)
        {
            var addProcuctForm = new AddProductForm();
            addProcuctForm.Show();
            addProcuctForm.FormClosed += (o, args) => { RefreshProductList(); };
        }
        private void RemoveProductEvent(object sender, EventArgs e)
        {
            var element = Products.GetProducts()
                .FirstOrDefault(item => string.Equals(item.Name, this.productList.SelectedItem.ToString(),
                    StringComparison.CurrentCultureIgnoreCase));

            Products.ProductsList.Remove(element);
            RefreshProductList();
        }
        private void RemoveAllProductEvent(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Dali ste sigurni deka sakate daja ispraznite cela lista so produkti ?",
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res != DialogResult.OK) return;

            Products.ProductsList.Clear();
            RefreshProductList();
            RefreshCardList();
        }
        private void RemoveAllCardEvent(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Dali ste sigurni deka sakate daja ispraznite cela kosnicka ?",
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res != DialogResult.OK) return;
            Card.CardList.Clear();
            RefreshCardList();

            CalculateTotalPrice();
        }
        
        private void CalculateTotalPrice()
        {
            double totalPrice = 0;
            
            foreach (var item in this.cardList.Items)
            {
                var element = Card.CardList
                    .FirstOrDefault(q => string.Equals(q.Name, item.ToString(),
                        StringComparison.CurrentCultureIgnoreCase));

                totalPrice += element.Price;
            }

            this.totalInCardText.Text = totalPrice.ToString();
        }
        private void RefreshProductList()
        {
            this.productList.Items.Clear();
            this.productList.Items.AddRange(Products.GetProductsForListBox().ToArray());
        }
        private void RefreshCardList()
        {
            this.cardList.Items.Clear();
            this.cardList.Items.AddRange(Card.GetAllInListBoxModel().ToArray());
        }
    }
}
