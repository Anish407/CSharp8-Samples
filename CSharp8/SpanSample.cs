using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    class SpanSample
    {
        static void Main(string[] args)
        {
           
            int[] xx = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(5 < 5);
            int sum = 0, sum2 = 0;

            for (int i = 0; i < xx.Length - 1; i++)
            {
                sum += xx[i];
            }
            Console.WriteLine("");
            for (int i = 1; i < xx.Length; i++)
            {
                sum2 += xx[i];
            }



            Console.WriteLine($"{sum} {sum2}");
            //getData("Anish");
            ////getData(arr,1);
            //getData(xx);
            Console.ReadKey();
        }

        static ReadOnlySpan<char> getData(ReadOnlySpan<char> req)
        {
            return req.Slice(0, 2);
        }

        static ReadOnlySpan<int> getData(ReadOnlySpan<int> req, int x)
        {
            return req.Slice(0, 2);
        }

        static Span<int> getData(Span<int> req)
        {
            return req.Slice(0, 2);
        }
    }
}
