using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP01Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Theoretical Questions
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


            #endregion

            #region 5. In Main
            // 1. Read center name from user
            string centerName;
            do
            {
                Console.Write("Enter Delivery Center Name: ");
                centerName = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(centerName));

            DeliveryCenter center = new DeliveryCenter(centerName);

            // 2. Standard Shipment
            Console.WriteLine("\n--- Enter Standard Shipment Details ---");
            Console.Write("Enter Tracking Code: ");
            string stdTrackingCode = Console.ReadLine();

            Console.Write("Enter Description: ");
            string stdDescription = Console.ReadLine();

            Console.Write("Enter Weight (kg): ");
            double.TryParse(Console.ReadLine(), out double stdWeight);

            Console.Write("Enter Delivery Fee ($): ");
            decimal.TryParse(Console.ReadLine(), out decimal stdDeliveryFee);

            Console.Write("Enter City: ");
            string stdCity = Console.ReadLine();

            Console.Write("Enter Street: ");
            string stdStreet = Console.ReadLine();

            Console.Write("Enter Building Number: ");
            int.TryParse(Console.ReadLine(), out int stdBuildingNumber);

            DeliveryAddress stdAddress = new DeliveryAddress(stdCity, stdStreet, stdBuildingNumber);
            StandardShipment standardShipment = new StandardShipment(stdTrackingCode, stdDescription, stdWeight, stdDeliveryFee, stdAddress);

            if (center.AddShipment(standardShipment))
                Console.WriteLine("Shipment Added Successfully.");

            // 3. Express Shipment
            Console.WriteLine("\n--- Enter Express Shipment Details ---");
            Console.Write("Enter Extra Fee ($): ");
            decimal.TryParse(Console.ReadLine(), out decimal expExtraFee);

            Console.Write("Enter Tracking Code: ");
            string expTrackingCode = Console.ReadLine();

            Console.Write("Enter Description: ");
            string expDescription = Console.ReadLine();

            Console.Write("Enter Weight (kg): ");
            double.TryParse(Console.ReadLine(), out double expWeight);

            Console.Write("Enter Delivery Fee ($): ");
            decimal.TryParse(Console.ReadLine(), out decimal expDeliveryFee);

            Console.Write("Enter City: ");
            string expCity = Console.ReadLine();

            Console.Write("Enter Street: ");
            string expStreet = Console.ReadLine();

            Console.Write("Enter Building Number: ");
            int.TryParse(Console.ReadLine(), out int expBuildingNumber);

            DeliveryAddress expAddress = new DeliveryAddress(expCity, expStreet, expBuildingNumber);
            ExpressShipment expressShipment = new ExpressShipment(expExtraFee, expTrackingCode, expDescription, expWeight, expDeliveryFee, expAddress);

            if (center.AddShipment(expressShipment))
                Console.WriteLine("Shipment Added Successfully.");

            // 4. International Shipment
            Console.WriteLine("\n--- Enter International Shipment Details ---");
            Console.Write("Enter Destination Country: ");
            string intCountry = Console.ReadLine();

            Console.Write("Enter Customs Fee ($): ");
            decimal.TryParse(Console.ReadLine(), out decimal intCustomsFee);

            Console.Write("Enter Tracking Code: ");
            string intTrackingCode = Console.ReadLine();

            Console.Write("Enter Description: ");
            string intDescription = Console.ReadLine();

            Console.Write("Enter Weight (kg): ");
            double.TryParse(Console.ReadLine(), out double intWeight);

            Console.Write("Enter Delivery Fee ($): ");
            decimal.TryParse(Console.ReadLine(), out decimal intDeliveryFee);

            Console.Write("Enter City: ");
            string intCity = Console.ReadLine();

            Console.Write("Enter Street: ");
            string intStreet = Console.ReadLine();

            Console.Write("Enter Building Number: ");
            int.TryParse(Console.ReadLine(), out int intBuildingNumber);

            DeliveryAddress intAddress = new DeliveryAddress(intCity, intStreet, intBuildingNumber);
            InternationalShipment internationalShipment = new InternationalShipment(intCountry, intCustomsFee, intTrackingCode, intDescription, intWeight, intDeliveryFee, intAddress);

            if (center.AddShipment(internationalShipment))
                Console.WriteLine("Shipment Added Successfully.");

            // 5. Print Output
            Console.WriteLine("\n");
            center.PrintAllShipments();


            // ==================================================
            // 6. Search for a shipment using the tracking code indexer
            // ==================================================
            Console.Write("\nEnter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();

            
            Shipment foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine("\n Shipment Found:");
                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine($"\n Shipment with tracking code '{searchCode}' not found.");
            }

            // ==================================================
            // 7. Remove one shipment using its tracking code
            // ==================================================
            Console.Write("\nEnter Tracking Code to Remove: ");
            string removeCode = Console.ReadLine();

            bool isRemoved = center.RemoveShipmentByTrackingCode(removeCode);

            if (isRemoved)
            {
                Console.WriteLine("\nShipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("\nFailed to remove shipment (Tracking Code not found).");
            }


            // ==================================================
            // 8. Print the remaining shipments (مطابق للصورة تماماً)
            // ==================================================
            Console.WriteLine("\n==================================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("==================================================");

            center.PrintAllShipments();
            #endregion


        }
    }
}
