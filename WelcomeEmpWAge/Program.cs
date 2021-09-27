using System;

namespace WelcomeEmpWAge
{
    class Program
    {
        //Non Static Method
        public void welcomeEmployee()
        {
            Console.WriteLine("Welcome to Employee Wages");
        }


        //Static method
        public static string EmpName()
        {
            string name = "Amit";
            return name;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.welcomeEmployee();
            Console.WriteLine(EmpName());
        }
    }
}
