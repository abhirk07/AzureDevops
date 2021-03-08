using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main15(string[] args)
        {
           int sum = 0;
           int avg = 0;
           
           int[] array = new int[50];

           System.Console.WriteLine("Enter the no of inputs");
           int n=int.Parse(Console.ReadLine());

           for ( int i = 0; i < n; i++)
           {
               array[i] = int.Parse(Console.ReadLine());
                                         
           }

           for (var i = 0; i < array[i]; i++)
           {

               System.Console.WriteLine("The value is {0}\t",array[i]);
           }

           for (var j = 0; j < array[j]; j++)
           {
               sum += array[j];
             
           }

           System.Console.WriteLine("The sum is {0}", sum);

           avg  = sum / n;

           System.Console.WriteLine("The average is {0}", avg);


        
                        
        }
    }
}