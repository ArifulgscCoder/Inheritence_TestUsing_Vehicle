using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_TestUsing_Vehicle
{
    public class Vehicle
    {
        public void StartEngine(string noiseTomakeWhenStarting)
        {
            Console.WriteLine($"Satrting engine {noiseTomakeWhenStarting}");
        }
        public void StopEngine(string noiseToMakeWhenStoping) 
        {
            Console.WriteLine($"Stoping engine {noiseToMakeWhenStoping}");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Default Implementation");
        }
        public void AddSpecialInstraction()
        {
            Console.WriteLine("No Entrance");
        }
    }
}
