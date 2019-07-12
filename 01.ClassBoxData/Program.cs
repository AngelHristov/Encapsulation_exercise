namespace _01.ClassBoxData
{
    using System;

    public class Program
    {
        public static void Main()
        {
            try
            {
                double lenght = GetValue();
                double width = GetValue();
                double height = GetValue();

                Box box = new Box(lenght, width, height);

                Console.WriteLine($"Surface Area - {GetSurfaceArea(box):F2}");
                Console.WriteLine($"Lateral Surface Area - {GetLateralSurfaceArea(box):F2}");
                Console.WriteLine($"Volume - {GetVolume(box):F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
             
        }

        public static double GetVolume(Box box)
        {
            double volume = box.Length * box.Width * box.Height;

            return volume;
        }

        public static double GetLateralSurfaceArea(Box box)
        {
            double lateralSurfaceArea = 2 * box.Width * box.Height + 2 * box.Height * box.Length;

            return lateralSurfaceArea;
        }

        public static double GetSurfaceArea(Box box)
        {
            double surfaceArea = 2 * box.Length * box.Width + 2 * box.Width * box.Height + 2 * box.Height * box.Length;

            return surfaceArea;
        }

        public static double GetValue()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
