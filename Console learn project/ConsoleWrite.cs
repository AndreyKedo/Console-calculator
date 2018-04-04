using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_learn_project
{
    class ConsoleWrite
    {
        string[] NameFunctionArr = new string[6] { "Сложение", "Вычетание", "Умножение", "Деление", "Таблица Умножения", "Exit" }; //Названия функций
        public double GetNumOne { get; private set; } //Возвращение первого числа
        public double GetNumTwo { get; private set; } //Возвращение второго числа
        //Отправка номера операции в класс Program для обработки исключений
        public int GetFinctionNum { get; private set; }
        //Конструктор
        public ConsoleWrite()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Консольный калькулятор ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n Версия: 2.0\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Автор: Кедо Андрей\n");
            Console.ResetColor();
            Console.WriteLine("=========================================================================================");
            Console.Write("Для того что бы провести операцию с числами, вам нужно ввести ID операции и нажать Enter.\nID операций написаны в скобках на против операции.\n");
            Console.WriteLine("=========================================================================================");
        }
        public void StartRead() //Ввод данных и их проверка
        {
            ReadFunctionNum();
            int i = NameFunctionArr.Length - 1;
            if (GetFinctionNum > NameFunctionArr.Length)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n +++++++++++++++++++++++++++++++");
                Console.Write("\n      Нет такой операции!!! \n");
                Console.Write(" +++++++++++++++++++++++++++++++\n");
                Console.ResetColor();
                StartRead();
            }
            else if (GetFinctionNum == i)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n Закройте консоль или нажмите Enter");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nВы выбрали {0}\n", NameFunctionArr[GetFinctionNum]);
                Console.ResetColor();
                ReadNum();
            }
        }
        public void WriteResponse(double response) //Вывод ответа
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ____________ ");
            Console.Write("\n Ответ: {0}\n", response);
            Console.WriteLine(" ____________ ");
            Console.ResetColor();
        }
        public double ReadNum() //Проверка чисел
        {
            Calculate MatrixPifagor = new Calculate();
            try
            {
                if (GetFinctionNum != 4)
                {
                    Console.Write("\nВведите первое число: ");
                    GetNumOne = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    GetNumTwo = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    MatrixPifagor.MatrixPifagor();
                }
            }
            catch (FormatException)
            {
                WarningMessage();
                ReadNum();
            }
            return 0;
        }
        public int ReadFunctionNum() //Проверка 
        {
            try
            {
                Console.Write("\n Список операций: \n  Сложение (0) \n  Вычетание (1) \n  Умножение (2)\n  Деление (3)\n  Таблица умножение (4)\n  Выход из приложения (5)\n\n Введите номер операции: ");
                GetFinctionNum = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                WarningMessage();
                ReadFunctionNum();
            }
            return 0;
        }
        public void WarningMessage() //Предупреждающие сообщение
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n +++++++++++++++++++++++++++++");
            Console.Write("\n Вводить можно только цифры!!! \n");
            Console.Write(" +++++++++++++++++++++++++++++\n");
            Console.ResetColor();
        }
    }
}
