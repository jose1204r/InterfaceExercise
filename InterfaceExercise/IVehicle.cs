using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {

        public void Numberofwheel();

        public int Year { get; set; }

        public void  seatingCapacity();

        public void Gastype();



    }
}
