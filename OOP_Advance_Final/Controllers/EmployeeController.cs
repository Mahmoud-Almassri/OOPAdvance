using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OOP_Advance_Final.Models;
namespace OOP_Advance_Final.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Employee()
        {
           

            return View();
        }
        public ActionResult Save()
        {
            string First_Name = Request.Form["txtFName"];
            string Last_Name = Request.Form["txtLName"];
            int Gender = Convert.ToInt32(Request.Form["Gender"]);
            double Salary = Convert.ToDouble(Request.Form["txtSalary"]);
            double Deduction = Convert.ToDouble(Request.Form["txtDiducation"]);
            double Insentive = Convert.ToDouble(Request.Form["txtInsintive"]);
            int job_type = Convert.ToInt32(Request.Form["ddlJob"]);
            if (job_type == 1)
            {
                Teacher teacher = new Teacher();
                teacher.FName = First_Name;
                teacher.LName = Last_Name;
                teacher.Gender = Gender;
                teacher.Salary = Salary;
                teacher.insintive = Insentive;
                teacher.deduct = Deduction;
                if (teacher.Check())
                {
                    if (teacher.CheckNetSalary())
                    {
                        ViewBag.Success = teacher.print();
                    }
                    else
                    {
                        ViewBag.Faild = teacher.NotEnoughSalaryAfterCalculateSoialSecurity();
                    }
                }
                else
                {
                    ViewBag.Error = teacher.Validation();
                }
            }
            return View("Employee");
        }
	}
}