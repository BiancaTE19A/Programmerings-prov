using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa x-kordinaten, välj ett tal mellan 1-10.");
            string playerAnswer = "";
            int result = 0;
            int loop = 1;
            bool successful = false;
           
           
           
         


            while(!successful) {
                playerAnswer = Console.ReadLine();
                  successful = int.TryParse(playerAnswer, out result);

                  if (!successful) {
                      Console.WriteLine("Fel input. Skriv bara siffror.");
                  }

            }

            while (loop == 1) {
        
            if (result == 4) {
 
                Console.WriteLine("Grattis du gissade rätt!");
                Console.ReadLine();
                loop++;
            }
       
            else if (result != 4 && result < 7 || result != 4 && result > 2) {
                

                  Console.WriteLine("Det var nära!");
                  Console.ReadLine();
                 
            }
            else {
                Console.WriteLine("Nej det var fel.");
                Console.ReadLine();
                result = 0;
            }
            }

        

            
            
            
            Console.ReadLine();
        }
    }
}
