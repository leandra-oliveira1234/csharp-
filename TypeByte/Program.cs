using System;

namespace TypeByte
{
    class Program
    {
        static void Main(string[] args)
        {
           try
           {
                byte x = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("os valores digitos são: {0}", x);
           }
            catch (OverflowException)
           {

                Console.WriteLine("o valor digitado esta fora do maximo, o valor maximo é 255");

            }
            catch (FormatException)
            {
                Console.WriteLine("vocé digitou um texto. Só é aceitavel  um numero de 0 a 255");
            }
          
         



        }
    }
}
