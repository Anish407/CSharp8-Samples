using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.Concurrent;

namespace CSharp8
{
    class rangeandIndices
    {
        public static void Main(string[] args)
        {
            int[] arr =new int[] { 1,2,3,4};

            //copies by reference
            //int[] arr2 = arr;

            //creates new copy od the array
            //int[] arr2 = arr[..];
            //arr2[0] = 5;

            //copy from start to end (ignore last item)
            //int[] arr3 = arr[..^1];
            //arr3.ToList().ForEach(i => Console.WriteLine(i));


            //copy from 1 index till second last
            //int[] arr4 = arr[1..^1];
            //arr4.ToList().ForEach(i => Console.WriteLine(i));

            //copy from 1st index to the rest
            //int[] arr5 = arr[1..];
            //arr5.ToList().ForEach(i => Console.WriteLine(i));

            //copy last 2 elements and returns an array
            int[] arr6 = arr[^2..];
            arr6.ToList().ForEach(i => Console.WriteLine(i));

            //gets the second last element 
            int arr7 = arr[^2];

        }
    }
}
