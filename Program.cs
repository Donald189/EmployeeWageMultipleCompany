using System;

namespace EmployeeWageMultipleCompany
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Using OOPS");

            //EmployeeAttendance empAttendance = new EmployeeAttendance();
            //empAttendance.PresentorAbsent();

            //EmployeeWage empWage = new EmployeeWage();
            //empWage.CalEmployee();

            //EmpSwitchCase empSwitchCase = new EmpSwitchCase();
            //empSwitchCase.CalEmployeeSwitch();

            //EmpWagePerMonth empWagePerMonth = new EmpWagePerMonth();
            //empWagePerMonth.CalEmployeeWagePerMonth();

            //EmpMonthlyWageCalc empMonthlyWageCalc = new EmpMonthlyWageCalc();
            //empMonthlyWageCalc.EmpWageCalcWithHoursOrDays();

            ////For multiple company
            //MultipleCompanyWage EmployWageobj = new MultipleCompanyWage();
            //Console.WriteLine("Company 1: " + EmployWageobj.Company1);
            //EmployWageobj.CalEmpWage();
            //MultipleCompanyWage2 multipleCompanyWage2 = new MultipleCompanyWage2();
            //Console.WriteLine("Company 2: " + multipleCompanyWage2.Company2);
            //multipleCompanyWage2.CalEmpWage();
            //MultipleCompanyWage3 multipleCompanyWage3 = new MultipleCompanyWage3();
            //Console.WriteLine("Company 3: " + multipleCompanyWage3.Company3);
            //multipleCompanyWage3.CalEmpWage();

            //For Employee Wage Manage
            EmployeeWageManage obj = new EmployeeWageManage("Dmart", 20, 2, 10);
            EmployeeWageManage relaince = new EmployeeWageManage("Relaince", 10, 4, 20);
            obj.computeEmpWage();
            Console.WriteLine(obj.toString());
            relaince.computeEmpWage();
            Console.WriteLine(relaince.toString());
        }
    }
}
