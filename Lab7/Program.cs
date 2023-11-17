using System;
namespace Lab7
{
    public class Vector
    {
        public double x1, y1, z1, x2, y2, z2;

        public Vector()
        {
            x1 = y1 = z1 = x2 = y2 = z2 = 0;
        }

        public void Input()
        {
            Console.Write("x1 = "); x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = "); y1 = double.Parse(Console.ReadLine());
            Console.Write("z1 = "); z1 = double.Parse(Console.ReadLine());

            Console.Write("x2 = "); x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = "); y2 = double.Parse(Console.ReadLine());
            Console.Write("z2 = "); z2 = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("x1 = " + x1.ToString());
            Console.WriteLine("y1 = " + y1.ToString());
            Console.WriteLine("z1 = " + z1.ToString());

            Console.WriteLine("x2 = " + x2.ToString());
            Console.WriteLine("y2 = " + y2.ToString());
            Console.WriteLine("z2 = " + z2.ToString());
        }

        public Vector Plus(Vector a, Vector b)
        {
            Vector c = new Vector();
            c.x1 = a.x2 + a.x1;
            c.y1 = a.y2 + a.y1;
            c.z1 = a.z2 + a.z1;

            c.x2 = a.x2 + a.x1;
            c.y2 = a.y2 + a.y1;
            c.z2 = a.z2 + a.z1;

            return c;
        }

        public Vector Minus(Vector a, Vector b)
        {
            Vector c = new Vector();
            c.x1 = a.x2 - a.x1;
            c.y1 = a.y2 - a.y1;
            c.z1 = a.z2 - a.z1;

            c.x2 = a.x2 - a.x1;
            c.y2 = a.y2 - a.y1;
            c.z2 = a.z2 - a.z1;
            return c;
        }

        public double Scal(Vector a)
        {
            return (this.x2 - this.x1) * (a.x2 - a.x1) + (this.y2 - this.y1) * (a.y2 - a.y1) + (this.z2 - this.z1) * (a.z2 - a.z1);
        }

        public double Len()
        {
            return Math.Sqrt((this.x2 - this.x1) * (this.x2 - this.x1) + (this.y2 - this.y1) * (this.y2 - this.y1) + (this.z2 - this.z1) * (this.z2 - this.z1));
        }

        public double Cos(Vector a)
        {
            return this.Scal(a) / this.Len() / a.Len();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(), b = new Vector();

            Console.WriteLine("Введите вектор a:");
            a.Input();

            Console.WriteLine("\nВведите вектор b");
            b.Input();

            Console.WriteLine("\na + b =");
            a.Plus(a, b).Output();

            Console.WriteLine("\na - b =");
            a.Minus(a, b).Output();

            Console.WriteLine("\na * b = " + a.Scal(b).ToString() + "\n");

            Console.WriteLine("\n|a| = " + a.Len().ToString() + "\n");

            Console.WriteLine("\ncos(a^b) = " + a.Cos(b).ToString() + "\n");

            Console.ReadKey();
        }
    }
}
