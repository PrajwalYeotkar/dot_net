using System;
using System.Text;

namespace strconcatandstringbuild
{
    class compare{
        static void Main(String[] args){
            Console.WriteLine("The string concatenation is as follows: ");
            strconcatandstringbuild.concat.conc();
            strconcatandstringbuild.stringbuild.building();

        }
    }
        class concat
    {
        public static void conc(){
            string name1 = "Prajwal";
            string name3 = " Yeotkar";

            string cstring = name1+name3;
            Console.WriteLine("Strings after concatenation " + cstring);
        }
    }
    class stringbuild{
        public static void building(){
            StringBuilder name2 = new StringBuilder("This is string builder");
            name2.Append("\nI work in Sureprep.");
            Console.WriteLine(name2);

        }
    }
}