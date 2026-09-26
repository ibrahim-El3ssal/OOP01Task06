using static System.Runtime.InteropServices.JavaScript.JSType;

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

            /// Question 2 
            /// a) Which class is the parent class? : Shipment
            /// b) Which class is the child class? : ExpressShipment 
            /// c) What members are inherited by ExpressShipment? : TrackingCode 
            /// d) Why is inheritance better than duplicating the same code in multiple classes? 
            /// Code Reusability (DRY Principle): It allows write-once, use-many code structure by reusing shared logic from the base class without rewriting it in multiple derived classes.
            /// Easier Maintenance &Scalability : Any updates or bug fixes made in the parent class are automatically inherited by all child classes, reducing maintenance time and avoiding code inconsistencies.

            Console.ReadLine();
        }
    }
}
