using System;

namespace Bars
{
    internal class VertBar
    {
        private int height;

        public VertBar(int height)
        {
            this.height = height;
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("|");
            }
        }
    }
}