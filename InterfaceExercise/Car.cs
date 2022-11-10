using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle , ICompany
    {

        public string Model { get; set; }

        public string Make { get; set; }


        public void Numberofwheel() 
        {
            Console.WriteLine("WHEELS : This car has four wheels ");
             
        }


        public int Year { get; set; }


        public void seatingCapacity() 
        {

            Console.WriteLine("SEAT CAPACITY : Support eigth Person");

        }



        public void Gastype() 
        
        {

           Console.WriteLine("GAS TYPE : car runnig with regular Gas ");
        }

        public void CompanyName() 
        { 
        
           Console.WriteLine("COMPANY: Car Max");
        }

        public void PhoneNumber () 
        { 
        
          Console.WriteLine("(560) 569-3456");
        
        }

    }
}
