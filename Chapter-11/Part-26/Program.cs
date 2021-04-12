#region Russian

// Класс object как универсальный тип данных

// Если object является базовым классом для всех остальных типов и упаковка значений
// простых типов происходит автоматически, то класс object можно вполне использовать
// в качестве "универсального" типа данных. Для примера рассмотрим программу,
// в которой сначала создается массив типа object, элементам которого затем
// присваиваются значения различных типов данных.

//Использовать класс object для создания массива "обобщенного" типа.
using System;

class GenericDemo
{
    static void Main()
    {
        object[] ga = new object[10];

        //Сохранить целые значения.
        for (int i = 0; i < 3; i++)
        {
            ga[i] = i;
        }

        //Сохранить значения типа double.
        for (int i = 3; i < 6; i++)
        {
            ga[i] = (double)i / 2;
        }

        //Сохранить две строки, а также значения типа bool и char.
        ga[6] = "Привет";
        ga[7] = true;
        ga[8] = 'X';
        ga[9] = "Конец";

        for (int i = 0; i < ga.Length; i++)
        {
            Console.WriteLine("ga[" + i + "]: " + ga[i] + " ");
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Выполнение этой программы приводит к следующему результату.

//ga[0] : 0
//ga[1] : 1
//ga[2]: 2
//ga[3]: 1.5
//ga[4]: 2
//ga[5]: 2.5
//ga[6]: Привет
//ga[7]: True
//ga[8]: X
//ga[9]: Конец

// Как показывает данный пример, по ссылке на объект класса object можно обращаться
// к данным любого типа, поскольку в переменной ссылочного типа object допускается
// хранить ссылку на данные всех остальных типов. Следовательно, в массиве
// типа object из рассматриваемого здесь примера можно сохранить данные практически
// любого типа. В развитие этой идеи можно было бы, например, без особого труда
// создать класс стека со ссылками на объекты класса object. Это позволило бы хранить
// в стеке данные любого типа.

// Несмотря на то что универсальный характер класса object может быть довольно
// эффективно использован в некоторых ситуациях, было бы ошибкой думать, что с помощью
// этого класса стоит пытаться обойти строго соблюдаемый в C# контроль типов.
// Вообще говоря, целое значение следует хранить в переменной типа int, строку — в переменной
// ссылочного типа string и т.д.

// А самое главное, что начиная с версии 2.0 для программирования на C# стали доступными
// подлинно обобщенные типы данных — обобщения (более подробно они рассматриваются в главе 18).
// Внедрение обобщений позволило без труда определять классы и алгоритмы, автоматически обрабатывающие
// данные разных типов, соблюдая типовую безопасность. Благодаря обобщениям отпала необходимость пользоваться
// классом object как универсальным типом данных при создании нового кода. Универсальный
// характер этого класса лучше теперь оставить для применения в особых случаях.

#endregion

#region English

// Is object a Universal Data Type?

// Given that object is a base class for all other types and that boxing of the value types takes
// place automatically, it is possible to use object as a “universal” data type.For example,
// consider the following program that creates an array of object and then assigns various
// other types of data to its elements:

// Use object to create a "generic" array. 

// using System; 

// class GenericDemo
// {
//    static void Main()
//    {
//        object[] ga = new object[10];

//        // Store ints. 
//        for (int i = 0; i < 3; i++)
//            ga[i] = i;

//        // Store doubles. 
//        for (int i = 3; i < 6; i++)
//            ga[i] = (double)i / 2;


//        // Store two strings, a bool, and a char. 
//        ga[6] = "Hello";
//        ga[7] = true;
//        ga[8] = 'X';
//        ga[9] = "end";

//        for (int i = 0; i < ga.Length; i++)
//            Console.WriteLine("ga[" + i + "]: " + ga[i] + " ");
//    }
// }

// The output is shown here:

//ga[0]: 0
//ga[1]: 1
//ga[2]: 2
//ga[3]: 1.5
//ga[4]: 2
//ga[5]: 2.5
//ga[6]: Hello
//ga[7]: True
//ga[8]: X
//ga[9]: end

// As this program illustrates, because an object reference can hold a reference to any other
// type of data, it is possible to use an object reference to refer to any type of data. Thus, an array
// of object as used by the program can store any type of data. Expanding on this concept, it is
// easy to see how you could construct a stack class, for example, that stored object references.
// This would enable the stack to store any type of data.

// Although the universal - type feature of object is powerful and can be used quite effectively
// in some situations, it is a mistake to think that you should use object as a way around C#’s
// otherwise strong type checking.In general, when you need to store an int, use an int variable;
// when you need to store a string, use a string reference; and so on.

// More importantly, since version 2.0, true generic types are available to the C# programmer.
// (Generics are described in Chapter 18.) Generics enable you to easily define classes and
// algorithms that automatically work with different types of data in a type-safe manner.
// Because of generics, you will normally not need to use object as a universal type when
// creating new code.Today, it’s best to reserve object’s universal nature for specialized
// situations.

#endregion