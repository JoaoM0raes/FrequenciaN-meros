using System;

namespace FrequenciaNúmeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 7, 8, 10, 12, 10,1,10 };

            Array.Sort(numeros);
            string aparecer = "Apareceu";
            string vezes = "";
            for (int i = 0; i < numeros.Length; i++)
            {
                int cont = 0;
                
               for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i]==numeros[j])
                    {
                        cont++;
                        i = j;
                    }
                }
               if(cont == 1)
                {
                    vezes = "vez";
                }
                else
                {
                    vezes = "vezes";
                }
                
                Console.WriteLine($"{numeros[i]} {aparecer} {cont} {vezes}"  );
            }

        }
    }
}
