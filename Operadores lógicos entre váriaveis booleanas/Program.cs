using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_lógicos_entre_váriaveis_booleanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;// Verdadeiro
            bool var2 = false;//Falso 

            //Operação de negação

            bool var3 = !var1;
            Console.WriteLine("O resultado da negação de " + var1 + " é " + var3);
            var3 = !var2;
            Console.WriteLine("O resultado da negação de " + var2 + " é " + var3);

            //Operador E (AND) - & 
            bool resultadoE = var1 & var1;
            Console.WriteLine("O resultado da operação E entre " + var1 + " e " + var1 + " resulta em: " + resultadoE);
            bool resultadoE2 = var1 & var2;
            Console.WriteLine("O resultado da operação E entre " + var1 + " e " + var2 + " resulta em: " + resultadoE2);
            bool resultadoE3 = var2 & var2;
            Console.WriteLine("O resultado da operação E entre " + var2 + " e " + var2 + " resulta em: " + resultadoE3);

            //Operador OU (OR) - | 
            bool resultadoOU = var1 | var1;
            Console.WriteLine("O resultado da operação OU entre " + var1 + " e " + var1 + " resulta em: " + resultadoOU);
            bool resultadoOU2 = var1 | var2;
            Console.WriteLine("O resultado da operação OU entre " + var1 + " e " + var2 + " resulta em: " + resultadoOU);
            bool resultadoOU3 = var2 | var2;
            Console.WriteLine("O resultado da operação OU entre " + var2 + " e " + var2 + " resulta em: " + resultadoOU);

            //  Operador OU EXCLUSIVO (XOR) - ^
            bool resultadoXOR = var1 ^ var1;
            Console.WriteLine("O resultado da operação XOR entre " + var1 + " e " + var1 + " resulta em: " + resultadoXOR);
            bool resultadoXOR2 = var1 ^ var2;
            Console.WriteLine("O resultado da operação XOR entre " + var1 + " e " + var2 + " resulta em: " + resultadoXOR);
            bool resultadoXOR3 = var2 ^ var2;
            Console.WriteLine("O resultado da operação XOR entre " + var2 + " e " + var2 + " resulta em: " + resultadoXOR);

            Console.ReadKey();
        }
    }
}
