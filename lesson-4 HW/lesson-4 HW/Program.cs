using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_HW
{

    class Program
    {
        static void Main(string[] args)
        {

            #region 1 задание
            MyArray arr = new MyArray(20);
            arr.InitArray(-10000, 10000);
            Console.WriteLine(arr.PrintArray());
            Console.WriteLine("Кол-во пар, в которых хотя бы одно число /3: " + arr.CountPairDivTree());
            MyClass.Pause();
            #endregion


            #region Задание 2
            MyArray mylist = new MyArray(10, -15, 5);
            Console.WriteLine(mylist.PrintArray());
            Console.WriteLine("Кол-во пар, в которых хотя бы одно число /3: " + mylist.CountPairDivTree());
            mylist.Inverse();
            Console.WriteLine("Инвертировали знаки: \n" + mylist.PrintArray());
            mylist.Multi(-5);
            Console.WriteLine("Умножили: \n" + mylist.PrintArray());
            MyClass.Pause();
            Console.WriteLine("Сумма всех значений массива " + mylist.Sum);
            Console.WriteLine("кол-во максимальных значений в массиве " + mylist.MaxCount);
            MyClass.Pause();
            MyArray listFromFile = new MyArray("input.txt");
            Console.WriteLine(listFromFile.PrintArray());
            listFromFile.Multi(-5);
            listFromFile.PrintToFile("output.txt");
            MyClass.Pause();
            #endregion

            #region Задание 3
            Account acc = new Account("root", "GeekBrains", "Dima");
            if (acc.PassControl("1.txt")) Console.WriteLine("Access granted!");
            else Console.WriteLine("Access denied");
            MyClass.Pause();
            #endregion
        }

    }
}
