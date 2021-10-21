using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBridge
{
    public class PMWindow : IWindowImpl
    {
        public void DrawLine()
        {
            Console.WriteLine("Line drown according to the implementation from PMWindow\n");
        }

        public void DrawText()
        {
            Console.WriteLine("Text wrote according to the implementation from PMWindow\n");
        }
    }
}
