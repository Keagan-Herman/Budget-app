using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfPOE
{
    class prjAccomodation : prjExpenses
    {
        #region get and set
        public int rent { get; set; }
        public int house { get; set; }
        public int deposit { get; set; }
        public int interest { get; set; }
        public int numOfMonths { get; set; }
        public double homeLoan { get; set; }
        #endregion

        #region setting gets and sets
        public prjAccomodation(int income, int groceries, int utilities, int travelCost, int cellPhone,
                              int otherExpenses, int Rent, int House, int Deposit, int Interest, int NumOfMonths,
                                string carType, int carPrice, int carDeposit,
                             int carInterest, int carInsurance, int saving, int years, int saveInterest)
            : base(income, groceries, utilities, travelCost, cellPhone, otherExpenses, carType, carPrice,
                  carDeposit, carInterest, carInsurance, saving, years, saveInterest)
        {
            this.rent = Rent;
            this.house = House;
            this.deposit = Deposit;
            this.interest = Interest;
            this.numOfMonths = NumOfMonths;
            this.homeLoan = CalculateHomeLoan(House, Interest, NumOfMonths);

        }
        #endregion

        public double CalculateHomeLoan(int House, int Interest, int NumOfMonths) //Formula to calculate monthly house repayment
        {
            return ((this.house - this.deposit) * (1 + (this.interest / 100) * (this.numOfMonths) / 12))
                    / this.numOfMonths;
        }

        #region Income, expenses and vehcile expenses
        public override string ToString() //Displaying the output message at the end of program
        {
            return "INCOME AND EXPENSES" +  //outputting income and expenses

              "\nIncome: R" + this.income + "\nAmount deducted: R" + this.deductions +
              "\nGroceries: R" + this.groceries + "\nUtilities: R" + this.utilities +
              "\nTavel Cost: R" + this.travelCost + "\nCellPhone: R" + this.cellPhone +
              "\nOther Expenses: R" + this.otherExpenses + "\nTotal expenses: R" + this.total +

              "\n" + "\nRENT" +

              "\nMonthly rent: R" + this.rent +  //outputting rent

              "\n" + "\nHousing" +  //outputting housing

               "\nPurchase price: R" + this.house + "\nTotal deposit: R" + this.deposit +
               "\nInterest rate: " + this.interest + "%" +
               "\nNumber of months for repayment: " + this.numOfMonths +
               "\nMonthly repayment: R" + this.homeLoan +

              "\n" + "\nVEHCILE EXPENSES" +  //outputting vehcile 

                 "\nCar type: " + this.carType + "\nCar price: R" + this.CarPrice +
                 "\nTotal deposit: R" + this.CarDeposit + "\nInterest rate : " + this.carInterest + "%" +
                 "\nEstimated insurance premium: R" + this.carInsurance + "\nMonthly cost: R" + this.carTotal +

                 "\n" + "\nSAVINGS" + 

                 "\nSavings: R" + this.saving + "\nYears: " + this.years + "\nInterest rate: " + this.saveInterest + 
                 "%" + "\nMonthly amount to save: R" + this.SavingTotal +

                 "\n" + "\nLEFTOVER MONEY" +

                 "\nAvailable money after deductions: R" + (this.income - (this.total + this.rent + this.house +
                  this.deductions + this.carPrice));  //Formula to calculate money left over after all deductions

        }
        #endregion
    }
}
