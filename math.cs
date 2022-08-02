using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace math{
    class operations{
        static void Main(String[] args){
            Console.WriteLine("Enter the two numbers for operations:\n");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for Addition\nEnter 2 for Subtraction\nEnter 3 for Multiplication\nEnter 4 for Division\n");
            int c = int.Parse(Console.ReadLine());
            if(c == 1){
                math.Addition.add(a,b);
            }
            else if(c == 2){
                math.Subtraction.sub(a,b);
            }
            else if(c==3){
                math.Multiplication.mul(a,b);
            }
            else if(c == 4){
                math.Division.div(a,b);
            }
            else{
                Console.WriteLine("Invalid number. please enter a number between 1 and 4");
            }

        }
    }
    class Addition{
        public static void add(int a,int b){
            Console.WriteLine("The Addition of two numbers :"+ (a+b));
        }
    }
    class Subtraction{
        public static void sub(int a,int b){
            Console.WriteLine("The Subtraction of two numbers :" + (a-b));
        }
    }
    class Multiplication{
        public static void mul(int a,int b){
            Console.WriteLine("The Multiplication of two numbers :" +(a*b));
        }
    }
    class Division{
        public static void div(int a,int b){
            Console.WriteLine("The Division of two numbers :" + (a/b));
        }
    } 
}