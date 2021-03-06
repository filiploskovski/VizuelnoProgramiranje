﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NarackaNaPica.Extensions;

namespace NarackaNaPica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillLists();

            this.sSize.CheckedChanged += new EventHandler(GenericEventHandler);
            this.mSize.CheckedChanged += new EventHandler(GenericEventHandler);
            this.lSize.CheckedChanged += new EventHandler(GenericEventHandler);

            this.feferonki.Click += new EventHandler(GenericEventHandler);
            this.sirenje.Click += new EventHandler(GenericEventHandler);
            this.kecap.Click += new EventHandler(GenericEventHandler);

            this.gaziranSokKolicina.TextChanged += new EventHandler(GenericEventHandler);
            this.gustiSokKolicina.TextChanged += new EventHandler(GenericEventHandler);
            this.pivoKolicina.TextChanged += new EventHandler(GenericEventHandler);

            this.cenaGaziranSok.TextChanged += new EventHandler(GenericEventHandler);
            this.cenaGustiSok.TextChanged += new EventHandler(GenericEventHandler);
            this.cenaPivo.TextChanged += new EventHandler(GenericEventHandler);

            this.desertList.SelectedIndexChanged += new EventHandler(GenericEventHandler);
        }

        private void GenericEventHandler(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void OrderButtonEvent(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("", "Vasata Naracka", MessageBoxButtons.OK);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void CancelButtonEvent(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void CalculatePrice()
        {
            var pricePerSize = GetValueFromSizeRadio();
            var pricePerFillings = GetValueFromFillings();
            var pricePerQuantity = GetValueFromQuantaty();
            var pricePerDesert = GetValueFromDesert();

            VkupnoNaplata(new int[] { pricePerSize, pricePerFillings, pricePerQuantity, pricePerDesert });
        }

        private int GetValueFromDesert()
        {
            var price = 0;
            if (desertList.SelectedItem == null) return 0;
            if (desertList.SelectedItem.ToString() == "Ovosna Pita") price += 70;
            if(desertList.SelectedItem.ToString() == "Sladoled") price += 80;
            if (desertList.SelectedItem.ToString() == "Torta") price += 90;

            this.cenaNaDesert.Text = price.ToString();

            return price;
        }

        private int GetValueFromQuantaty()
        {
            var gaziran = Helper.GetNumberFromText(gaziranSokKolicina.Text) != 0
                ? Helper.GetNumberFromText(gaziranSokKolicina.Text) * Helper.GetNumberFromText(cenaGaziranSok.Text) : 0;

            var gusti = Helper.GetNumberFromText(gustiSokKolicina.Text) != 0
                ? Helper.GetNumberFromText(gustiSokKolicina.Text) * Helper.GetNumberFromText(cenaGustiSok.Text) : 0;

            var pivo = Helper.GetNumberFromText(pivoKolicina.Text) != 0
                ? Helper.GetNumberFromText(pivoKolicina.Text) * Helper.GetNumberFromText(cenaPivo.Text) : 0;

            return gaziran + gusti + pivo;
        }

        private int GetValueFromFillings()
        {
            var totalPrice = 0;
            if (feferonki.Checked) totalPrice += Helper.GetNumberFromText(feferonkiText.Text);
            if (sirenje.Checked) totalPrice += Helper.GetNumberFromText(sirenjeText.Text);
            if (kecap.Checked) totalPrice += Helper.GetNumberFromText(kecapText.Text);
            return totalPrice;
        }

        private int GetValueFromSizeRadio()
        {
            var price = 0;
            if (sSize.Checked) price = Helper.GetNumberFromText(sPrize.Text);
            if (mSize.Checked) price = Helper.GetNumberFromText(mPrize.Text);
            if (lSize.Checked) price = Helper.GetNumberFromText(lPrize.Text);
            return price;
        }

        private void VkupnoNaplata(int[] args)
        {
            vkupnoZaNaplata.Text = args.Sum().ToString();
        }

        private void FillLists()
        {
            this.desertList.Items.Add("Ovosna Pita");
            this.desertList.Items.Add("Sladoled");
            this.desertList.Items.Add("Torta");
        }
    }
}
