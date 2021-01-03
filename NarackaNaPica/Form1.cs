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

            this.sSize.CheckedChanged += new EventHandler(sSize_CheckedChanged);
            this.mSize.CheckedChanged += new EventHandler(sSize_CheckedChanged);
            this.lSize.CheckedChanged += new EventHandler(sSize_CheckedChanged);
        }

        private void sSize_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            var pricePerSize = GetValueFromSizeRadio();

            VkupnoNaplata(pricePerSize);
        }

        private void VkupnoNaplata(int pricePerSize)
        {
            var vkupno = pricePerSize;

            vkupnoZaNaplata.Text = vkupno.ToString();
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
