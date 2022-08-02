using System;
namespace timespan
{
    class Timespan{
      static void Main(String[] args){
        var date1 = new DateTime(2022,8,2,16,30,15); //date1
        var date2 = new DateTime(2022,6,18,10,0,30); //date2

            timespan.calcdiff.diff(date1,date2);
      }
    }
    

    class calcdiff{
        public static void diff(){
               
               var diff = date1-date2;
               Console.WriteLine("The Difference between two dates is :  " + diff);   
        } 
    }; 
}
