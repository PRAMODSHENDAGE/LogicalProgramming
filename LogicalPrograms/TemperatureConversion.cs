using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TemperatureConversion
    {
        double c, f;
        public void Temperatureconversion()
        {
            Console.WriteLine("Enter 1 for CELCIUS to FAHRENHEIT CONVERSION & Enter 2 for FAHRENHEIT to CELCIUS CONVERSION ");
            int Temperatureconversion = Convert.ToInt32(Console.ReadLine());
            switch (Temperatureconversion)
            {
                case 1:
                    Console.WriteLine("Enter any Temperature value in celcius");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = c * 9 / 5 + 32;
                    Console.WriteLine("Temperature in FAHRENHEIT " + f);
                    break;
                case 2:
                    Console.WriteLine("Enter any Temperature value in Fahrenheit");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    Console.WriteLine("Temperature in CELCIUS " + c);
                    break;
            }
        }
    }
}
