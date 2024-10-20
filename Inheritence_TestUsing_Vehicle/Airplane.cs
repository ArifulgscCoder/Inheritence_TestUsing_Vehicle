using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_TestUsing_Vehicle
{
    public sealed class Airplane :Vehicle
    {
        public void Takeoff()
        {
            Console.WriteLine("Taking off");
        }
        public void Land()
        {
            Console.WriteLine("Landing");
        }
        public override void Drive()
        {
            Console.WriteLine("Drive like AirPlane");
        }
    }
}
