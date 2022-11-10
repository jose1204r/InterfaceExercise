using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle , ICompany
    {
        
        
        public string Make { get; set; }

        public string  HasBed( bool bed) 
        {

            if (bed == true)

            {
                return "YES";
            }
            else 
            {
                return "NO";
            
            }
        }
        public string Model { get; set; }

        public void CompanyName()
        {

            Console.WriteLine("COMPANY:TRUCK SELLS LLC ");
        }

        public void PhoneNumber()
        {

            Console.WriteLine("PHONE: (800) 349-3456");

        }


        public void Numberofwheel()
        {
            Console.WriteLine("WHEELS : This car has 12 wheels ");

        }


        public int Year { get; set; }


        public void seatingCapacity()
        {

            Console.WriteLine("SEAT CAPACITY :  2 Person and  cargo loads");

        }



        public void Gastype()

        {

            Console.WriteLine("GAS TYPE : Truck runnig with Diesel");
        }




    }
}
