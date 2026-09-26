namespace OOP01Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {

             
            /// Part 01 : Theoretical Questions
             
            /// Question 1
            /// 
            /// a) What is the difference between a class and a struct?

            /// A Class is a Reference Type stored in the Heap that supports inheritance and assignment by reference.
            /// A Struct is a Value Type stored on the Stack that does not support inheritance and copies full data upon assignment.

            ///b) Why are classes more suitable than structs for large applications? 

            ///  Classes stored in the Heap and also Struct stored on the Stack (limited Size ) 
            /// Classes are allocated on the Heap, which provides a much larger and flexible memory space for managing complex objects and large datasets

            Console.ReadLine();
        }
    }
}
