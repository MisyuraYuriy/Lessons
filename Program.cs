using System;
using System.Globalization;


namespace Lessons_console
{
    class Program
    {
        static void Main(string[] args)

        {
            #region Конвертація строк в числа та виправлення сепаратору

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

        }



    }

}
