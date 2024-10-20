using Inheritence_TestUsing_Vehicle.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_TestUsing_Vehicle
{
    public sealed class MotorCycle : Vehicle,IExteriorDesign
    {
        string[] designs;
        public void MaxPowerInBPH()
        {
            Console.WriteLine("Max Power BHP");
        }
        public void Wearhalmet()
        {
            Console.WriteLine("Wear halmet.....");
        }
        public override void Drive()
        {
            Console.WriteLine("Drive Like MotorCycle");
        }

        public string[] AddExteriorDesign(string designs)
        {
            string[] design = designs.Split(',');
            return design;
        }
    }
}
