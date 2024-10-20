using Inheritence_TestUsing_Vehicle.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_TestUsing_Vehicle
{
    public sealed class Car : Vehicle,IInteriorDesign
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }

        public string[] AddInteriorDesign(string design)
        {
            string[] d = design.Split(',');
            return d;
        }

        public void Break()
        {
            Console.WriteLine("Breaking");
        }
        public override void Drive()
        {
            Console.WriteLine("Drive like Car");
        }
    }
}
