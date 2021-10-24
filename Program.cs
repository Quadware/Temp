using System;

namespace DZ
{
    class Program
    {
/**Задание 1.
Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
Программа должна сосчитать количество введенных пользователем пробелов.*/
        static void task1()
        {
            char input = 'a';
            int spaceCount = 0;

            Console.WriteLine("Задание 1. \nНаписать программу, которая считывает символы с клавиатуры, пока не будет введена точка.\nПрограмма должна сосчитать количество введенных пользователем пробелов.");
            Console.WriteLine("\nExecuting program...\n");
            Console.WriteLine("Enter some character\n" + "Enter dot to terminate");

            while (input != '.')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input == ' ') { ++spaceCount; }
            }

            Console.WriteLine("Program terminated.");
            Console.Write("Spaces entered: ");
            Console.WriteLine(spaceCount);
            Console.WriteLine("\nExiting program...\n" + "Press any key to return to main menu");
            Console.ReadKey();
            Console.Clear();
        }

/*Задание 2.
Ввести с клавиатуры номер трамвайного билета(6-значноечисло) и проверить является ли данный билет счастливым
(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот
билет считается счастливым).*/
        static void task2()
        {
            Console.WriteLine("Задание 2.\nВвести с клавиатуры номер трамвайного билета (6 - значное число) и проверить является ли данный билет счастливым.\n(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет \nсчитается счастливым).");
            Console.WriteLine("\nExecuting program...\n");

            const int minNum = 99999;
            const int maxNum = 1000000;
            const int halfNum = 1000;
            int num;
            int digit;
            bool loop;

            do
            {
                loop = false;
                Console.Write("\nEnter a six digit number: ");
                string input = Console.ReadLine();
                try
                {
                    num = Int32.Parse(input);

                    if (num > minNum && num < maxNum)
                    {
                        int sum = 0;
                        while (num > 0)
                        {
                            digit = num % 10;
                            sum += (num > halfNum ? digit : -digit);
                            num /= 10;
                        }
                        Console.WriteLine(input + " is " + (sum == 0 ? "a lucky" : "NOT a lucky") + " ticket!");
                    }
                    else
                    {
                        throw new FormatException("Number must be a 6-digit number!");                  
                    }
                    Console.WriteLine("Continue? Y/N");
                    char proceed = Console.ReadKey().KeyChar;
                    if (proceed == 'Y' || proceed == 'y') { loop = true; }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    loop = true;
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    loop = true;
                }
            }
            while (loop == true);

            Console.WriteLine("\nExiting program...\n" + "Press any key to return to main menu");
            Console.ReadKey();
            Console.Clear();
        }

 /*Задание 3. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32.
 Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.*/
        static void task3()
        {
            int input = 0;

            Console.WriteLine("Задание 3. \nЧисловые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра \nна величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует \nвсе символы нижнего регистра в символы верхнего регистра и наоборот.");
            Console.WriteLine("\nExecuting program...\n");
            Console.WriteLine("Enter a character to convert");
            Console.WriteLine("Space key to exit");
                        
            while((input != 32))
            {
                input = Console.ReadKey().KeyChar;
                if (input >= 65 && input <= 90)
                {
                    input += 32; ;
                }
                else if (input >= 97 && input <= 122)
                {
                    input -= 32;
                }
                if (input != 32)
                {
                    Console.Write(" => " + (char)input) ;
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\nExiting program...\n" + "Press any key to return to main menu");
            Console.ReadKey();
            Console.Clear();
        }
/*Задание 4. Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно;
Каждое число должно выводиться на новой строке; \nПри этом каждое число должно выводиться количество раз, равное его значению.
Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7*/
        static void task4()
        {
            bool loop;

            Console.WriteLine("Задание 4.\nДаны целые положительные числа A и B (A < B).\nВывести все целые числа от A до B включительно; \nКаждое число должно выводиться на новой строке; \nПри этом каждое число должно выводиться количество раз, равное его значению.\nНапример: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:\n3 3 3\n4 4 4 4\n5 5 5 5 5\n6 6 6 6 6 6\n7 7 7 7 7 7 7");
            Console.WriteLine("\nExecuting program...");
            do
            {
                loop = false;
                try
                {
                    Console.Write("\nEnter num A: ");
                    UInt32 A = UInt32.Parse(Console.ReadLine());
                    Console.Write("Enter num B: ");
                    UInt32 B = UInt32.Parse(Console.ReadLine());

                    if (A>B)
                    {
                        throw new Exception("A must be < B");
                    }
                    Console.WriteLine();
                    for (UInt32 x = A; x <= B; ++x) //Скільки чисел виводити на екран
                    {
                        for (UInt32 y = 1; y <= x; ++y) //Скільки разів виводити чило на екран
                        {
                            Console.Write(x + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nContinue? Y/N");
                    char proceed = Console.ReadKey().KeyChar;
                    if (proceed == 'Y' || proceed == 'y') { loop = true; }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    loop = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    loop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    loop = true;
                }
            }
            while (loop == true);

            Console.WriteLine("\nExiting program...\n" + "Press any key to return to main menu");
            Console.ReadKey();
            Console.Clear();
        }

/*Задание 5. Дано целое число N(> 0). Найти число, полученное при прочтении числа N справа налево.
Например, если было введено число 345, то программа должна вывести число 543.*/
        static void Task5()
        {
            bool loop;
            int reverseNum = 0;

            Console.WriteLine("Задание 5.\nДано целое число N(> 0), найти число, полученное при прочтении числа N справа налево. \nНапример, если было введено число 345, то программа должна вывести число 543.");
            Console.WriteLine("\nExecuting program...");

            do
            {
                loop = false;
                Console.WriteLine("\nEnter a number");
                try
                {
                    Int32 num = Int32.Parse(Console.ReadLine());
                    while (num > 0)
                    {
                        reverseNum *= 10;
                        reverseNum += num % 10;
                        num /= 10;
                    }
                    Console.WriteLine("Reversed number:\n" + reverseNum);
                    Console.WriteLine("\nContinue? Y/N");
                    char proceed = Console.ReadKey().KeyChar;
                    if (proceed == 'Y' || proceed == 'y') { loop = true; }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    loop = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    loop = true;
                }
            }
            while (loop == true);
            
            Console.WriteLine("\nExiting program...\n" + "Press any key to return to main menu");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            UInt16 key=0;
            do
            {
                Console.WriteLine("\nSelect a task to display (1-5)\n");
                Console.WriteLine("1 - Программа, которая считывает символы с клавиатуры, пока не будет введена точка.\nПрограмма считает количество введенных пользователем пробелов." + "\n");
                Console.WriteLine("2 - Ввести с клавиатуры номер трамвайного билета (6 - значное число) и проверить является ли данный билет счастливым.\n(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет \nсчитается счастливым).\n");
                Console.WriteLine("3 - Программа, которая считывает с клавиатуры и конвертирует \nвсе символы нижнего регистра в символы верхнего регистра и наоборот.\n");
                Console.WriteLine("4 - Даны целые положительные числа A и B (A < B).\nВывести все целые числа от A до B включительно; \nКаждое число должно выводиться на новой строке; \nПри этом каждое число должно выводиться количество раз, равное его значению.\n");
                Console.WriteLine("5 - Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево.");
                Console.WriteLine("\nEnter 9 to exit");

                try
                {
                    key = UInt16.Parse(Console.ReadLine());
                    switch (key)
                    {
                        case 1:
                            Console.Clear();
                            task1();
                            break;
                        case 2:
                            Console.Clear();
                            task2();
                            break;
                        case 3:
                            Console.Clear();
                            task3();
                            break;
                        case 4:
                            Console.Clear();
                            task4();
                            break;
                        case 5:
                            Console.Clear();
                            Task5();
                            break;
                        case 9:
                            Console.WriteLine("Exiting main program...");
                            break;
                        default:
                            Console.Clear();
                            throw new IndexOutOfRangeException("Use 1-5 keys for task selection!");
                    }
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                catch(OverflowException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
            while (key != 9);     
        }
    }
}
