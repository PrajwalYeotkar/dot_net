using System;
using System.Text;
namespace Practice1{
    class details
    {
        static void Main(string[] args){
            Empinfo E1 = new Empinfo();
            E1.empinfo();
        }
    }
    class Empinfo
    {
        public void empinfo(){
        string[] name = new string[4];
        string[] address = new string[4];
        
        for(int i=0;i<4;i++){
            Console.WriteLine("Enter the name and address of the employee: "+ (i+1));
            name[i] = Console.ReadLine();
            address[i] = Console.ReadLine();
        }

        for(int i=0;i<4;i++){
            Console.WriteLine("The name and address of the employee: "+ (i+1));
            Console.WriteLine(name[i]);
            Console.WriteLine(address[i]);
        }
        }
        }
}