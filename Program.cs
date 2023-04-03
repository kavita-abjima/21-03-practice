using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        
         public int x, y;
         public void sum(int x,int y)
         {
             Console.WriteLine(x+y);
         }

        static void Main(string[] args)
        {

            string dum_x = Console.ReadLine();
            int dum_X = Convert.ToInt32(dum_x);
            string dum_y = Console.ReadLine();
            int dum_Y = Convert.ToInt32(dum_y);

            Program ob = new Program();

            ob.sum(dum_X, dum_Y);
            // Print the sum of x + yl

            int a = 10;
            int b = 20;
            int c;
            c = a + b;

            Console.WriteLine("toatal of two numbers is:{0}", c);


            //if else statements

            NewMethod(a);

            //Switch statements
            string topic;
            string category;

            topic = "inheritance";
            category = "Loops";


            switch (topic)
            {
                case "Loops":
                case "if else":
                case "switch":

                    category = "Loops";
                    break;

                case "inheritance":
                case "objects":
                case "class":

                    category = "Opps concepts";
                    break;

                case "Basics":
                case "variables":
                case "operators":

                    category = "Basics of C#";
                    break;

                default:
                    category = "Not mentioned";
                    break;
            }
            System.Console.WriteLine("Category is : " + category);


            for(int i = 0; i < 10; i++)
            {

            }



        }

        private static void NewMethod(int a)
        {
            int x = 10;

            if (x < 20)
            {
                Console.WriteLine("20 is grater than x");
            }


            else if (a > 20)
            {
                Console.WriteLine("20 is less than x");
            }

            else
            {

                Console.WriteLine("value of x is qual to 20");
            }
        }
           

            
        }
}