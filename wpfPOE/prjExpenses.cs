using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfPOE
{
    class prjExpenses
    {
        #region Declaring income and expenses 
        public int income;
        public int groceries;
        public int utilities;
        public int travelCost;
        public int cellPhone;
        public int otherExpenses;
        public double total;
        public double deductions;
        #endregion

        #region Declaring vehicle expnses
        public string carType;
        public int carPrice;
        public int carDeposit;
        public int carInterest;
        public int carInsurance;
        public double carTotal;
        #endregion

        #region Declaring savings
        public int saving;
        public int years;
        public int saveInterest;
        public double SavingTotal;
        #endregion

        #region Income and expenses gets and sets
        public int Income { get => income; set => income = value; }
        public int Groceries { get => groceries; set => groceries = value; }
        public int Utilities { get => utilities; set => utilities = value; }
        public int TravelCost { get => travelCost; set => travelCost = value; }
        public int CellPhone { get => cellPhone; set => cellPhone = value; }
        public int OtherExpenses { get => otherExpenses; set => otherExpenses = value; }
        public double Total;
        public double Deductions;
        #endregion

        #region Vehcile expenses gets and sets
        public string CarType { get => carType; set => carType = value; }
        public int CarPrice { get => carPrice; set => carPrice = value; }
        public int CarDeposit { get => carDeposit; set => carDeposit = value; }
        public int CarInterest { get => carInterest; set => carInterest = value; }
        public int CarInsurance { get => carInsurance; set => carInsurance = value; }
        public double CarTotal { get => carTotal; set => carTotal = value; }
        #endregion

        #region savings gets and sets
        public int Saving { get => saving; set => saving = value; }
        public int Years { get => years; set => years = value; }
        public int SaveInterest { get => saveInterest; set => saveInterest = value; }
        public double savingTotal { get => SavingTotal; set => SavingTotal = value; }
        #endregion

        public prjExpenses(int income, int groceries, int utilities, int travelCost,
                             int cellPhone, int otherExpenses, string carType, int carPrice, int carDeposit,
                             int carInterest, int carInsurance, int saving, int years, int saveInterest)
        {
            #region income and expenses
            this.Income = income;
            this.Groceries = groceries;
            this.Utilities = utilities;
            this.TravelCost = travelCost;
            this.CellPhone = cellPhone;
            this.OtherExpenses = otherExpenses;
            this.total = CalculateTotal(groceries, utilities, travelCost, cellPhone, otherExpenses, deductions);
            this.deductions = TaxDeductions(income);
            #endregion

            #region vehcile expenses
            this.carType = carType;
            this.carPrice = carPrice;
            this.carDeposit = carDeposit;
            this.carInterest = carInterest;
            this.carInsurance = carInsurance;
            this.carTotal = CalculateCarTotal(carPrice, carInsurance, carInterest, carDeposit);
            #endregion

            #region savings
            this.saving = saving;
            this.years = years;
            this.saveInterest = saveInterest;
            this.SavingTotal = CalculateSavings(saving, years, saveInterest);
            #endregion
        }

        private double CalculateSavings(int saving, int years, int saveInterest)
        {
            return (this.saving / ((1 + this.saveInterest/100) * (this.years * 12)));
        }

        public double CalculateCarTotal(int carPrice, int carInsurance, int carInterest, int carDeposit) //formula for car monthly payment
        {
            return (((this.carPrice - this.CarDeposit) * (1 + (this.carInterest / 100) * 60) / 60) + this.carInsurance);
        }

        public double TaxDeductions(int income) //formula for tax deductions
        {
            return (0.15 * income);
        }

        public double CalculateTotal(int groceries, int utilities, int travelCost,
                                      int cellPhone, int otherExpenses, double deductions) //formula for total expenses
        {
            return deductions + groceries + utilities + travelCost + cellPhone + otherExpenses;
        }
    }
}
