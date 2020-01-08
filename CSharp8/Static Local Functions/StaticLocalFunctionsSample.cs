using System;

namespace StaticLocalFunctions
{
    class StaticLocalFunctionsSample
    {
        static void Main(string[] args)
        {
            //var demo = new StaticLocalDemo();
            //demo.Run();

            MyClass myClass = new MyClass(10, 20);

            Console.WriteLine("x={0} and y={1}", myClass.X, myClass.Y);

            Console.ReadLine();
        }

        class MyClass
        {
            // Use this to assign values in 1 line
            public MyClass(int x, int y) => (X, Y) = (x, y);
           

            public int X { get; }
            public int Y { get; }
        }
    }
}
