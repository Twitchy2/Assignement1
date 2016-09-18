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
    /// <summary>
    /// Program: Sharp Mail Order Form
    /// Author: Logan Sikora-Beder
    /// App Creation Date: Sometime between Sept 14-18
    /// Description: This will take a bunch of factors and help output the desired bonus based on 
    /// monthly earings and hours
    /// </summary>
    public partial class MailOrder : Form
    {
        public MailOrder()
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
            TotalHoursLabel.Text = "Total Hours Worked:";
            NameLabel.Text = "Employee Name:";
            IdLabel.Text = "Employee ID:";
            BonusLabel.Text = "Sales Bonus:";
            TotalSalesLabel.Text = "Total Monthly Sales:";
            LanguageGroupBox.Text = "Choose Language";
            CalculateButton.Text = "Calculate";
            ClearButton.Text = "Clear";
            PrintButton.Text = "Print";
            EmployeeIdTextBox.Text = "Enter Text...";
            EmployeeNameTextBox.Text = "Enter Text...";
            TotalMonthlySalesTextBox.Text = "Enter Text...";
            TotalHoursWorkedTextBox.Text = "Enter Text...";
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
            TotalHoursLabel.Text = "Obshcheye kolichestvo otrabotannykh chasov:";
            NameLabel.Text = "Imya sotrudnika:";
            IdLabel.Text = "Id sotrudnikov:";
            BonusLabel.Text = "Bonus prodazh:";
            TotalSalesLabel.Text = "Obshchiy mesyachnyy ob`yem prodazh:";
            LanguageGroupBox.Text = "Vyberite yazyk";
            CalculateButton.Text = "podschityvat'";
            ClearButton.Text = "Ochistit";
            PrintButton.Text = "Raspechatat'";
            EmployeeIdTextBox.Text = "Vvedite tekst ...";
            EmployeeNameTextBox.Text = "Vvedite tekst ...";
            TotalMonthlySalesTextBox.Text = "Vvedite tekst ...";
            TotalHoursWorkedTextBox.Text = "Vvedite tekst ...";
        }
        /// <summary>
        /// Everything becomes quebec when you touch this button of radio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //I forgot all of my french about a day after I stopped learning it
            TotalHoursLabel.Text = "Total des heures travaillées:";
            NameLabel.Text = "Nom de l'employé:";
            IdLabel.Text = "id employé:";
            BonusLabel.Text = "Bonus de vente:";
            TotalSalesLabel.Text = "Total des ventes mensuelles:";
            LanguageGroupBox.Text = "Choisissez la langue";
            CalculateButton.Text = "Calculer";
            ClearButton.Text = "Clair";
            PrintButton.Text = "Impression";
            EmployeeIdTextBox.Text = "Entrez du texte...";
            EmployeeNameTextBox.Text = "Entrez du texte...";
            TotalMonthlySalesTextBox.Text = "Entrez du texte...";
            TotalHoursWorkedTextBox.Text = "Entrez du texte...";

        }
        /// <summary>
        /// Pressing this button will give a conformation of recieveing the bonus
        /// alert, you wont actually get one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congradulations! The Bonus has been sent! / Félicitation ! Le bonus a été envoyé! / Congradulations ! Bonus otpravleno!", "You're Winner!");
        }
        /// <summary>
        /// This button will calculate that bonus based on the math inside it
        /// Math is fun, isn't it?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double HoursWorked;
                double TotalSales;
                double SalesBonus;

                HoursWorked = Convert.ToDouble(TotalHoursWorkedTextBox.Text);
                TotalSales = Convert.ToDouble(TotalMonthlySalesTextBox.Text);
                //Makes sure that hours arent too high
                if (HoursWorked > 160)
                {
                    MessageBox.Show("Sorry, Hours Worked cannot be over 160!", "Too much overtime yo!");
                }
                else
                {

                    SalesBonus = (HoursWorked / 160) * (TotalSales * 0.02);
                    BonusTextBox.Text = SalesBonus.ToString("C2");
                }


            }
            catch (Exception wrong)
            {

                MessageBox.Show("These all need to be numbers, and total hours worked can't be more than 160 hours!", "You blew it.");
            }
        }
        /// <summary>
        /// This will clear all of the textboxes so you can put stuff in them again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            EmployeeIdTextBox.Text = "";
            EmployeeNameTextBox.Text = "";
            TotalHoursWorkedTextBox.Text = "";
            BonusTextBox.Text = "";
        }
    }
}
