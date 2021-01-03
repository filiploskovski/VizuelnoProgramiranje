using System;
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
        }

        private void GenericEventHandler(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            var pricePerSize = GetValueFromSizeRadio();
            var pricePerFillings = GetValueFromFillings();
            var pricePerQuantity = GetValueFromQuantaty();

            VkupnoNaplata(new int[] { pricePerSize, pricePerFillings, pricePerQuantity });
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

        private void VkupnoNaplata(int[] args)
        {
            vkupnoZaNaplata.Text = args.Sum().ToString();
        }

        private int GetValueFromSizeRadio()
        {
            var price = 0;
            if (sSize.Checked) price = Helper.GetNumberFromText(sPrize.Text);
            if (mSize.Checked) price = Helper.GetNumberFromText(mPrize.Text);
            if (lSize.Checked) price = Helper.GetNumberFromText(lPrize.Text);
            return price;
        }
    }
}
