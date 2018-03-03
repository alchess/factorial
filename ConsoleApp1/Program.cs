
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //some global var's//
            /////////////////////
            int j = 0;

            int[] answer = new int[5];
            string iString;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;

            int ff = 0;
            int maxNum = 9999;

            int Factorial(int numb)
                {
                    int res = 1;
                    for (int i = numb; i > 1; i--)
                        res *= i;
                    return res;
                }

            while (ff <= maxNum)
            {
                iString = Convert.ToString(ff);

                n1 = Factorial(Convert.ToInt32(Convert.ToString(iString[0])));
                if (ff >= 10)
                {
                    n2 = Factorial(Convert.ToInt32(Convert.ToString(iString[1])));
                    if (ff >= 100)
                    {
                        n3 = Factorial(Convert.ToInt32(Convert.ToString(iString[2])));
                        if (ff >= 1000)
                        {
                            n4 = Factorial(Convert.ToInt32(Convert.ToString(iString[3])));
                        }
                    }
                }


                //check on right execution and if all ok add this number in array               
                if (ff == 0) { answer[0] = 1; j++; }
                if (n1 + n2 + n3  == ff) {answer[j++] = ff;}


                //function to calculate factorials

                ff++;
            }

            foreach (int qi in answer)
            {
                System.Console.WriteLine("{0}", qi);
            }

            //console pause
            Console.ReadKey();
        }
    }
}
