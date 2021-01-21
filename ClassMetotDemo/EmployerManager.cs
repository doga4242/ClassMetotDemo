using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class EmployerManager
    {
        public void add(Employer employer)
        {
            Console.WriteLine("Employer added "+employer.EmployerName);
            Console.WriteLine("Employer added "+ employer.EmployerSurname);
            Console.WriteLine("Employer added "+employer.EmployerId);
            Console.WriteLine("Employer added "+employer.EmployerAge);
        }
        public void delete(Employer employer)
        {
            Console.WriteLine("Employer deleted " + employer.EmployerName);
            Console.WriteLine("Employer deleted " + employer.EmployerSurname);
            Console.WriteLine("Employer deleted " + employer.EmployerId);
            Console.WriteLine("Employer deleted " + employer.EmployerAge);
        }
        public void change(Employer employer)
        {
            Console.WriteLine("Employer changed " + employer.EmployerName);
            Console.WriteLine("Employer changed " + employer.EmployerSurname);
            Console.WriteLine("Employer changed " + employer.EmployerId);
            Console.WriteLine("Employer changed " + employer.EmployerAge);

        }
    
    
    }
   

}
