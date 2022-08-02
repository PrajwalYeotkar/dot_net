using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace math{
    class operations{
        static void Main(string[] args){
            int a,b;
            Console.WriteLine("Enter the two numbers for Arithmetic Operations : \n");
             a= Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter '1' for Addition : \n Enter '2' for Subtraction: \n Enter '3' for Multiplication: \n Enter '4' for Division: \n ");
             int p = int.Parse(Console.ReadLine());
             int result;

             if(p == 1){
                result = a+b;
                Console.WriteLine("The Addition of numbers :" + (result));
             }
             else if(p==2){
                result = a-b;
                Console.Writeline("The Subtraction of numbers: {result}");
             }
             else if(p==3){
                result = a*b;
                Console.WriteLine("The Multiplication of numbers:"+ (result));
             }
             else if(p==4){
                result = a/b;
                Console.WriteLine("The Division of numbers: "+ (result));
             }
             else{
                Console.WriteLine("Invalid Entry.Please enter the number between 1 to 4");
             }
             Console.ReadLine();

 
        }

    }
    class Addition{
        static void Main(string[] args){
            Console.WriteLine("Additon of {a} and {b}: "+ (a+b));
        }
    }
    class Subtraction{
        static void Main(string[] args){
             Console.WriteLine("Subtraction of numbers: " + (a-b));
        }
    }
    class Division{
        static void Main(string[] args){
             Console.WriteLine("Division of numbers: " + (a/b));
        }
    }
    class Multiplication{
        static void Main(string[] args){
             Console.WriteLine("multiplication of numbers: " + (a*b));
        }
    }
}