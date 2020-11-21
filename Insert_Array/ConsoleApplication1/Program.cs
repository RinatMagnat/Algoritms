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
        static int coun = 0;
        static void Main(string[] args)
        {
            //string[] st = { "Saha", "Pasha", "Masha", "Petya","Vasia", "Tom", "Beling cat", "Mo", "March"};
           
            
            int input;
            while (true) {

                ConsColorText(ConsoleColor.Red, "Введите число или команду");

                string temp = ReadText(ConsoleColor.Yellow);
                
                if (temp == "help")
                {
                    ConsColorText(ConsoleColor.DarkYellow,"Команда 'del' удаление с конца массива");
                    ConsColorText(ConsoleColor.DarkYellow, "Команда 'delf' удаление с начала массива");
                    ConsColorText(ConsoleColor.DarkYellow, "Команда 'q' выход из программы");
                    continue;
                }
                if (temp == "q") { break; }
                if (temp == "delf")
                {
                    if (coun == 0)
                    {
                        ConsColorText(ConsoleColor.Blue, "Массив пуст");
                        continue;
                    }
                    else
                    {
                        DelFirstElement();
                        WriteArray(ConsoleColor.Green);
                        Console.WriteLine();
                        continue;
                    }
                    
                   
                }
                if (temp == "del")
                {
                    if (coun == 0)
                    {
                        ConsColorText(ConsoleColor.Blue, "Массив пуст");
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        array[coun - 1] = -999;
                        coun--;
                        WriteArray(ConsoleColor.Green);
                        Console.WriteLine();
                        continue;
                    }
                }
                if (int.TryParse(temp, out input))
                {
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
                else
                {
                    ConsColorText(ConsoleColor.DarkRed, "Необходимо ввести число");
                }


            } 
            Console.ReadKey();

        }
        #region Цвет консоли приглашения ConsColorText(ConsoleColor cc, string st)
        static void ConsColorText(ConsoleColor cc,string st)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = cc;
            Console.WriteLine(st);
            Console.ForegroundColor = temp;
           
        }
        #endregion
        #region Цвет вводимого приглашения string ReadText(ConsoleColor cc)
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
        #region Выводим массив в консоль WriteArray(ConsoleColor cc)
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
        #region Удаляем элемент в начале массива DeleteFirstElement()
        static void DelFirstElement()
        {
            for (int i = 0; i < coun-1; i++)
            {
                array[i] = array[i+1];
                array[i + 1] = -999;
            }
            coun--;
        }
        #endregion


    }
}
