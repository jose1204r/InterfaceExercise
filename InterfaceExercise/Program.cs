using System;
using System.Collections.Generic;
namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //done Create 2 Interfaces called IVehicle & ICompany

            //done Create 3 classes called Car , Truck , & SUV

            //done In your IVehicle

            /*done  Create 4 members that Car, Truck, & SUV all have in common.
             * done Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*done Create 2 members that are specific to each every company
             * done regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //done In each of your car, truck, and suv classes

            /*doneCreate 2 members that are specific to each class
             *done Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * doneThen, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //done Now, create objects of your 3 classes and give their members values;
            //done Creatively display and organize their 9values
            Console.WriteLine("************************************************");


            // TRUCK 
            var  ford = new Truck();
            ford.Make = "Ford";
            ford.Model = "XD";
            
            ford.Year = 2022;
            ford.CompanyName();
            ford.PhoneNumber();
            ford.Numberofwheel();
            ford.Gastype();
            ford.seatingCapacity();
            var bed = ford.HasBed(true);
            


            Console.WriteLine("Make :    Model :      Year :   Hasbed : ");
            Console.WriteLine($"{ford.Make}       {ford.Model}           {ford.Year}    {bed}");

            // CAR
            // 

            Console.WriteLine("************************************************");


            var Nissan = new Car();
            Nissan.CompanyName();
            Nissan.PhoneNumber();
            Nissan.Make = "Nissan";
            Nissan.Year = 2019;
            Nissan.Model = "Centra";
            Nissan.seatingCapacity();
            Nissan.Numberofwheel();
            Nissan.Gastype();



            Console.WriteLine("Make :    Model :      Year :   ");
            Console.WriteLine($"{Nissan.Make}   {Nissan.Model}          {Nissan.Year}");

            // SUV 
            Console.WriteLine("************************************************");

            var Audi = new SUV();
            Audi.CompanyName();
            Audi.PhoneNumber();
            Audi.Make = "Audi";
            Audi.Year = 2022;
            Audi.Model = "Q7";
            var sroof = Audi.HasSunroof(true);
            Audi.Numberofwheel();
            Audi.Gastype();
            Audi.seatingCapacity();


            Console.WriteLine("Make :    Model :      Year :   Sunroof : ");
            Console.WriteLine($"{Audi.Make}      {Audi.Model}          {Audi.Year}           {sroof}");

        }
    }
}
