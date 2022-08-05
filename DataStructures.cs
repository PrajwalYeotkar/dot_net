using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    class calling
    {
        static void Main(string[] args){
            
            DataStructure.arrays.arrayin(10);
            DataStructure.arraylist.arrayin2();
            DataStructure.linkedlist.link();

        }
    }

    class arrays{
        public static void arrayin(int m){
            int[] arr = new int[m];
            Console.WriteLine("The array is of size " + m+ "\n");
            Console.WriteLine("Enter the numbers: \n");
            for(int i=0;i<10;i++){
                arr[i] = i;
            }
            
            Console.WriteLine("The array is: ");
            for(int i=0;i<10;i++)
            {
                for(int j=i+1;j<10;j++)
                {
                    if(arr[i]>arr[j]){
                        int temp = arr[i];
                        arr[i] =arr[j];
                        arr[j] =temp;
                    }
                }
            }
            Console.WriteLine("The largest no.is: " + arr[9]);  
        }
    }
        class arraylist
        {
            public static void arrayin2()
            {
                ArrayList arr2 = new ArrayList();
                arr2.Add(0);
                arr2.Add(1);
                arr2.Add(2);
                arr2.Add(3);
                arr2.Add(4);
                arr2.Add(5);
                arr2.Add(6);
                arr2.Add(7);
                arr2.Add(8);
                arr2.Add(9);
                int max = int.MinValue;
                 foreach(int i in arr2){
                 if(max < i){max = i;}
                 }
                 Console.WriteLine("The largest number in array list is: " + max);
                
                
            }

        }

        class linkedlist
        {
            public static void link(){
                LinkedList<int> arr3 = new LinkedList<int>();
                arr3.AddLast(0);
                arr3.AddLast(1);
                arr3.AddLast(2);
                arr3.AddLast(3);
                arr3.AddLast(4);
                arr3.AddLast(5);
                arr3.AddLast(6);
                arr3.AddLast(7);
                arr3.AddLast(8);
                arr3.AddLast(9);
                int max = int.MinValue;
                 foreach(int i in arr3){
                 if(max < i){max = i;}
                 }
                 Console.WriteLine("The largest number in array list is: " + max);


        }
}
}
