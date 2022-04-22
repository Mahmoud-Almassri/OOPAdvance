using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP_Advance_Final.Models
{
    public abstract class Employees
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Job_Type { get; set; }
        public int Gender { get; set; }
        public double Salary { get; set; }
        public double deduct { get; set; }
        public double insintive { get; set; }
        public string Validation()
        {
            string Success=string.Empty;
            if (FName==string.Empty)
            {
                return "Please Enter Your First Name";
            }
            if(LName==string.Empty)
            {
                return "Please Enter Your Last Name";
            }
            if (Salary<200)
            {
                return "Sorry Your Salary Is Less Than 200 ";
            }
            return Success;
        }
        public bool Check()
        {
            if (FName==string.Empty)
            {
                return false;
            }
            if(LName==string.Empty)
            {
                return false;
            }
            if (Salary<200)
            {
                return false;
            }
            return true;
        }
        public abstract double Tax();
        public abstract double NetSalary();
        public abstract bool CheckNetSalary();
        public abstract double CalculateSoialSecurity();
        public abstract double SalaryAfterCalculateSoialSecurity();
        public abstract string print();
        public abstract string NotEnoughSalaryAfterCalculateSoialSecurity();


    }
}