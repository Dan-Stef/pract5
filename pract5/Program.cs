using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if (x < -2) throw new Exception();
                else if (x>2) throw new Exception();
                 else return Math.Log(4-x*x);
            }
            catch (Exception)
            {
                Console.WriteLine("Неверная область определения (-2;2)"); 
                throw;
            }
            
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("f(-2;2)");
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)  
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
            Console.ReadKey();
        }
    }
}
