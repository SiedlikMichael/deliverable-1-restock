using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

// See https://aka.ms/new-console-template for more information
//Soda starts with 100 in stock and will need a restock at 40
//Chips starts with 40 in stock and will need a restock at 20
//Candy starts with 60 in stock and will need a restock at 40
//Each item should have a variable that holds its current stock value and a variable that holds the restock value.

namespace stock
{
    class Program
    {

        static void Main()
        {
            int soda = 100;
            int chips = 40;
            int candy = 60;

            int restocksoda = 40;
            int restockchips = 20;
            int restockcandy = 40;

      

            Console.WriteLine("How many sodas have been sold today? 100 in stock");
            int sodasold = int.Parse(Console.ReadLine());

            if (sodasold > soda)
            {
                Console.WriteLine("Too High");
                Console.WriteLine("Please enter in correct amount");
                sodasold = int.Parse(Console.ReadLine());
            }
            else
            {
                soda -= sodasold;
                Console.WriteLine($"Remaining stock of Soda: {soda} \n");
            }
                 


            Console.WriteLine("How many chips have been sold today? 40 in stock");
            int chipssold = int.Parse(Console.ReadLine());

            if ( chipssold > chips)
            {
                Console.WriteLine("Too High");
                Console.WriteLine("Please enter in correct amount");
                chipssold = int.Parse(Console.ReadLine());
            }
            else
            {
                chips -= chipssold;
                Console.WriteLine($"Remaining stock of chips: {chips} \n");
            }

            Console.WriteLine("How many candy have been sold today? 60 in stock");
            int candysold = int.Parse(Console.ReadLine());

            if (candysold > candy)
            {
                Console.WriteLine("Too High");
                Console.WriteLine("Please enter in correct amount");
                candysold = int.Parse(Console.ReadLine());
            }
            else
            {
                candy -= candysold;
                Console.WriteLine($"Remaining stock of candy: {candy} \n");
            }

            checkrestock("Soda", soda, restocksoda);
            checkrestock("Chips", chips, restockchips);
            checkrestock("Candy", candy, restockcandy);

            Console.ReadLine();

        }
        static void checkrestock(string itemname, int currentstock, int restockvalue)
        {
            if (currentstock <= restockvalue)
            {

                Console.WriteLine($"{itemname} needs to be restocked.");
            }

        }
    }
}
