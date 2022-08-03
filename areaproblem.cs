using System;
using System.Text;

namespace area
{
    class shape
    {
        static void Main(string[] args){
        int length = 100;
        int breadth = 200;
        Square S1 = new Square();
        S1.sqarea(length);
        Rectangle R1 = new Rectangle();
        R1.recarea(length,breadth);
        }
    }
    class Square
    {
        public void sqarea(int a){
            Console.WriteLine("\nThe area of Square is : \n"+ (a*a));
        }
    }
    class Rectangle
    {
        public void recarea(int a,int b)
        {
            Console.WriteLine("\nThe Area of Rectangle is: \n"+ (a*b));
        }
    }
        
}