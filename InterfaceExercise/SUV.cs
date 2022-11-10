using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise 
{
    internal class SUV : IVehicle , ICompany
    {
       public string Make { get; set; }   

       public string Model { get; set; }

        public string HasSunroof(bool roof) 
        {
            if (roof == true) 
            { 
                return "YES";
            } 

            else 
            { 
                return "NO";
            }
        } 

        public void CompanyName()
        {

            Console.WriteLine("COMPANY: Lexus ");
        }

        public void PhoneNumber()
        {

            Console.WriteLine("PHONE: (800) 678-2343");

        }

        public void Numberofwheel()
        {
            Console.WriteLine("WHEELS: This car has four wheels ");

        }


        public int Year { get; set; }


        public void seatingCapacity()
        {

            Console.WriteLine("SEAT CAPACITY: Support ten Person");

        }



        public void Gastype()

        {

            Console.WriteLine("GAS TYPE: car runnig with regular Gas ");
        }

    }
}
