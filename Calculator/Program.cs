


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace Calculator
{


    class Calculator
    {
        public static double DoOperation(double num1 , double num2, string op       ) {

            double result = double.NaN;

            switch (op)
            {


                case "a": result = num1 + num2;
                    break;
                case "s": result = num1 - num2;
                    break;
                case "m": result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num2 / num1;   
                    }

                    break;
                    default:
                    break;

            }

            return result;
        
        }





    }
class Program
    {

        static void  Main ( string [] args)
        {

            bool endApp = false;

            while (!endApp){
                Console.WriteLine("Console Calculator in C# \r");
                Console.WriteLine("------------------------------");

                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine("Type a number , then press Enter "); 
                
                numInput1 = Console.ReadLine();
                double cleanNum1 = 0;

                while(! double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("This is not a valid input , plesae enter an integer");
                    numInput1= Console.ReadLine();
                }

                Console.WriteLine("Type another number , and then press Enter :");
                numInput2 = Console.ReadLine();
                double cleanNum2 = 0;
                while(! double.TryParse(numInput2,out cleanNum2))
                {

                    Console.WriteLine("This is not a valid input , plesae enter an integer");
                    numInput2= Console.ReadLine();

                }
                Console.WriteLine("Choose an option from the following list\n");
                Console.WriteLine("\ta -  Addition");
                Console.WriteLine("\yts   -   Subtraction");
                Console.WriteLine("\tm -   Multiplication");
                Console.WriteLine("\td - Division");

                string op = Console.ReadLine();

                try {
                
                result =Calculator.DoOperation(cleanNum1,cleanNum2,op);
                   
                    if( double.IsNaN(result)){

                        Console.WriteLine("This will result into a mathematical Error \n");
                    }
                    else {
                        Console.WriteLine("Your reslt is {0: 0.##}", result);
                            
                            
                            }
                
                }



                catch(Exception e) { Console.WriteLine("ooh an error has occured while trying to the math" + e.Message); }
                Console.WriteLine(".................................................\n");

                Console.WriteLine("Press 'n' to End the App or any other keey to continue : \n");

               if( Console.ReadLine() == "n")   endApp=true;

            }

            return;


        }

    }

}