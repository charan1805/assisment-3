

using System;

namespace ConsoleApp_assesment_3
{
    
    
       
            

namespace ConsoleApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter marks obtained in Pre:");
                int preMarks = int.Parse(Console.ReadLine());

                if (preMarks > 60)
                {
                    Console.WriteLine("Enter marks obtained in Finals:");
                    int finalMarks = int.Parse(Console.ReadLine());

                    if (finalMarks > 55)
                    {
                        Console.WriteLine("Selected");
                    }
                    else
                    {
                        Console.WriteLine("Fail in Finals");
                    }
                }
                else
                {
                    Console.WriteLine("Fail in Pre");
                }

                Console.ReadLine();

            }
        }
    }
}
    

