using System;
using AssemblyOne;

namespace AssemblyTwo
{
    
    class Developer: Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Employee.ProtectedCompany);
            Console.WriteLine(Employee.PublicCompany);
            Console.ReadLine();
            
       
        }

    }
}

