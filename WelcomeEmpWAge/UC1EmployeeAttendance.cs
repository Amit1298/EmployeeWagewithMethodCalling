using System;

namespace UC1EmployeeAttendance
{
    class Employee
    {
        //constant
        public int IS_FULL_TIME;


        //Constructor 
        Employee()
        {
            IS_FULL_TIME = 1;
        }
        static void Main(string[] args)
        {
            //Computation
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Employee empwage = new Employee();
            if (empCheck == empwage.IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
