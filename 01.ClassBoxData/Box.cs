﻿namespace _01.ClassBoxData
{
    using System;

    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public double Lenght
        {
            get => this.lenght;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                lenght = value;
            }
        }

        public double Width
        {
            get => this.width;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Height
        {
            get => this.height;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }
    }
}
