using System;
using System.Collections.Generic;
using System.Text;

namespace ooplab2
{

    class Conus
    {
        public static double r1 { get; set; }
        public static double r2 { get; set; }
        public static double h { get; set; }
        public void Parametrs()
        {
            Console.WriteLine("Введите больший радиус усечённого конуса\n r1=");
            r1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите меньший радиус усечённого конуса\n r2=");
            r2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту усечённого конуса");
            h = Double.Parse(Console.ReadLine());
        }
        public void Result()
        {
            double V = (Math.PI * h * (r1 * r1 + r1 * r2 + r2 * r2)) / 3;
            Console.WriteLine("Объём усечённого конуса = {0}", V);
        }
        ~Conus()
        {
            Console.WriteLine("oh no");
        }


    }
}