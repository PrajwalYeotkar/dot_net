using System;
using System.Text;

namespace stringbuilderpractice
{
    class practiceofstringbuilder{
        static void Main(){
            StringBuilder  addWord = new StringBuilder(" Sureprep ");
            addWord.Append(", is an US company ");
            addWord.Append(",which works in taxation.");
            Console.WriteLine(addWord);
        }

    }
}
