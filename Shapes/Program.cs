using System;
using System.Linq;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            try
            {
                Shape curentShape = null;

                switch (data.Length)
                {
                    case 2:
                        curentShape = new Rectangle(data[0], data[1]); // data[0] -> height, data[1] -> width
                        break;

                    case 1:
                        curentShape = new Circle(data[0]); // data[0] -> radius
                        break;

                    default:
                        Console.WriteLine("Too many data!");
                        break;
                }

                if(curentShape != null)
                {
                    Console.WriteLine($"Area: {curentShape.CalculateArea()}");
                    Console.WriteLine($"Perimeter: {curentShape.CalculatePerimeter()}");
                    curentShape.Draw();
                }



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            //Console.WriteLine("Hello World!");
        }
    }
}
