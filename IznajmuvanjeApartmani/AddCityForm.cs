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
    public partial class AddCityForm : Form
    {
        public AddCityForm()
        {
            InitializeComponent();
            this.addButton.Click += new EventHandler(AddButtonEvent);
            this.closeButton.Click += new EventHandler(CloseEvent);
        }

        public void AddButtonEvent(object sender, EventArgs e)
        {
            ApplicationMemory.Cities.Add(new City()
            {
                Name = this.name.Text,
                PostalCode = int.Parse(this.postalCode.Text)
            });
            this.Close();
        }

        public void CloseEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            if (this.name.Text.Any()) return;
            errorName.SetError(this.name,"!!!!");
            MessageBox.Show("Please enter valid data");
        }
    }
}
