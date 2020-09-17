using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CRIANÇA EDUCADA");
            Console.WriteLine("---------------");

        
        string frase;
        int I=0; //declara e zera contandor
       
         // Monta uma array com 20 palavras em palavrao
         string[] Palavrao = new string[20] {"chato", "chata", "bobo", "boba", "feio", "feia", "boboca", "bocó", "tonto", "tonta","palerma","paspalho", "paspalha", "tantã", "panaca", "pentelho", "pentelha", "burro", "burra", "besta"};
    
         Console.Clear();

         // Monta Diabinho
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine(@"  |||   ^~^  w --->chato/chata, bobo/boba, feio/feia");
         Console.WriteLine(@"  \|/  |6 6| ||--->boboca, bocó, tonto/tonta, palerma");
         Console.WriteLine(@"   |  _(_U_)// --->paspalho/paspalha, pentelho/pentelha");
         Console.WriteLine(@"   e_//|   |/  --->panaca,  burro/burra,tantã,  besta");

        
        Console.ResetColor();
        Console.WriteLine("\nEscreva uma frase com algumas destas palavras acima:");
        frase = Console.ReadLine();// entrada da frase com palavrao
        Console.Clear();

         
         while(I <= 19) // verifica se I menor ou = 19  caso falso termina a rotina 
           {
              frase = frase.Replace(Palavrao[I], "@#$%@");//verifica ocorrencia da palavra na posição I e troca por @#$%
              I = I + 1; // incrementa +1 ao Contador I
           }

              Console.Clear();
               // Monta Anjinho    
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine(@"     ===");
              Console.WriteLine(@"     ###");
              Console.WriteLine(@"  \ |u u| /        Criança Educada!");
              Console.WriteLine(@"  \\(_º_)//");
              Console.WriteLine(@"    // \\");
              Console.WriteLine(@"    \\M//");
              Console.ResetColor();

              Console.WriteLine(frase); // imprime frase censurada

              Console.ReadLine(); // evita saida bruta

           
        }
    }
    
}
