#region Russian

// Неявно типизированные массивы

// Как пояснялось в главе 3, в версии C# 3.0 появилась возможность объявлять неявно
// типизированные переменные с помощью ключевого слова var. Это переменные, тип
// которых определяется компилятором, исходя из типа инициализирующего выражения.
// Следовательно, все неявно типизированные переменные должны быть непременно
// инициализированы. Используя тот же самый механизм, можно создать и неявно
// типизированный массив. Как правило, неявно типизированные массивы предназначены
// для применения в определенного рода вызовах, включающих в себя элементы
// языка LINQ, о котором речь пойдет в главе 19. А в большинстве остальных случаев
// используется "обычное" объявление массивов. Неявно типизированные массивы рассматриваются
// здесь лишь ради полноты представления о возможностях языка С#.

// Неявно типизированный массив объявляется с помощью ключевого слова var, но
// без последующих квадратных скобок []. Кроме того, неявно типизированный массив
// должен быть непременно инициализирован, поскольку по типу инициализаторов
// определяется тип элементов данного массива. Все инициализаторы должны быть
// одного и того же согласованного типа. Ниже приведен пример объявления неявно типизированного
// массива.

// var vals = new[] { 1, 2, 3, 4, 5 };

// В данном примере создается массив типа int, состоящий из пяти элементов. Ссылка
// на этот массив присваивается переменной vals. Следовательно, тип этой переменной
// соответствует типу int массива, состоящего из пяти элементов. Обратите внимание
// на то, что в левой части приведенного выше выражения отсутствуют квадратные
// скобки []. А в правой части этого выражения, где происходит инициализация массива,
// квадратные скобки присутствуют. В данном контексте они обязательны.

// Рассмотрим еще один пример, в котором создается двумерный массив типа double.

// var vals = new[,] { { 1.1, 2.2 }, { 3.3, 4.4 }, { 5.5, 6.6 } };

// В данном случае получается массив vals размерами 2×3.

// Объявлять можно также неявно типизированные ступенчатые массивы. В качестве
// примера рассмотрим следующую программу.

//Продемонстрировать неявно типизированный ступенчатый массив.
using System;

class Jagged
{
    static void Main()
    {
        var jagged = new[]
        {
            new[] { 1, 2, 3, 4},
            new[] { 9, 8, 7},
            new[] { 11, 12, 13, 14, 15}
        };

        for (int j = 0; j < jagged.Length; j++)
        {
            for (int i = 0; i < jagged[j].Length; i++)
            {
                Console.Write(jagged[j][i] + " ");
            }

            Console.WriteLine();
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Выполнение этой программы дает следующий результат.

// 1 2 3 4
// 9 8 7
// 11 12 13 14 15

// Обратите особое внимание на объявление массива jagged.

// var jagged = new[] {
// new[] { 1, 2, 3, 4 },
// new[] { 9, 8, 7 },
// new[] { 11, 12, 13, 14, 15 }
// };

// Как видите, оператор new[] используется в этом объявлении двояким образом.
// Во-первых, этот оператор создает массив массивов. И во-вторых, он создает каждый
// массив в отдельности, исходя из количества инициализаторов и их типа. Как и следовало
// ожидать, все инициализаторы отдельных массивов должны быть одного и того
// же типа. Таким образом, к объявлению любого неявно типизированного ступенчатого
// массива применяется тот же самый общий подход, что и к объявлению обычных ступенчатых
// массивов.

// Как упоминалось выше, неявно типизированные массивы чаще всего применяются
// в LINQ-ориентированных запросах. А в остальных случаях следует использовать явно
// типизированные массивы.

#endregion

#region English

// Implicitly Typed Arrays

// As explained in Chapter 3, C# 3.0 added the ability to declare implicitly typed variables
// by using the var keyword.These are variables whose type is determined by the compiler,
// based on the type of the initializing expression. Thus, all implicitly typed variables must be
// initialized. Using the same mechanism, it is also possible to create an implicitly typed array.
// As a general rule, implicitly typed arrays are for use in certain types of queries involving
// LINQ, which is described in Chapter 19. In most other cases, you will use the “normal”
// array declaration approach. Implicitly typed arrays are introduced here for completeness.

// An implicitly typed array is declared using the keyword var, but you do not follow var
// with []. Furthermore, the array must be initialized because it is the type of the initializers
// that determine the element type of the array. All of the initializers must be of the same or
// compatible type. Here is an example of an implicitly typed array:

// var vals = new[] { 1, 2, 3, 4, 5 };

// This creates an array of int that is five elements long. A reference to that array is assigned to
// vals. Thus, the type of vals is “array of int” and it has five elements. Again, notice that var is
// not followed by [ ]. Also, even though the array is being initialized, you must include new[].
// It’s not optional in this context.

// Here is another example. It creates a two-dimensional array of double:

// var vals = new[,] { {1.1, 2.2}, {3.3, 4.4},{ 5.5, 6.6} };

// In this case, vals has the dimensions 2×3.

// You can also declare implicitly typed jagged arrays. For example, consider the following
// program:

// Demonstrate an implicitly-typed jagged array.  

// using System;  

// class Jagged
// {
//    static void Main()
//    {

//        var jagged = new[] {
//       new[] { 1, 2, 3, 4 },
//       new[] { 9, 8, 7 },
//       new[] { 11, 12, 13, 14, 15 }
//    };

//        for (int j = 0; j < jagged.Length; j++)
//        {
//            for (int i = 0; i < jagged[j].Length; i++)
//                Console.Write(jagged[j][i] + " ");

//            Console.WriteLine();
//        }
//    }
// }

// The program produces the following output:

// 1 2 3 4
// 9 8 7
// 11 12 13 14 15

// Pay special attention to the declaration of jagged:

// var jagged = new[] {
// new[] { 1, 2, 3, 4 },
// new[] { 9, 8, 7 },
// new[] { 11, 12, 13, 14, 15 }
// };

// Notice how new[] is used in two ways. First, it creates the array of arrays. Second, it creates
// each individual array, based on the number and type of initializers. As you would expect,
// all of the initializers in the individual arrays must be of the same type. The same general
// approach used to declare jagged can be used to declare any implicitly typed jagged array.

// As mentioned, implicitly typed arrays are most applicable to LINQ-based queries. They
// are not meant for general use. In most cases, you should use explicitly typed arrays.

#endregion