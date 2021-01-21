using System;

namespace ClassMetotDemo
{
    class Program
    {

        



        static void Main(string[] args)
        {
            Employer employer1 = new Employer { EmployerAge = "18", EmployerId = "123131231", EmployerName = "Diesdamat", EmployerSurname = "Karamemeta" };
            Employer employer2 = new Employer { EmployerAge = "41", EmployerSurname = "Merkez", EmployerName = "Adana", EmployerId = "213213235" };
            Employer employer3 = new Employer { EmployerId = "2283746287", EmployerName = "Daliska", EmployerSurname = "Kaysak", EmployerAge = "31" };

            Employer[] employers = new Employer[] { employer1, employer2, employer3 };

            EmployerManager employerManagers = new EmployerManager();

            Console.WriteLine("Show every employer.\n");

           foreach(var emp in employers)
            {
                Console.WriteLine("Employer ID is: " + emp.EmployerId);
                Console.WriteLine("Employer Name is " + emp.EmployerName);
                Console.WriteLine("Employer Surname is " + emp.EmployerSurname);
                Console.WriteLine("Employer Age is "+emp.EmployerAge);
                Console.WriteLine("---------------------------------");
                Console.WriteLine();
            }

            
            employerManagers.add(employer1);

            Console.WriteLine("----------------------------------");

            employerManagers.delete(employer2);

            Console.WriteLine("----------------------------------");
            
            employerManagers.change(employer3);
           
            Console.WriteLine("----------------------------------");
        }
       
        
    }
}
