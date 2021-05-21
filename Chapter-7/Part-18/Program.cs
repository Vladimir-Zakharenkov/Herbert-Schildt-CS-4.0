#region Russian

// Оператор foreach допускает циклическое обращение к массиву только в определенном
// порядке: от начала и до конца массива, поэтому его применение кажется, на
// первый взгляд, ограниченным. Но на самом деле это не так. В большом числе алгоритмов,
// самым распространенным из которых является алгоритм поиска, требуется
// именно такой механизм. В качестве примера ниже приведена программа, в которой
// цикл foreach используется для поиска в массиве определенного значения. Как только
// это значение будет найдено, цикл прервется.

//Поиск в массиве с помощью оператора цикла foreach.
using System;

class Search
{
    static void Main()
    {
        int[] nums = new int[10];
        int val;
        bool found = false;

        //Задать первоначальные значения элементов массива nums.
        for (int i = 0; i < 10; i++)
        {
            nums[i] = i;
        }

        val = 5;

        //Использовать цикл foreach для поиска заданного значения в массиве nums.
        foreach (int x in nums)
        {
            if (x == val)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Значение найдено!");
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// Значение найдено!

// Оператор цикла foreach отлично подходит для такого применения, поскольку
// при поиске в массиве приходится анализировать каждый его элемент. К другим примерам
// применения оператора цикла foreach относится вычисление среднего, поиск
// минимального или максимального значения среди ряда заданных значений, обнаружение
// дубликатов и т.д. Как будет показано далее в этой книге, оператор цикла foreach
// оказывается особенно полезным для работы с разными типами коллекций.

#endregion

#region English

// Since the foreach loop can only cycle through an array sequentially, from start to finish,
// you might think that its use is limited. However, this is not true. A large number of algorithms
// require exactly this mechanism, of which one of the most common is searching. For example,
// the following program uses a foreach loop to search an array for a value. It stops if the
// value is found.

// Search an array using foreach. 
// using System; 

// class Search
// {
//    static void Main()
//    {
//        int[] nums = new int[10];
//        int val;
//        bool found = false;

//        // Give nums some values. 
//        for (int i = 0; i < 10; i++)
//            nums[i] = i;

//        val = 5;

//        // Use foreach to search nums for key. 
//        foreach (int x in nums)
//        {
//            if (x == val)
//            {
//                found = true;
//                break;
//            }
//        }

//        if (found)
//            Console.WriteLine("Value found!");
//    }
// }

// The output is shown here:

// Value found!

// The foreach loop is an excellent choice in this application because searching an array involves
// examining each element. Other types of foreach applications include such things as computing
// an average, finding the minimum or maximum of a set, looking for duplicates, and so on.
// As you will see later in this book, foreach is especially useful when operating on other types
// of collections.

#endregion