using System;
namespace BT1
{
    class PTB1
    {
        protected double a, b;

        public PTB1(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public virtual void Giai()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Phuong trinh co nghiem x = {x:F2}");
            }
        }
    }

    class PTB2 : PTB1
    {
        private double c;

        public PTB2(double a, double b, double c) : base(a, b)
        {
            this.c = c;
        }

        public override void Giai()
        {
            if (a == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh bac 1: ");
                base.Giai();
                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep x = {x:F2}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem phan biet:");
                Console.WriteLine($"x1 = {x1:F2}, x2 = {x2:F2}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("=== GIAI PHUONG TRINH BAC 2: a*x^2 + b*x + c = 0 ===");
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine()!);

            PTB2 phuongtrinh = new PTB2(a, b, c);
            phuongtrinh.Giai();
            Console.ReadKey();
        }
    }
}
