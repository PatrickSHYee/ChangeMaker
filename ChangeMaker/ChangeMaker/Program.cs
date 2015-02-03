using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
            ChangeAmount(3.18m);
            Console.WriteLine();
            ChangeAmount(0.99m);
            Console.WriteLine();
            ChangeAmount(12.93m);

            Console.ReadKey();

            // extra credit
            decimal tester = 5280m;
            Console.WriteLine("Amount: {0:C}", tester / 10);
            DollarChange(tester/10m);

            
        }


        /// <summary>
        /// Make change with each amounts.
        /// </summary>
        /// <param name="amount">decimal value of money</param>
        /// <returns>Storage unit for the change</returns>
        public static Change ChangeAmount(decimal amount) 
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();

            Console.WriteLine("Amount: {0:C}", amount);

            // count each quarter taken and subtracts 
            while (amount >= 0.25m)
            {
                amount -= 0.25m;
                amountAsChange.Quarters++;
            }

            while (amount >= 0.1m)
            {
                amount -= 0.1m;
                amountAsChange.Dimes++;
            }

            while (amount >= 0.05m)
            {
                amount -= 0.05m;
                amountAsChange.Nickles++;
            }

            while (amount != 0)
            {
                amount -= 0.01m;
                amountAsChange.Pennies++;
            }
            Console.WriteLine("Quarters: {0}\nDimes: {1}\nNickles: {2}\nPennies: {3}", amountAsChange.Quarters, amountAsChange.Dimes, amountAsChange.Nickles,
                amountAsChange.Pennies);

            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Subtracts the big dollar bills of the amount
        /// </summary>
        /// <param name="amount">Big dollar amount</param>
        /// <returns>calls the ChangeAmount to return Change object</returns>
        public static Change DollarChange(decimal amount)
        {
            DollarChange amountAsBills = new DollarChange();
            while (amount >= 100m)
            {
                amountAsBills.Hundreds++;
                amount -= 100m;
            }

            while (amount >= 50.0m)
            {
                amountAsBills.Fifties++;
                amount -= 50m;
            }

            while (amount >= 20m)
            {
                amountAsBills.Twenties++;
                amount -= 20m;
            }

            while (amount >= 10m)
            {
                amountAsBills.Tens++;
                amount -= 10m;
            }
            while (amount >= 5m)
            {
                amountAsBills.Fives++;
                amount -= 5m;
            }
            while (amount != 0)
            {
                amountAsBills.Ones++;
                amount -= 1m;
            }

            Console.WriteLine("$100s: {0}\n$50s: {1}\n$20s: {2}", amountAsBills.Hundreds, amountAsBills.Fifties, amountAsBills.Twenties);
            Console.WriteLine("$10s: {0}\n$5s: {1}\n$1s: {2}", amountAsBills.Tens, amountAsBills.Fives, amountAsBills.Ones);


            return ChangeAmount(amount);
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;

            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }

    public class DollarChange
    {
        // properties that are public
        public int Hundreds { get; set; }
        public int Fifties { get; set; }
        public int Twenties { get; set; }
        public int Tens { get; set; }
        public int Fives { get; set; }
        public int Ones { get; set; }
        public DollarChange()
        {
            this.Hundreds = 0;
            this.Fifties = 0;
            this.Twenties = 0;
            this.Tens = 0;
            this.Fives = 0;
            this.Ones = 0;
        }
    }
}
