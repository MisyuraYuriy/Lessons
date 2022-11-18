using System;
using System.Globalization;


namespace Lessons_console
{
    class Program
    {
        static void Main(string[] args)

        {
            #region Конвертація строк в числа та виправлення сепаратору
            /*
            String aa = "100,15"; //= Convert.ToInt32(a);
            String bb = "1n15"; //= Convert.ToInt32(a);

            NumberFormatInfo format1 = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "n" // можна використовувати будь який сепаратор.
            };

            // Метод Parse конвертує строки в числа. Але, на відміну від Convert, працює лише зі строками 

            double aaa = double.Parse(aa);
            double bbb = double.Parse(bb, format1);

            Console.WriteLine(aaa + bbb);
            */
            #endregion

            #region Використання Try catch

            //String str = "100";

            /*
            try
            {
                double aaa = double.Parse(str);
                Console.WriteLine("Усп"+"i"+"шна конвертац" + "i"+"я!");
            }
            catch (Exception) 
            {
                Console.WriteLine("Помилка при конвертац"+"i"+"ї!");
            }
            */
            #endregion

            #region Використання TryParse
            /*
                String str = "10k0";
                int a;

                // TryParse, на відміну від parse, не створює виключення, а передає змінній "а" нуль. Якщо до коду додати логічну змінну, тоді отримаємо true / false

                bool b = int.TryParse(str, out a);

                if (b) // можна ще написати (b == true), але не обов'язково, бо пеший блок структури IF виконується при TRUE. == (дорівнює TRUE); != (дорівнює FALSE)
                {
                   Console.WriteLine(a);
                   Console.ReadLine(); // ця строка додана для того, щоб консоль не закривалася одразу після виконання коду.
                }
                else
                { 
                   Console.WriteLine("Помилка!");
                   Console.ReadLine();
                }
            */
            #endregion

            #region Оператори

            //int fiska = 10;
            //int b = 3;
            //int c = 5;

            ////double re = (double) fiska / b; // (double) - приведение типов

            //int re = fiska + b + c;


            //Console.WriteLine(re);

            #endregion

            #region ИНКРЕМЕНТ, ДЕКРЕМЕНТ. ПОСТФИКСНЫЙ И ПРЕФИКСНЫЙ  

            // унарный оператор. в основном используем в счётчиках, циклах. По сути схож на a=a+1 или a=a-1, но упрощает синтаксис.
            // a++; //ИНКРЕМЕНТ ПОСТФИКСНЫЙ - увеличение на единицу 
            // a--; //ДЕКРЕМЕНТ ПОСТФИКСНЫЙ - уменьшение на единицу
            // ++a; //ИНКРЕМЕНТ ПРЕФИКСНЫЙ - увеличение на единицу 
            // --a; //ДЕКРЕМЕНТ ПРЕФИКСНЫЙ - уменьшение на единицу
            // разница между ПОСТФИКСНЫМ и ПРЕФИКСНЫМ только в том, что ПРЕФИКСНЫЙ в любых операцмях имеет наибольший приоритет
            // и выполняется в первую очередь. Например:
            /*
            double a = 0.21;

            Console.WriteLine(a++);
            Console.Read();
            */
            //получим 0,21. так из-за того, что вначале выводится запись в консоле, а уже потом к переменной
            //добавляется единица. Но если поменяет постфиксный на префиксный, тогда сработает как нужно - консоль 
            //выведет 1,21:

            /*
            double a = 0.21;

            Console.WriteLine(++a);
            Console.Read();
            */
            #endregion

            #region ОПЕРАЦИИ СРАВНЕНИЯ | ОПЕРАТОРЫ ОТНОШЕНИЯ

            /* выдают true/false
             
                     == равно
                     != не равно
                     >  больше
                     <  меньше
                     >= больше или равно
                     <= меньше или равно
             */

            //int a = 5; 
            //int b = 5;
                                          // Результаты:
            //Console.WriteLine(a == b);  // true
            //Console.WriteLine(a != b);  // false
            //Console.WriteLine(a > b);   // false 
            //Console.WriteLine(a < b);   // false

            int a = 8;
            int b = 6;
            Console.WriteLine(a <= b);   // false
            Console.WriteLine(a >= b);   // true
            Console.Read();




            #endregion

        }



    }

}
