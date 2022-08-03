using System;
using System.Text;
namespace Swapping{
    class problem{
        static void Main(string[] args){
            string x = "first string";
            string y = "second string";
            swapkey S1 = new swapkey();
            S1.swapmeth(ref x,ref y);
            Console.WriteLine("The Value of x after swapping: " + x);
            Console.WriteLine("The Value of y after swapping: " + y);
        }
    }
    class swapkey{
        public void swapmeth(ref string p,ref string q){
            p = "second string";
            q = "first string";
        }

    }
}