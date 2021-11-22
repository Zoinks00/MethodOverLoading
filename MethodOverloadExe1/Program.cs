using System;

namespace MethodOverloadExe1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1 will return the sum of 2 numbers in int
            // Method 2 will return the sum of 2 numbers in decimal
            // Method 3 will return string value and use 3 paras "2 int" and "1 boolean"                      
            
            //Add two int values
            Console.WriteLine(Add(2,4)) ;
            
            //add two dec values
            Console.WriteLine(Add(3.25M,1.75M));

            //Add two int vaules and disply dollor or dollars best on result
            Console.WriteLine( Add(1, 1, false));
                  

        }

        public static int Add(int a, int b)

        {
            
            return a + b;

        }

        public static decimal Add(decimal a, decimal b)
        {
           
            return a + b;
        }

        //overload method with 3 peramaters
         public static string Add(int a, int b, bool isTrue)
                {

            int sum = a + b;
           
           //check if sum is equal to 1
            isTrue = sum < 2;
                                              

            if (isTrue) 
               
            {
                return $"You have {sum} dollar.";
            }// sum value is 2 or greater
            else return $"You have {sum} dollars";
            }

                   
    }
}
