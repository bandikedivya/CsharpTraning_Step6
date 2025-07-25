using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegatesWithReturn.MallPlan;

namespace DelegatesWithReturn
{
    public class MallPlan
    {

        // Delegate returns a string (for construction message)
        public delegate string ArchitectrueMall(string custname, string mallname);


        // Delegate returns a bool (checks a store in mall)
        public delegate bool CheckStoreAvalability(string checkstore);


        // Delegate returns a void (adds a new store in mall)
        public delegate void AddNewStalls(string storename);


        // Delegate returns a void (to give mall construction success message)
        public delegate string MallConstSuccess(string mallname);



        public string Mall(string custname, string mallname)
        {
            return $"{custname} want to Construct a Mall Named {mallname}, has planning to have 20 shops and with Huge Car and Bike Parking Area ";
        }

        public bool CheckAvailabilty(string checkstore)
        {
            string[] mallcolelction = { "Stores", "Restuarant", "Theater", "Play Zone" };
            foreach (string mall in mallcolelction)
            {
                if (mall.Equals(checkstore))
                {
                    return true;
                }
            }
            return false;
        }


        public void AddStore(string storename)
        {
            Console.WriteLine($"Adding {storename} Stall to the Plan");
        }

        public string MallContructSuccess(string mallname)
        {
            return $"{mallname} Constructed Successfully, Having 20 shops and with a Huge Car and Bike Parking Area. And Added Stalls as well.";
        }


    }

    class MallConstruction
    {
        static void Main()
        {
            MallPlan mallPlan = new MallPlan();  //As the class is non-static, creating instance for Houseplan class



            //Registering methods with delegate

            ArchitectrueMall architectdelegate = mallPlan.Mall;
          

            CheckStoreAvalability checkstoredelegate = mallPlan.CheckAvailabilty;

            AddNewStalls addnewstalldelegate = mallPlan.AddStore;

            MallConstSuccess mallConstSuccessdelegate = mallPlan.MallContructSuccess;

            string custname = "Laural";
            string mallname = "Pheonix Marketcity Mall";

            string customer = architectdelegate(custname, mallname);
            Console.WriteLine(customer);

            // string checkstore = "Restuarant";
            //string checkstore = "Zudio";
            Console.WriteLine();
            Console.WriteLine("Please Enter The Store Name to Check Store is Available in Mall:");
            string checkstore = Console.ReadLine();

            

            bool IsAvailable = checkstoredelegate(checkstore);

         
            if(IsAvailable)
            {
                Console.WriteLine();
                Console.WriteLine("Store is Available in Mall");
            }
            else
            {
                Console.WriteLine("Sorry!! The Store You are Looking For is Not Avaliable in Mall");
            }



            Console.WriteLine();

            Console.WriteLine("========================Adding New Store=======================");
            Console.WriteLine();
            Console.WriteLine("Please Enter The Store Name to Add in the Mall:");
            string storename = Console.ReadLine();

            addnewstalldelegate(storename);

            Console.WriteLine("Please Enter The Store Name to Check Store is Available in Mall:");
            string checkstore1 = Console.ReadLine();


            if (IsAvailable)
            {
                Console.WriteLine();
                Console.WriteLine("Store is Available in Mall");
            }
            else if (storename.Contains("KFC"))
            {
                Console.WriteLine();
                Console.WriteLine("KFC Food Stall is Now Available in Mall");
            }
            else
            {
                Console.WriteLine("Sorry!, The Store You are Looking For is Not Avaliable in Mall");
            }

            









        }
    }
}
