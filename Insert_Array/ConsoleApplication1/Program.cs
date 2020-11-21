using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        enum DoW { Monday,Tuesday,Wewdnesday,Thursday,Friday,Saturday,Sunday};
        static int[] array = { -999, -999, -999, -999, -999, -999, -999, -999, -999 };

        static void Main(string[] args)
        {
            //string[] st = { "Saha", "Pasha", "Masha", "Petya","Vasia", "Tom", "Beling cat", "Mo", "March"};
           
            int coun = 0;
            int input;
            while (true) {
                ConsColorText(ConsoleColor.Red, "Введите число");

                string temp = ReadText(ConsoleColor.Yellow);
                
                if (temp == "q") { break; }
                int.TryParse(temp,out input);
                if (coun > array.Length - 1)
                {
                    ConsColorText(ConsoleColor.Blue, "Массив полон запись невозможна");
                }
                else
                {
                    Swap(coun);
                    coun++;
                    array[0] = input;
                }          
                WriteArray(ConsoleColor.Green);
                Console.WriteLine();  


            } 
            Console.ReadKey();

        }
        #region Цвет консоли приглашения
        static void ConsColorText(ConsoleColor cc,string st)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = cc;
            Console.WriteLine(st);
            Console.ForegroundColor = temp;
           
        }
        #endregion
        #region Цвет вводимого приглашения
        static string ReadText(ConsoleColor cc)
        {
            string temp;
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            temp = Console.ReadLine();
            Console.ForegroundColor = color;
            return temp;
        }
        #endregion
        #region Выводим массив в консоль
        static void WriteArray(ConsoleColor cc)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = cc;
            foreach (int i in array)
            {
                Console.Write(" "+i+" ");
            }
            Console.ForegroundColor = temp;
        }
        #endregion
        #region Swap
        static void Swap(int coun)
        {
            for (int i = coun; i > 0; i--)
            {
                int temp = array[i];
                array[i] = array[i - 1];
                array[i - 1] = temp;
            }
        }
        #endregion


    }
}
