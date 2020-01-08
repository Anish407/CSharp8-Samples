using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public class DisposeUsingSample
    {
        public static void Main(string[] args)
        {
            //earlier we used to write the disposable inside a block
            //this was done so that the value is disposed when the block is exited
            // now we can use the using declarations to create a disposable object
            // this will be disposed only when the function is exited.. if we want to dispose the object early 
            // we wud need to use the expressions
            //using (var x= new Sample())
            //{

            //}
            //Console.WriteLine("Complete");
           

            //in this case first complete will be logged and then the dispose() will be invoked
            using var x = new Sample();

            Console.WriteLine("Complete");
        }
    }


    class Sample : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing");
        }
    }
}
