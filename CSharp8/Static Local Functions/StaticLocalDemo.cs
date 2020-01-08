using System;

namespace StaticLocalFunctions
{
    class StaticLocalDemo
    {
        private static string Field = "initial-value";
        public void Run()
        {
            var state = "42";
            DoSomethingWithState();
            DoSomethingWithField();

            Console.WriteLine($"state: {state}");
            Console.WriteLine($"Field: {Field}");


            //static local functions are different from local functions as they dont have access to the instant state
            // this improves performance as the current state is not captured as this is an overhead
            static string DoSomethingWithState()
            {
                // return state = "99";
                return "99";
            }

            static string DoSomethingWithField()
            {
                return Field = "modified!";
            }
        }
    }
}
