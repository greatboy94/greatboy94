// See https://aka.ms/new-console-template for more information

using System;

class Test1
{

    
    public static void Main(string[] args)
    {
        

        //Условные конструкции

        //Упражнение 1
        
        //Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
        //А программа сранивает два введенных числа и выводит на консоль результат сравнения (два числа равны, первое число больше второго или первое число меньше второго).
        /*int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        if (a==b)
        {
            Console.WriteLine("два числа равны");
        }else if (a>b)
        {
            Console.WriteLine("первое число больше второго");
        }
        else
        {
            Console.WriteLine("первое число меньше второго");
        }
        */

        //Упражнение 2

        //Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5
        //и меньше 10, то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число".
        /*int a = Convert.ToInt32(Console.ReadLine());
        if (a>5 && a<10)
        {
            Console.WriteLine("Число больше 5 и меньше 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }
        */

        //Упражнение 3
        //Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10,
        //то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".
        /*int a = Convert.ToInt32(Console.ReadLine());
        if (a==5 || a==10)
        {
            Console.WriteLine("число либо равно 5, либо равно 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }
        */

        //Упражнение 4
        //В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. Напишите консольную программу, в которую пользователь вводит сумму вклада.
        //Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.
        /*double a = Convert.ToDouble(Console.ReadLine());
        double bonus = 0;
        
        if (a<100)
        {
            a *= 0.05;
        }else if (a<=200)
        {
            a *= 0.07;
        }
        else
        {
            a *= 0.1;
        }
        Console.WriteLine(a);
        */

        //Упражнение 5
        //Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. И, допустим, сейчас банк решил
        //доначислить по всем вкладам 15 единиц вне зависимости от их суммы. Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.
        /*double a = Convert.ToDouble(Console.ReadLine());
        double bonus = 0;
        
        if (a<100)
        {
            a *= 0.05;
        }else if (a<=200)
        {
            a *= 0.07;
        }
        else
        {
            a *= 0.1;
        }

        a += a * bonus + 15;
        Console.WriteLine(a);
        */

        //Упражнение 6
        //Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". Рядом с названием каждой операции указан
        //ее номер, например, операция вычитания имеет номер 2. Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
        /*Console.WriteLine("Введите номер операции:");
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine("Сложение");
                break;
            case 2:
                Console.WriteLine("Вычитание");
                break;
            case 3:
                Console.WriteLine("Умножени");
                break;
            default:
                Console.WriteLine("операция неопределена");
                break;
        }
        */

        //Упражнение 7
        //Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции
        //с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются). Результа операции выводиться на консоль.
        /*Console.WriteLine("Введите номер операции: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int res = 0;

        switch (a)
        {
            case 1:
                Console.WriteLine("Сложение");
                res += b + c;
                break;
            case 2:
                Console.WriteLine("Вычитание");
                res += b - c;
                break;
            case 3:
                Console.WriteLine("Умножени");
                res += b * c;
                break;
            default:
                Console.WriteLine("операция неопределена");
                break;
        }

        Console.WriteLine(res);
        */


        //Loops

        //Упражнение 1
        //За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит
        //сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
        // decimal sum = Convert.ToDecimal(Console.ReadLine());
        // int month = Convert.ToInt32(Console.ReadLine());
        //
        // for (int i = 1; i <= month; i++)
        // {
        //     sum += sum * 0.07M;
        // }
        //
        // Console.WriteLine(sum+" "+month);

        //Упражнение 2
        //Перепишите предыдущую программу, только вместо цикла for используйте цикл while.
        // decimal sum = Convert.ToDecimal(Console.ReadLine());
        // int month = Convert.ToInt32(Console.ReadLine());
        //
        // int i = 1;
        // while (i <= month)
        // {
        //     sum += sum * 0.07M;
        //     i++;
        // }
        //
        // Console.WriteLine(sum+" "+month);

        //Упражнение 3
        //Напишите программу, которая выводит на консоль таблицу умножения
        // for (int i = 1; i <=10; i++)
        // {
        //     for (int j = 1; j <=10; j++)
        //     {
        //         Console.Write($"{i * j}\t");
        //     }
        //
        //     Console.WriteLine();
        // }

        //Упражнение 5
        

        // int res = 0;
        // while (true)
        // {
        //     Console.WriteLine("Enter first number: ");
        //     int a = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Enter second number: ");
        //     int b = Convert.ToInt32(Console.ReadLine());
        //
        //     if (a<0 || a>10 || b<0 || b>10)
        //     {
        //         Console.WriteLine("введенные числа недопустимы");                
        //     }
        //     else
        //     {
        //         res += a * b;
        //         break;
        //     }
        // }
        //
        // Console.WriteLine("Result: "+res);

        // int Factorial(int n)
        // {
        //     if (n == 1) return 1;
        //
        //     return n * Factorial(n - 1);
        // }

        // int factorial4 = Factorial(4);  // 24
        // int factorial5 = Factorial(5);  // 120
        // int factorial6 = Factorial(6);  // 720
        //
        // Console.WriteLine($"Факториал числа 4 = {factorial4}");
        // Console.WriteLine($"Факториал числа 5 = {factorial5}");
        // Console.WriteLine($"Факториал числа 6 = {factorial6}");

        // int Fibonachi(int n)
        // {
        //     if (n == 0 || n == 1) return n;
        //
        //     return Fibonachi(n - 1) + Fibonachi(n - 2);
        // }
        //
        // int fib4 = Fibonachi(4);
        // int fib5 = Fibonachi(5);
        // int fib6 = Fibonachi(6);
        //
        // Console.WriteLine($"4 число Фибоначчи = {fib4}");
        // Console.WriteLine($"5 число Фибоначчи = {fib5}");
        // Console.WriteLine($"6 число Фибоначчи = {fib6}");   

        

    }


}