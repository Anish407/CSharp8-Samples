using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.DefaultImplementation
{
    public interface Shape
    {
        int height { get; set; }
        int weight { get; set; }

        public int Area()
        {
            return height * weight;
        }

        public void IncrementHeight(int x)
        {
             height += x; ;
        }
    }
}
