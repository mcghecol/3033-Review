using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUML
{
    class Class1
    {
        public int SoonerID { get; set; }
        public  string FirstName     {get;set;}
        public string LastName       {get;set;}
        public bool IsOnProbation    {get;set;}
        public double GPA            {get;set;}
        private double BursarBalance {get;set;}

        public Class1()
        {
            SoonerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 1000;
        }

        public Class1(int id, string fName, string lName, double BursarBalance) 
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {
            if (amount > 0)
            {
                BursarBalance = BursarBalance - amount;
            }
            else
            {
                throw new Exception();
            }
            
        }
        public double CheckBalance()
        {
            return BursarBalance;
        }
        // <summary> Creates a string representation of our class
        public override string ToString()
        {
            string output = $"{FirstName} {LastName}";
            if (IsOnProbation==true)
            {
                output += "is on probation";
            }
            else
            {
                output += "is not on probation";
            }
            output += $"They have a {GPA.ToString("N2")} GPA +" +
                $"and they owe {BursarBalance.ToString("C2")}";
            return output;
        }
    }
}
