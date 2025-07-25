using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWithReturns
{

    // Delegate that returns a string (for order preparation messages)
    public delegate string OrderPreparation(string order);

    // Delegate that returns void (for order confirmation)
    public delegate void OrderConfirmation(string order);

    // Delegate that returns bool (to check availability)
    public delegate bool OrderAvailability(string order);

    //Script imp 
    public class Restaurant
    {

        /// <summary>
        /// // Returns preparation message as a string
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public string PrepareMainCourse(string order)
        {
            return $"Main Course Chef is preparing: {order}";
        }

        /// <summary>
        /// Confirms the order (void delegate)
        /// </summary>
        /// <param name="order"></param>
        public void ConfirmOrder(string order)
        {
            Console.WriteLine($"Order confirmed: {order}");
        }

        /// <summary>
        /// // Checks if the order is available using a foreach loop
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool CheckOrderAvailability(string order)
        {
            string[] availableItems = { "Pasta", "Ice Cream", "Mojito" }; //Restaturemet having 3 itesm
            foreach (string item in availableItems)
            {
                if (item.Equals(order))
                {
                    return true;
                }
            }
            return false;
        }


    }

    class ExecuteRestaurant
    {
        static void Main(string[] args)
        {

            Restaurant restaurant = new Restaurant();  // Create a Restaurant object

            //Registration method along with delegate....
            OrderPreparation preparationDelegate = restaurant.PrepareMainCourse;
            OrderConfirmation confirmationDelegate = restaurant.ConfirmOrder;
            OrderAvailability availabilityDelegate = restaurant.CheckOrderAvailability;

            // Customer places an order for "Pasta"
            string order = "Pasta";
           // Console.WriteLine("Checking order availability...");

            ////Main Goal - Lets Delegate handle  -> Delegate speaks the methods
            //bool isAvailable = availabilityDelegate(order);
            //if (isAvailable)
            //{
            //    string status = preparationDelegate(order);
            //    Console.WriteLine(status);

            //    confirmationDelegate(order);
            //}
            //else
            //{
            //    Console.WriteLine($"Sorry, {order} is not available.");
            //}


            //Console.WriteLine("--------------------------------------------------");

            //string order1 = "Chicken Biryani";
            //Console.WriteLine("\nCustomer places an order for Chicken Biryani...");
            //bool isAvailable1 = availabilityDelegate(order1);
            //if (isAvailable1)
            //{
            //    string status = preparationDelegate(order1);
            //    Console.WriteLine(status);

            //    confirmationDelegate(order1);
            //}
            //else
            //{
            //    Console.WriteLine($"Sorry, {order1} is not available.");
            //}


            ////Order -> check order ---> Prepare ---> confirmation


        }
    }
}


//smart work if you know everything .... Lazy
