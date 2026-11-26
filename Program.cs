using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3
{
    class Program
    {
        static void Main()
        {
            // Q1

            //double[] array = {25.5, 40.0, 33.75};

            //Console.WriteLine(array[1]);

            //----------------------------------------------------------------------------------------------------//




           // Q2


            //int[,] shelfCopies =
            //{
            //    {3,5 },
            //    {1,4 }
            //};

            //Console.WriteLine(shelfCopies[1, 0]);


            //-------------------------------------------------------------------------//



            //Q3


            //static void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");

            //}

            //PrintWelcomeMessage();

            //-------------------------------------------------------------------------------------------//




            //  Q4


            //static void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("Book title: " + title);
            //}

            //PrintBookTitle("Clean Code");
            //---------------------------------------------------------------------------------------------------------//



            //  Q5

            //static void AddBonusPages(int pages)
            //{
            //    pages += 50;
            //}

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);

            //--------------------------------------------------------------------------------------//


            // Q6

            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;

            //}                                    

            //double[] prices = { 25.5, 40.0 };// The output will be 20.5 because arrays are reference types in C#.
            //                                 // The method modifies the first element of the original array,
            //ApplyDiscount(prices);           // so the change is visible outside the method.
            //Console.WriteLine(prices[0]);


            //----------------------------------------------------------------------------------------------------//



            // Q7
           
            
            //   static void AddBonusPagesByRef(ref int pages)
            //    {
            //        pages += 50;
            //    }

            //    int pages = 400;
            //    AddBonusPagesByRef(ref pages);  //Because the `ref` keyword allows the method to access and modify the original variable directly.
            //    Console.WriteLine(pages);      //    Therefore, the change affects the original value.


            //-------------------------------------------------------------------------------------------//





            //  Q8

            //static void ReplaceArray(ref double[] prices)
            //{
            //    prices = new double[] { 10.0, 12.5, 15.0 };

            //}

            //double[] prices = { 10.0, 12.5, 15.0, 100.3 };

            //ReplaceArray(ref prices);

            //Console.WriteLine(prices.Length);

            //-----------------------------------------------------------------------------------------------------//




            //  Q9


            //static bool TryGetPrice(string title, out double price)
            //{
            //    bool found = title == "Clean Code";

            //    price = found ? 25.5 : 0;

            //    return found;
            //}

            //    double price;

            //    bool found = TryGetPrice("Clean Code", out price);

            //    if (found)
            //    {
            //        Console.WriteLine(price);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Book not found");
            //    }

            //----------------------------------------------------------------------------------------------------//



            //  Q10

            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine($"Book: {title}, Pages: {pages}");

            //}

            //PrintBookInfo(".NET");
            //PrintBookInfo(".NET", 1000);

            //----------------------------------------------------------------------------------------------------------//





            //  Q11



            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine($"Book: {title}, Pages: {pages}");

            //}

            //PrintBookInfo(".NET");
            //PrintBookInfo( pages: 1000 ,title :".NET");

            //---------------------------------------------------------------------------------------------------//




            //  Q12

            //static void PrintAllTitles(params string[] titles)
            //{
            //    foreach (string title in titles)
            //    {
            //        Console.WriteLine(title);
            //    }
            //}

            //PrintAllTitles("Clean Code", "C# Basics", "Java Basics");





        }

    }
}