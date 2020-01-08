
using AmazingAnimalWidgets;
using CSharp8.DefaultImplementation;
using System;

namespace DefaultInterfaceMembers
{
    class DefaultImplementation
    {
      public static void Main(string[] args)
        {
            //Square shape = new Square(); will not have the IncrementHeight method.. if we need it then we will have to implement it
            //in the class.. we can also create private static methods in the interface
            Shape shape = new Square();
            shape.IncrementHeight(10);
            Console.WriteLine(shape.Area());
        }




        //static void Main(string[] args)
        //{
        //    // we can add method to an interface without worrying about the 
        //    //classes where we wud have to implement them by providing a default implementation.
        //    IAnimalWidget.SetAmountToFeed(20);
        //    var dog = new DogWidget();
        //    var cat = new CatWidget();
        //    var hamster = new HamsterWidget();

        //    var animals = new IAnimalWidget[] { dog, cat, hamster };

        //    dog.Feed();

        //    foreach (var animal in animals)
        //    {
        //        animal.Feed();
        //        Console.WriteLine($"Happiness level for {animal.Name}: {animal.Happiness}");
        //    }
        //}
    }
}
