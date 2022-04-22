using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP_Advance_Final.Models
{
    public class Teacher : Employees
    {

        public override double Tax()
        {
            if (Salary<500)
            {
                return 0;
            }
            if (Salary>500 && Salary <750)
            {
                return Salary * .03;
            }
            if (Salary >=750)
            {
                return Salary * .05;
            }
            return 0;

        }

        public override double NetSalary()
        {
            return Salary - Tax();
        }

        public override bool CheckNetSalary()
        {
            if (NetSalary()<200)
            {
                return false;
            }
            if (NetSalary()>=200)
            {
                return true;
            }
            return false;

        }

        public override double CalculateSoialSecurity()
        {
            if (Gender==1)
            {
                if (Salary<=500)
                {
                    return 10;
                }
                if (Salary>500)
                {
                    return 20;
                }
            }
            if (Gender==2)
            {
                if (Salary <= 500)
                {
                    return 20;
                }
                if (Salary > 500)
                {
                    return 40;
                }
            }
            return 0;
        }

        public override double SalaryAfterCalculateSoialSecurity()
        {
            return NetSalary() - CalculateSoialSecurity();
        }

        public override string print()
        {
            return "Success:Hello, you completed the registration form successfully., Mr. " + FName + " " + LName + " We will deduct from Your Salary:" + CalculateSoialSecurity() + " JDYour Salary after deduct:" + SalaryAfterCalculateSoialSecurity() + " JD";

        }

        public override string NotEnoughSalaryAfterCalculateSoialSecurity()
        {
            return "Failed to register Sorry! You cannot Join with Us. Tax applied on your salary: " + Tax() + ", Your Salary after Tax & deductions:" + NetSalary() + " JD.";
        }
    }
}