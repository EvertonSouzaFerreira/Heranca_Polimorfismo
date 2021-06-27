using System;
using Heranca_Polimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empoyee> list = new List<Empoyee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} date:");
                Console.Write("Outsorced (Y/N)? ");
                char outsorced = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsorced == char.Parse("Y"))
                {
                    Console.Write("Additional charge:");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));

                }
                else
                {
                    list.Add(new Empoyee(name, hours, valuePerHour));
                }               
            }
            Console.WriteLine("PAYMENT");
            foreach (Empoyee emp in list)
            { 
                Console.WriteLine(emp.Name + " - $: " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
