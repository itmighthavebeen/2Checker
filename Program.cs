// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
//Excercise 2 Check 
//
using System;
using System.Xml.Linq;
//=============================================================
//==
//==
//== 2nd Knowledge check for Code Lousiville
//== C Ramsey
//== SD1 Thursday
//============================================================

namespace ConsoleApp2Checker
{
    class Program
    {
        public class Tartan
    {
        public string Name { get; set; } = String.Empty;
        public string Yards { get; set; } = String.Empty;
        public string MainColor { get; set; } = String.Empty;
       
    }
    //
    //Define child class of Tartan
    //
    class RoyalStewart : Tartan
    {
        public string Desc { get; set; } = String.Empty;
    }
   

        static void Main(string[] args)
        {

            // object of derived class           
            
            Console.WriteLine("How many records do you want to add? ");
                //var int numberOfRecords = int.Parse(Console.ReadLine());
            var numberOfRecords = 0; 

            bool parseSuccess = int.TryParse(Console.ReadLine(), out numberOfRecords );
            //checking for valid input
            if (parseSuccess && numberOfRecords > 0)
            {
                Console.WriteLine("Now enter your " + numberOfRecords + " records:");
                Console.WriteLine("======================================");
            } 
            else
                Console.WriteLine("This is not an expected positive number!");
            
            var recordList = new List<RoyalStewart>();
         
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var royalStewart = new RoyalStewart();

                Console.WriteLine("Enter the value for name ");
                royalStewart.Name = Console.ReadLine()!;
                Console.WriteLine("Enter the value for yards ");
                royalStewart.Yards = Console.ReadLine()!;
                Console.WriteLine("Enter the value for main color ");
                royalStewart.MainColor = Console.ReadLine()!;
                Console.WriteLine("Enter the value for tartan description ");
                royalStewart.Desc = Console.ReadLine()!;
                Console.WriteLine();


                recordList.Add(royalStewart);

            }
            if (parseSuccess && numberOfRecords > 0)
            {
                //print vertically using for loop
                Console.WriteLine("Printing " + recordList.Count + " records vertically:");
                for (int i = 0; i < numberOfRecords; i++)
                {

                    // Print out the list of records using Console.WriteLine()
                    Console.WriteLine(recordList[i].Name);
                    Console.WriteLine(recordList[i].Yards);
                    Console.WriteLine(recordList[i].MainColor);
                    Console.WriteLine(recordList[i].Desc);
                    Console.WriteLine("====================================================");
                }
                //print horizontally using better yet for each loop
                Console.WriteLine("Printing " + recordList.Count + " records horizontally:");
                foreach (var obj in recordList)
                {
                    Console.WriteLine("Print of Record: " + " NAME: " + obj.Name + " YARDS: " + obj.Yards + " COLOR: " + obj.MainColor + " DESC: " + obj.Desc);
                }


            }
        }
    }
}