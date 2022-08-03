using System;
using System.Text;
namespace Emp
{
    class details
    {
        static void Main(string[] args){
            
            empinfo P1 = new empinfo();
            P1.emp();
            
        }
    }
    class empinfo
    {
        public void emp()
        {
            Console.WriteLine("1st Employee info:");
            string name1 = "Employee 1";
            Console.WriteLine(name1);
            string Address1 = "Mumbai";
            Console.WriteLine(Address1);
            Console.WriteLine("2nd Employee info:");
            string name2 = "Employee 2";
            Console.WriteLine(name2);
            string Address2 = "Pune";
            Console.WriteLine(Address2);
            Console.WriteLine("3rd Employee info:");
            string name3 = "Employee 3";
            Console.WriteLine(name3);
            string Address3 = "Hyderabad";
            Console.WriteLine(Address3);
            Console.WriteLine("4th Employee info:");
            string name4 = "Employee 4";
            Console.WriteLine(name4);
            string Address4 = "Chennai";
            Console.WriteLine(Address4);
        }
    }
}