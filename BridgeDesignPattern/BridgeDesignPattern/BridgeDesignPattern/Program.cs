using System;

namespace DesignPatternBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box on XWindow
            Console.WriteLine("Box on XWindow");
            BoxWindow boxWin = new BoxWindow(new XWindow());
            boxWin.DisplayBox();

            //Box on PMWindow
            Console.WriteLine("Box on PMWindow");
            BoxWindow boxWin2 = new BoxWindow(new PMWindow());
            boxWin2.DisplayBox();

            //Button on XWindow
            Console.WriteLine("Button on XWindow");
            ButtonWindow butWin =new ButtonWindow(new XWindow());
            butWin.DisplayButton();


            //Button on PMWindow
            Console.WriteLine("Button on PMWindow");
            ButtonWindow butWin2 = new ButtonWindow(new PMWindow());
            butWin2.DisplayButton();

            Console.ReadKey();
        }
    }
}
