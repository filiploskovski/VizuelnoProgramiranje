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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.cityList.SelectedIndexChanged += new EventHandler(CityListEvent);
            this.addCity.Click += new EventHandler(AddCityEvent);
            this.deleteCity.Click += new EventHandler(DeleteCityEvent);
            this.addApartment.Click += new EventHandler(AddApartmentEvent);
        }

        private void CityListEvent(object sender, EventArgs e)
        {
            RefreshApartments();
            CheapestApartment();

        }

        private void AddCityEvent(object sender, EventArgs e)
        {
            var addCityForm = new AddCityForm();
            addCityForm.Show();
            addCityForm.FormClosed += (o, args) => {RefreshCities(); };

        }

        private void DeleteCityEvent(object sender, EventArgs e)
        {
            var city = this.cityList.SelectedItem;

            if(city == null) return;

            DialogResult res = MessageBox.Show("Dali sakate da go izbrisete gradot",
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res != DialogResult.OK) return;
            var element =
                ApplicationMemory.Cities.FirstOrDefault(item => item.Name.ToLower() == city.ToString().ToLower());
            ApplicationMemory.Cities.Remove(element);
            RefreshCities();
        }

        private void AddApartmentEvent(object sender, EventArgs e)
        {
            var city = this.cityList.SelectedItem;

            if (city == null) return;

            var addApartment = new AddApartmentForm(city.ToString().ToLower());
            addApartment.Show();
            addApartment.FormClosed += (o, args) => { 
                RefreshApartments();
                CheapestApartment();
            };
        }

        private void RefreshApartments()
        {
            if (this.cityList.SelectedItem == null) return;
            
            var selectedCity = this.cityList.SelectedItem.ToString().ToLower();
            this.aratmentList.Items.Clear();
            this.aratmentList.Items.AddRange(ApplicationMemory.GetApartmestsForCityListBox(selectedCity).ToArray());
        }

        private void CheapestApartment()
        {
            if(this.cityList.SelectedItem == null) return;
            var selectedCity = this.cityList.SelectedItem.ToString().ToLower();
            var city = ApplicationMemory.Cities.FirstOrDefault(item => item.Name.ToLower() == selectedCity);
            if(!city.Apartments.Any()) return;
            var cheapest = city.Apartments.OrderBy(item => item.Price).FirstOrDefault();
            this.cheapersApartment.Text = $"{cheapest.Address} - {cheapest.Price}";
        }

        private void RefreshCities()
        {
            this.cityList.Items.Clear();
            this.cityList.Items.AddRange(ApplicationMemory.GetCitiesForListBox().ToArray());
        }
    }
}
