namespace _01.ClassBoxData
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double lenght = GetValue();
            double width = GetValue();
            double height = GetValue();

            Box box = new Box(lenght, width, height);

            Console.WriteLine($"Surface Area – {GetSurfaceArea(box)}");
            Console.WriteLine($"Lateral Surface Area – {GetLateralSurfaceArea(box)}");
            Console.WriteLine($"Volume – {GetVolume(box)}"); 
        }

        public static double GetVolume(Box box)
        {
            double volume = box.Lenght * box.Width * box.Height;

            return volume;
        }

        public static double GetLateralSurfaceArea(Box box)
        {
            double lateralSurfaceArea = 2 * box.Width * box.Height + 2 * box.Height * box.Lenght;

            return lateralSurfaceArea;
        }

        public static double GetSurfaceArea(Box box)
        {
            double surfaceArea = 2 * box.Lenght * box.Width + 2 * box.Width * box.Height + 2 * box.Height * box.Lenght;

            return surfaceArea;
        }

        public static double GetValue()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
