namespace homework_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* davaleba1
  int power(int num1, int num2)
  {
      int result = num1;
      for (int i = 0; i < num2; i++)
      {
          result *= num1;
      }

      return result;
  }*/
  
            /* davaleba2

             bool isPrime(int num)

             {
                 for (int i = 2; i < num; i++)
                 {
                     if (num % i == 0)
                     {
                         return false;
                     }


                 }
                 return true;

             }

             Console.WriteLine("enter number");
                 bool isValid = int.TryParse(Console.ReadLine(), out int userNum);
                 Console.WriteLine(isPrime(userNum) ? "yes" : "no");*/
            //davaleba3
            /*bool isPalindrome(string pal)
            {
                if (pal.Length < 2)
                {
                    return true;
                }

                if (pal[0]  != pal[pal.Length -1])
                {
                    return false;
                }
                string middle = pal.Substring(1,pal.Length-2);
                return isPalindrome(middle);

            }
            Console.WriteLine(IsPalindrome("no1on"));
            */
 
// davaleba5
/*
 int pow(int num, int powerer)
 {
     if (powerer == 1)
     {
         return num;

     }

     return num * pow(num, powerer - 1);
 }?*/

            
            
        }
    }
}