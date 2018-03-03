using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //some global var's//
           /////////////////////
            int j = 0;
            int ff = 100;
            int[] answer = new int[10];
            string iString;
            
            
            while (ff < 9999)
            {
              
                iString = Convert.ToString(ff);
              
                //separation of number for make units//
                int n1 = Convert.ToInt32(Convert.ToString(iString[0]));
                int n2 = Convert.ToInt32(Convert.ToString(iString[1]));
                int n3 = Convert.ToInt32(Convert.ToString(iString[2]));
                
                //factorial calculation//
                int fn1 = Factorial(n1);
                int fn2 = Factorial(n2);
                int fn3 = Factorial(n3);
                //check on right execution and if all ok add this number in array
                if (fn1+fn2+fn3 == ff) { if (answer[j] == 0) { answer[j++] = ff; } } 

                //function to calculate factorials
                int Factorial(int numb)
                {
                    int res = 1;
                    for (int i = numb; i > 1; i--)
                        res *= i;
                    return res;
                }
                ff++;
             }
            //displaying items of array
            for(int ii=0; ii < 5; ii++) { Console.WriteLine(answer[ii]);}
            
            //console pause
            Console.ReadKey();   
        }

    }
}
