using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IznajmuvanjeApartmani.Models;

namespace IznajmuvanjeApartmani
{
    public partial class AddApartmentForm : Form
    {
        private string City { get; set; }
        
        public AddApartmentForm(string city)
        {
            this.City = city;

            InitializeComponent();
            this.add.Click += new EventHandler(AddButtonEvent);
            this.close.Click += new EventHandler(CloseButtonEvent);
        }

        public void AddButtonEvent(object sender, EventArgs e)
        {
            ApplicationMemory.Cities.FirstOrDefault(item => item.Name.ToLower() == this.City.ToLower()).Apartments.Add(new Apartments()
            {
                Price = int.Parse(this.price.Text),
                Address = this.address.Text
            });

            this.Close();
        }

        public void CloseButtonEvent(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
