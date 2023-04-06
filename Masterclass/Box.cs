using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masterclass
{
    class Box
    {
        // Member Variables
        private int length = 3;
        private int height = 3;

        // Properties
        public int Width { get; set; }

        public int Volume
        {
            get { return this.length * this.height * this.Width; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        // Constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        // Getters and Setters
        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Length: {length}, Height: {height}, Width: {Width}, Volume: {Volume}");
        }
    }
}
