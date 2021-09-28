using System;

namespace UC9totalEmpWageCompany
{
    public class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days: " + totalWorkingDays + " Emp Hrs " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is : " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for Company : " + this.company + " is: " + this.totalEmpWage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject obj = new EmpWageBuilderObject("Obj : ", 20, 2, 10);
            EmpWageBuilderObject obj1 = new EmpWageBuilderObject("Obj1 ", 10, 4, 2);
            obj.computeEmpWage();
            Console.WriteLine(obj.toString());
            obj1.computeEmpWage();
            Console.WriteLine(obj1.toString());
        }

    }
}
