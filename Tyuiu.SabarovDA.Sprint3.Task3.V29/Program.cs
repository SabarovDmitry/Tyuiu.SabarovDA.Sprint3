using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SabarovDA.Sprint3.Task3.V29.Lib;
namespace Tyuiu.SabarovDA.Sprint3.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Сабаров Д. А. | ИИПб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема Оператор цикла do-whileФайл                                       *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #29                                                            *");
            Console.WriteLine("* Выполнил: Сабаров Дмитрий Александрович | ИИПб-23-1                    *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы h                   *");
            Console.WriteLine("* в строке: chgr vhhtg hnht                                              *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            char chr = 'h';
            string value = "chgr vhhtg hnht";
            

            Console.WriteLine(" Буква которую необходимо удалить: " + chr);
            Console.WriteLine(" Строка из которой нужно удалить:  " + value);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine( ds.DeleteCharInString(value, chr));
            Console.ReadKey();
        }
    }
}
