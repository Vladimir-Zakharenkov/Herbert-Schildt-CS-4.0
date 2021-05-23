#region Russian

// Строки

// С точки зрения регулярного программирования строковый тип данных string относится
// к числу самых важных в С#. Этот тип определяет и поддерживает символьные
// строки. В целом ряде других языков программирования строка представляет собой
// массив символов. А в C# строки являются объектами. Следовательно, тип string относится
// к числу ссылочных. И хотя string является встроенным в C# типом данных,
// его рассмотрение пришлось отложить до тех пор, пока не были представлены классы
// и объекты.

// На самом деле класс типа string уже не раз применялся в примерах программ,
// начиная с главы 2, но это обстоятельство выясняется только теперь, когда очередь дошла
// до строк. При создании строкового литерала в действительности формируется
// строковый объект. Например, в следующей строке кода:

// Console.WriteLine("В C# строки являются объектами.");

// текстовая строка "В C# строки являются объектами." автоматически преобразуется
// в строковый объект средствами С#. Следовательно, применение класса типа
// string происходило в предыдущих примерах программ неявным образом. А в этом
// разделе будет показано, как обращаться со строками явным образом.

// Построение строк

// Самый простой способ построить символьную строку — воспользоваться строковым
// литералом. Например, в следующей строке кода переменной ссылки на строку
// str присваивается ссылка на строковый литерал.

// string str = "Строки в C# весьма эффективны.";

// В данном случае переменная str инициализируется последовательностью символов
// "Строки в C# весьма эффективны.".

// Объект типа string можно также создать из массива типа char. Например:

// char[] charray = { 't', 'е', 's', 't' };
// string str = new string(charray);

// Как только объект типа string будет создан, его можно использовать везде, где
// только требуется строка текста, заключенного в кавычки. Как показано в приведенном
// ниже примере программы, объект типа string может служить в качестве аргумента
// при вызове метода WriteLine().

//Создать и вывести символьную строку.
using System;

class StringDemo
{
    static void Main()
    {
        char[] charray = { 'Э', 'т', 'о', ' ', 'с', 'т', 'р', 'о', 'к', 'а' };

        string str1 = new string(charray);
        string str2 = "Еще одна строка";

        Console.WriteLine(str1);
        Console.WriteLine(str2);

        //Задержка программы.
        Console.ReadKey();
    }
}

// Результат выполнения этой программы приведен ниже.

// Это строка.
// Еще одна строка.

#endregion

#region English

// Strings

// From a day-to-day programming standpoint, string is one of C#’s most important data types
// because it defines and supports character strings. In many other programming languages, a
// string is an array of characters. This is not the case with C#. In C#, strings are objects. Thus,
// string is a reference type. Although string is a built-in data type in C#, a discussion of string
// needed to wait until classes and objects had been introduced.

// Actually, you have been using the string class since Chapter 2, but you did not know it.
// When you create a string literal, you are actually creating a string object. For example, in the
// statement

// Console.WriteLine("In C#, strings are objects.");

// the string “In C#, strings are objects.” is automatically made into a string object by C#. Thus,
// the use of the string class has been “below the surface” in the preceding programs. In this
// section, you will learn to handle them explicitly.

// Constructing Strings

// The easiest way to construct a string is to use a string literal. For example, here str is a
// string reference variable that is assigned a reference to a string literal:

// string str = "C# strings are powerful.";

// In this case, str is initialized to the character sequence “C# strings are powerful.”

// You can also create a string from a char array. For example:

// char[] charray = {'t', 'e', 's', 't'};
// string str = new string(charray);

// Once you have created a string object, you can use it nearly anywhere that a quoted
// string is allowed. For example, you can use a string object as an argument to WriteLine( ),
// as shown in this example:

// Introduce string.

// using System; 

// class StringDemo
// {
//    static void Main()
//    {

//        char[] charray = { 'A', ' ', 's', 't', 'r', 'i', 'n', 'g', '.' };
//        string str1 = new string(charray);
//        string str2 = "Another string.";

//        Console.WriteLine(str1);
//        Console.WriteLine(str2);
//    }
// }

// The output from the program is shown here:

// A string.
// Another string.

#endregion