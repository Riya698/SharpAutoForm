using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoForm
{
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            /* stereo system = 425.76 $
             * leather interior = 987.41 $
             * computer navigation = 1741.23 $
             * pearlized = 345.72 $
             * customized detailing = 599.99 $
             */
            double _subTotal = 0;
            if (StereoSystem_checkBox.Checked)
                _subTotal += 425.76;
            if (LeatherInterior_checkBox.Checked)
                _subTotal += 987.41;
            if (ComputerNavigation_checkBox.Checked)
                _subTotal += 1741.23;
            if (Pearlized_radioButton.Checked)
                _subTotal += 345.72;
            if (CustomizedDetailing_radioButton.Checked)
                _subTotal += 599.99;

            SubTotal_textBox.Text = _subTotal.ToString();
            SalesTax_textBox.Text = taxCalculation();
            try
            {
                Total_textBox.Text = (double.Parse(BasePrice_textBox.Text) + _subTotal + double.Parse(SalesTax_textBox.Text)).ToString();
                AmountDue_textBox.Text = (double.Parse(Total_textBox.Text) - double.Parse(TradeIn_textBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("You must enter values on all the fields", "Error");
                Clear_button.PerformClick();
            }


        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            BasePrice_textBox.Clear();
            AdditionalOptions_textBox.Clear();
            SubTotal_textBox.Clear();
            SalesTax_textBox.Clear();
            Total_textBox.Clear();
            TradeIn_textBox.Text = "0";
            AmountDue_textBox.Clear();
            StereoSystem_checkBox.Checked = false;
            LeatherInterior_checkBox.Checked = false;
            ComputerNavigation_checkBox.Checked = false;
            Standard_radioButton.Checked = true;

            BasePrice_textBox.Focus();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the amount due\non a New or Used Vehicle", "About");
        }

        private void JustDigits(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8) // digits or backspace
                e.Handled = true;
        }
        private string taxCalculation()
        {
            return ((double.Parse(SubTotal_textBox.Text)/100)*13).ToString();
        }
    }
}
