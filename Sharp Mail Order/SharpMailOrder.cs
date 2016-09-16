using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_Mail_Order
{
    public partial class SharpMailOrder : Form
    {
        public SharpMailOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Radio button which returns everything to english
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //puts everything back to england
            HoursWorkedLabel.Text = "Total Hours Worked:";
            NameLabel.Text = "Employee Name:";
            IdLabel.Text = "Employee ID:";
            BonusLabel.Text = "Sales Bonus:";
            MonthlySalesLabel.Text = "Total Monthly Sales:";
            LanguageGroupBox.Text = "Choose Language";
            CalculateButton.Text = "Calculate";
            ClearButton.Text = "Clear";
        }
        /// <summary>
        /// Radio button that turns things russian
        /// It also screws up all my labels :(
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CykaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Oh my god these lines are gonna screw up all my labels
            HoursWorkedLabel.Text = "Obshcheye kolichestvo otrabotannykh chasov:";
            NameLabel.Text = "Imya sotrudnika:";
            IdLabel.Text = "Id sotrudnikov:";
            BonusLabel.Text = "Bonus prodazh:";
            MonthlySalesLabel.Text = "Obshchiy mesyachnyy ob`yem prodazh:";
            LanguageGroupBox.Text = "Vyberite yazyk";
            CalculateButton.Text = "podschityvat'";
            ClearButton.Text = "Ochistit";
            PrintButton.Text = "Raspechatat'";
        }
        /// <summary>
        /// Everything becomes quebec when you touch this button of radio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //I forgot all of my french about a day after I stopped learning it
            HoursWorkedLabel.Text = "Obshcheye kolichestvo otrabotannykh chasov:";
            NameLabel.Text = "Imya sotrudnika:";
            IdLabel.Text = "Id sotrudnikov:";
            BonusLabel.Text = "Bonus prodazh:";
            MonthlySalesLabel.Text = "Obshchiy mesyachnyy ob`yem prodazh:";
            LanguageGroupBox.Text = "Vyberite yazyk";
            CalculateButton.Text = "podschityvat'";
            ClearButton.Text = "Ochistit";

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congradulations! The Bonus has been sent!", "You're Winner!");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
