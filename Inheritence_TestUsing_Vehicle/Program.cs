using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_TestUsing_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                DoTask();
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            GetAriplaneObj();
            GetCarObj();
            GetMotorCypleObj();
            GetVehicle();
        }

        private static void GetVehicle()
        {
            Console.WriteLine();
            Console.WriteLine("Vehicle");
            Vehicle vehicle = new Vehicle();
        }

        private static void GetMotorCypleObj()
        {
            Console.WriteLine("Fly with Motorcycle");
            MotorCycle myMotorCycle = new MotorCycle();
            myMotorCycle.StartEngine("Bhummmm---");
            myMotorCycle.Wearhalmet();
            myMotorCycle.MaxPowerInBPH();
            myMotorCycle.StopEngine("Phut Phut Shhh....");
            myMotorCycle.Drive();
            
            string[] desigs = myMotorCycle.AddExteriorDesign("Hydrolic Horn,High Speed,Beautiful Sound");
            Console.WriteLine("");
            Console.WriteLine("Exterior Design for MotorCycle");
            //foreach (string desig in desigs)
            //{
            //    Console.WriteLine(desig);
            //}
            for (int i = 0; i < desigs.Length; i++)
            {
                Console.WriteLine($" {(i+1).ToString()}. {desigs[i]}");
            }
        }

        private static void GetCarObj()
        {
            Console.WriteLine("Journey by car");
            Car myCar= new Car();
            myCar.StartEngine("Bhrummm..bhrumm");
            myCar.Accelerate();
            myCar.Break();
            myCar.StopEngine("Phut....Phut");
            myCar.Drive();
            string[] carDesign = myCar.AddInteriorDesign("Tissu Box,Airfreshner");
            for (int i = 0;i < carDesign.Length;i++)
            {
                Console.WriteLine($"{(i+1).ToString()}. {carDesign[i]}");
            }
            Console.WriteLine("------------------");
        }
        

        private static void GetAriplaneObj()
        {
            Console.WriteLine("Journey by airplane");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Cobntact With Tower");
            myPlane.Takeoff();
            myPlane.Land();
            myPlane.StopEngine("Whirr.........");
            myPlane.Drive();
            Console.WriteLine("------------------");
        }
    }
}
