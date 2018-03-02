using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int ff = 100;
            int[] answer = new int[10];

            while (ff < 9999)
            {
                string iString;
                iString = Convert.ToString(ff);

                int n1 = Convert.ToInt32(Convert.ToString(iString[0]));
                int n2 = Convert.ToInt32(Convert.ToString(iString[1]));
                int n3 = Convert.ToInt32(Convert.ToString(iString[2]));

                int fn1 = Factorial(n1);
                int fn2 = Factorial(n2);
                int fn3 = Factorial(n3);

                if (fn1+fn2+fn3 == ff) { if (answer[j] == 0) { answer[j++] = ff; } } 

                int Factorial(int numb)
                {
                    int res = 1;
                    for (int i = numb; i > 1; i--)
                        res *= i;
                    return res;
                }
                ff++;
             }
            for(int ii=0; ii < 5; ii++) { Console.WriteLine(answer[ii]);}
            
            Console.ReadKey();   
        }

    }
}
