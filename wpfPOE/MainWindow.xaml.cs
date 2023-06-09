﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfPOE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click_1(object sender, RoutedEventArgs e)
        {
            #region Income and expenses 
            int Income = Convert.ToInt32(txtIncome.Text); //Sets the income and expenses to the corresponding textboxes
            int Groceries = Convert.ToInt32(txtGroceries.Text);
            int Utilities = Convert.ToInt32(txtWaterLights.Text);
            int TravelCost = Convert.ToInt32(txtTravel.Text);
            int CellPhone = Convert.ToInt32(txtPhone.Text);
            int OtherExpenses = Convert.ToInt32(txtExpenses.Text);
            #endregion

            #region Rent and housing
            int rent = Convert.ToInt32(txtMonthRent.Text); //Sets accomodation expenses to corresponding textboxes
            int house = Convert.ToInt32(txtPurchasePrice.Text);
            int deposit = Convert.ToInt32(txtDeposit.Text);
            int interest = Convert.ToInt32(txtHouseInterest.Text);
            int numOfMonths = Convert.ToInt32(txtNumOfMonths.Text);
            #endregion

            #region Vehcile expenses
            string carType = Convert.ToString(txtMake.Text); //Sets car expenses to corresponding textboxes
            int carPrice = Convert.ToInt32(txtCarPrice.Text);
            int carDeposit = Convert.ToInt32(txtCardeposit.Text);
            int carInterest = Convert.ToInt32(txtCarinterest.Text);
            int carInsurance = Convert.ToInt32(txtCarinsurance.Text);
            #endregion

            #region Savings
            int savings = Convert.ToInt32(txtSavings.Text); //Sets saving to corresponding textboxes
            int years = Convert.ToInt32(txtYears.Text);
            int saveInterest = Convert.ToInt32(txtSaveInterestRate.Text);
            #endregion

            prjAccomodation pa = new prjAccomodation(Income, Groceries, Utilities, TravelCost, CellPhone,
                                            OtherExpenses, rent, house, deposit, interest, numOfMonths,
                                            carType, carPrice, carDeposit, carInterest, carInsurance,
                                            savings, years, saveInterest);

            MessageBox.Show(pa.ToString()); //Displays the message 
        }

        private void btnClear_Click_1(object sender, RoutedEventArgs e)
        {
            txtIncome.Clear();
            txtGroceries.Clear();
            txtWaterLights.Clear();
            txtTravel.Clear();
            txtPhone.Clear();
            txtExpenses.Clear();

            txtMonthRent.Clear();
            txtPurchasePrice.Clear();
            txtDeposit.Clear();
            txtHouseInterest.Clear();
            txtNumOfMonths.Clear();

            txtMake.Clear();
            txtCarPrice.Clear();
            txtCardeposit.Clear();
            txtCarinterest.Clear();
            txtCarinsurance.Clear();

            txtSavings.Clear();
            txtYears.Clear();
            txtSaveInterestRate.Clear();
        }
    }
}
