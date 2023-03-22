using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil1
{
   internal class Program
   {
      static void Main(string[] args)
      {
           string employ="Omri";
           int dollar=0;
          double shekel, commision,price,payment;
         Console.WriteLine("Welcome to " + employ + "'s Store");
          string customer;
            Console.WriteLine("Please enter your name: ");
           customer = Console.ReadLine();
           Console.WriteLine("Please enter the Amount in US$ you want: ");
            dollar = int.Parse(Console.ReadLine());
           shekel = 3.42 * dollar;
            commision = 0.015 * shekel;
          price = shekel + commision;
payment = commision / 3;
           Console.WriteLine( "    #The Amount of Dollars you get is: " + dollar + "\n    #The Price in Shekels is: " + shekel + "\n    #The price of commission is: " +commision+ "\n    #The fee in one payment is: " +payment+
             "\n    #The fee in three payment is " + (payment * 3) + 
               "\n    #The total price is: " + price);


     }
  }
}
