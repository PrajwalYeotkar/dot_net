using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace math1{
    class operations{
        static void Main(string[] args){
            /*int a,b;
            Console.WriteLine("Enter the two numbers for Arithmetic Operations : \n");
             a= Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAddition:\n"+ (a+b));
            Console.WriteLine("\nSubtraction:\n"+ (a-b));
            Console.WriteLine("\nMultiplication:\n"+ (a*b));
            Console.WriteLine("\nDivision\n"+ (a/b));*/


            math1.Addition.Add();
            math1.Subtraction.sub();
            math1.Multiplication.mul();
            math1.Division.div();

        }
    }
    class Addition{
        public static void Add(){
            int p=10;
            int q=20;
            Console.WriteLine("Addition :"+ (p+q));
        }
    } 
    class Subtraction{
        public static void sub(){
            int p=10;
            int q=20;
            Console.WriteLine("Subtraction :"+ (p-q));
        }
    }
    class Multiplication{
        public static void mul(){
            int p=10;
            int q=20;
            Console.WriteLine("Multiplication:"+ (p*q));
        }
    }
    class Division{
        public static void div(){
            int p=10;
            int q=20;
            Console.WriteLine("Division :"+ (p/q));
        }
    }



}