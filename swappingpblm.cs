using System;
using System.Text;
namespace Swapping{
    class Problem{
        static void Main(string[] args){
            string word1 = "first string";
            string word2 = "second string";
            swapkey swapkey1 = new swapkey();
            swapkey1.swapmeth(ref word1,ref word2);
            Console.WriteLine("The Value of x after swapping: " + word1);
            Console.WriteLine("The Value of y after swapping: " + word2);
        }
    }
    class swapkey{
        public void swapmeth(ref string string1,ref string string2){
            string1 = "second string";
            string2 = "first string";
        }

    }
}