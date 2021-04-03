#region Russian

// Применение индексаторов и свойств

// В предыдущих примерах программ был продемонстрирован основной принцип
// действия индексаторов и свойств, но их возможности не были раскрыты в полную
// силу. Поэтому в завершение этой главы обратимся к примеру класса RangeArray,
// в котором индексаторы и свойства используются для создания типа массива с пределами
// индексирования, определяемыми пользователем.

// Как вам должно быть уже известно, индексирование всех массивов в C# начинается
// с нуля. Но в некоторых приложениях индексирование массива удобнее начинать с любой
// произвольной точки отсчета: с 1 или даже с отрицательного числа, например от
// -5 и до 5. Рассматриваемый здесь класс RangeArray разработан таким образом, чтобы
// допускать подобного рода индексирование массивов.

// Используя класс RangeArray, можно написать следующий фрагмент кода.

// RangeArray rа = new RangeArray(-5, 10); // массив с индексами от -5 до 10
// for (int i = -5; i <= 10; i++) ra[i] = i; // индексирование массива от -5 до 10

// Нетрудно догадаться, что в первой строке этого кода конструируется объект класса
// RangeArray с пределами индексирования массива от -5 до 10 включительно. Первый
// аргумент обозначает начальный индекс, а второй — конечный индекс. Как только
// объект rа будет сконструирован, он может быть проиндексирован как массив в пределах
// от -5 до 10.

// Ниже приведен полностью класс RangeArray вместе с классом RangeArrayDemo,
// в котором демонстрируется индексирование массива в заданных пределах. Класс
// RangeArray реализован таким образом, чтобы поддерживать массивы типа int, но
// при желании вы можете изменить этот тип на любой другой.

/* Создать класс со специально указываемыми пределами индексирования массива.
Класс RangeArray допускает индексирование массива с любого значения, а не
только с нуля. При создании объекта класса RangeArray указываются начальный
и конечный индексы. Допускается также указывать отрицательные индексы.
Например, можно создать массивы, индексируемые от -5 до 5, от 1 до 10
или же от 50 до 56. */
using System;

class RangeArray
{
    //Закрытые данные.
    int[] a; //ссылка на базовый массив
    int lowerBound; //наименьший индекс
    int upperBound; //наибольший индекс

    //Автоматически реализуемое и доступное только для чтения свойство Length.
    public int Length { get; private set; }

    //Автоматически реализуемое и доступное только для чтения свойство Error.
    public bool Error { get; private set; }

    //Построить массив по заданному размеру.
    public RangeArray(int low, int high)
    {
        high++;

        if (high <= low)
        {
            Console.WriteLine("Неверные индексы");
            high = 1; //Создать для надежности минимально допустимый массив.
            low = 0;
        }

        a = new int[high - low];
        Length = high - low;

        lowerBound = low;
        upperBound = --high;
    }

    //Это индексатор для класса RangeArray.
    public int this[int index]
    {
        //Это аксессор get.
        get
        {
            if (ok(index))
            {
                Error = false;
                return a[index - lowerBound];
            }
            else
            {
                Error = true;
                return 0;
            }
        }

        //Это аксессор set.
        set
        {
            if (ok(index))
            {
                a[index - lowerBound] = value;
                Error = false;
            }
            else
            {
                Error = true;
            }
        }
    }

    //Возвратить логическое значение true, если индекс находится в установленных границах.
    private bool ok(int index)
    {
        if (index >= lowerBound & index <= upperBound)
        {
            return true;
        }

        return false;
    }
}

//Продемонстрировать применение массива с произвольно задаваемыми пределами индексирования.
class RangeArrayDemo
{
    static void Main()
    {
        RangeArray ra = new RangeArray(-5, 5);
        RangeArray ra2 = new RangeArray(1, 10);
        RangeArray ra3 = new RangeArray(-20, -12);

        //Использовать объект ra в качестве массива.
        Console.WriteLine("Длина массива ra: " + ra.Length);
        for (int i = -5; i < 5; i++)
        {
            ra[i] = i;
        }

        Console.WriteLine("Содержимое массива ra: ");
        for (int i = -5; i < 5; i++)
        {
            Console.Write(ra[i] + " ");
        }

        Console.WriteLine("\n");

        //Использовать объект ra2 в качестве массива.
        Console.WriteLine("Длина массива ra2: " + ra2.Length);
        for (int i = 1; i < 10; i++)
        {
            ra2[i] = i;
        }

        Console.WriteLine("Содержимое массива ra2: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(ra2[i] + " ");
        }

        Console.WriteLine("\n");

        //Использовать объект ra3 в качестве массива.
        Console.WriteLine("Длина массива ra: " + ra3.Length);
        for (int i = -20; i <= -12; i++)
        {
            ra3[i] = i;
        }

        Console.WriteLine("Содержимое массива ra3: ");
        for (int i = -20; i <= -12; i++)
        {
            Console.Write(ra3[i] + " ");
        }

        Console.WriteLine("\n");

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этого кода получается следующий результат.

// Длина массива ra: 11
// Содержимое массива ra: -5 - 4 - 3 - 2 - 1 0 1 2 3 4 5

// Длина массива ra2: 10
// Содержимое массива ra2: 1 2 3 4 5 6 7 8 9 10

// Длина массива ra3: 9
// Содержимое массива ra2: -20 - 19 - 18 - 17 - 16 - 15 - 14 - 13 - 12

// Как следует из результата выполнения приведенного выше кода, объекты типа
// RangeArray можно индексировать в качестве массивов, начиная с любой точки
// отсчета, а не только с нуля. Рассмотрим подробнее саму реализацию класса
// RangeArray.

// В начале класса RangeArray объявляются следующие закрытые переменные экземпляра.

// // Закрытые данные.
// int[] а; // ссылка на базовый массив
// int lowerBound; // наименьший индекс
// int upperBound; // наибольший индекс

// Переменная а служит для обращения к базовому массиву по ссылке. Память для
// него распределяется конструктором класса RangeArray. Нижняя граница индексирования
// массива хранится в переменной lowerBound, а верхняя граница — в переменной
// upperBound.

// Далее объявляются автоматически реализуемые свойства Length и Error.
// // Автоматически реализуемое и доступное только для чтения свойство Length.

// public int Length { get; private set; }

// // Автоматически реализуемое и доступное только для чтения свойство Error.

// public bool Error { get; private set; }

// Обратите внимание на то, что в обоих свойства аксессор set обозначен как private.
// Как пояснялось выше, такое объявление автоматически реализуемого свойства, по существу,
// делает его доступным только для чтения.

// Ниже приведен конструктор класса RangeArray.

// // Построить массив по заданному размеру.
// public RangeArray(int low, int high)
// {
//    high++;
//    if (high <= low)
//    {
//        Console.WriteLine("Неверные индексы");
//        high = 1; // создать для надежности минимально допустимый массив
//        low = 0;
//    }
//    а = new int[high - low];
//    Length = high - low;
//    lowerBound = low;
//    upperBound = --high;
// }

// При конструировании объекту класса RangeArray передается нижняя граница
// массива в качестве параметра low, а верхняя граница — в качестве параметра high.
// Затем значение параметра high инкрементируется, поскольку пределы индексирования
// массива изменяются от low до high включительно. Далее выполняется следующая
// проверка: является ли верхний индекс больше нижнего индекса. Если это не так, то
// выдается сообщение об ошибке и создается массив, состоящий из одного элемента.
// После этого для массива распределяется память, а ссылка на него присваивается переменной
// а. Затем свойство Length устанавливается равным числу элементов массива.
// И наконец, устанавливаются переменные lowerBound и upperBound.

// Далее в классе RangeArray реализуется его индексатор, как показано ниже.
// // Это индексатор для класса RangeArray.
// public int this[int index]
// {
//    // Это аксессор get.
//    get
//    {
//        if (ok(index))
//        {
//            Error = false;
//            return a[index - lowerBound];
//        }
//        else
//        {
//            Error = true;
//            return 0;
//        }
//        328 Часть I. Язык C#
// }
//    // Это аксессор set.
//    set
//    {
//        if (ok(index))
//        {
//            a[index - lowerBound] = value;
//            Error = false;
//        }
//        else Error = true;
//    }
// }

// Этот индексатор подобен тому, что использовался в классе FailSoftArray, за одним
// существенным исключением. Обратите внимание на следующее выражение, в котором
// индексируется массив а.

// index - lowerBound

// В этом выражении индекс, передаваемый в качестве параметра index, преобразуется
// в индекс с отсчетом от нуля, пригодный для индексирования массива а. Данное
// выражение действует при любом значении переменной lowerBound: положительном,
// отрицательном или нулевом.

// Ниже приведен метод ok().

// // Возвратить логическое значение true, если индекс находится в установленных границах.
// private bool ok(int index)
// {
//    if (index >= lowerBound & index <= upperBound) return true;
//    return false;
// }

// Этот метод аналогичен использовавшемуся в классе FailSoftArray, за исключением
// того, что в нем контроль границ массива осуществляется по значениям переменных
// lowerBound и upperBound.

// Класс RangeArray демонстрирует лишь одну разновидность специализированного
// массива, который может быть создан с помощью индексаторов и свойств. Существуют,
// конечно, и другие. Аналогичным образом можно, например, создать динамические
// массивы, которые расширяются или сужаются по мере надобности, ассоциативные
// и разреженные массивы. Попробуйте создать один из таких массивов в качестве
// упражнения.

#endregion

#region English

// Using Indexers and Properties

// Although the preceding examples have demonstrated the basic mechanism of indexers and
// properties, they haven’t displayed their full power. To conclude this chapter, a class called
// RangeArray is developed that uses indexers and properties to create an array type in which
// the index range of the array is determined by the programmer.

// As you know, in C# all arrays begin indexing at zero. However, some applications would
// benefit from an array that allows indexes to begin at any arbitrary point. For example, in
// some situations it might be more convenient for an array to begin indexing with 1. In another
// situation, it might be beneficial to allow negative indexes, such as an array that runs from –5
// to 5. The RangeArray class developed here allows these and other types of indexing.

// Using RangeArray, you can write code like this:

// RangeArray ra = new RangeArray(-5, 10); // array with indexes from -5 to 10
// for (int i = -5; i <= 10; i++) ra[i] = i; // index from -5 to 10

// As you can guess, the first line constructs a RangeArray that runs from –5 to 10, inclusive.
// The first argument specifies the beginning index. The second argument specifies the ending
// index. Once ra has been constructed, it can be indexed from –5 to 10.

// The entire RangeArray class is shown here, along with RangeArrayDemo, which
// demonstrates the array. As implemented here, RangeArray supports arrays of int, but
// you can change the data type, if desired.

/* Create a specifiable range array class. 
   The RangeArray class allows indexing to begin at 
   some value other than zero. When you create a RangeArray, 
   you specify the beginning and ending index. Negative 
   indexes are also  allowed.  For example, you can create 
   arrays that index from -5 to 5, 1 to 10, or 50 to 56. 
*/

// using System;  

// class RangeArray
// {
//    // Private data. 
//    int[] a; // reference to underlying array   
//    int lowerBound; // smallest index 
//    int upperBound; // largest index 

//    // An auto-implemented, read-only Length property. 
//    public int Length { get; private set; }

//    // An auto-implemented, read-only Error property. 
//    public bool Error { get; private set; }

//    // Construct array given its size.  
//    public RangeArray(int low, int high)
//    {
//        high++;
//        if (high <= low)
//        {
//            Console.WriteLine("Invalid Indixes");
//            high = 1; // create a minimal array for safety 
//            low = 0;
//        }
//        a = new int[high - low];
//        Length = high - low;

//        lowerBound = low;
//        upperBound = --high;
//    }

//    // This is the indexer for RangeArray.  
//    public int this[int index]
//    {
//        // This is the get accessor.  
//        get
//        {
//            if (ok(index))
//            {
//                Error = false;
//                return a[index - lowerBound];
//            }
//            else
//            {
//                Error = true;
//                return 0;
//            }
//        }

//        // This is the set accessor.  
//        set
//        {
//            if (ok(index))
//            {
//                a[index - lowerBound] = value;
//                Error = false;
//            }
//            else Error = true;
//        }
//    }

//    // Return true if index is within bounds.  
//    private bool ok(int index)
//    {
//        if (index >= lowerBound & index <= upperBound) return true;
//        return false;
//    }
// }

// // Demonstrate the index-range array.  
// class RangeArrayDemo
// {
//    static void Main()
//    {
//        RangeArray ra = new RangeArray(-5, 5);
//        RangeArray ra2 = new RangeArray(1, 10);
//        RangeArray ra3 = new RangeArray(-20, -12);

//        // Demonstrate ra. 
//        Console.WriteLine("Length of ra: " + ra.Length);

//        for (int i = -5; i <= 5; i++)
//            ra[i] = i;

//        Console.Write("Contents of ra: ");
//        for (int i = -5; i <= 5; i++)
//            Console.Write(ra[i] + " ");

//        Console.WriteLine("\n");

//        // Demonstrate ra2. 
//        Console.WriteLine("Length of ra2: " + ra2.Length);

//        for (int i = 1; i <= 10; i++)
//            ra2[i] = i;

//        Console.Write("Contents of ra2: ");
//        for (int i = 1; i <= 10; i++)
//            Console.Write(ra2[i] + " ");

//        Console.WriteLine("\n");

//        // Demonstrate ra3. 
//        Console.WriteLine("Length of ra3: " + ra3.Length);

//        for (int i = -20; i <= -12; i++)
//            ra3[i] = i;

//        Console.Write("Contents of ra3: ");
//        for (int i = -20; i <= -12; i++)
//            Console.Write(ra3[i] + " ");

//        Console.WriteLine("\n");
//    }
// }

// The output from the program is shown here:

// Length of ra: 11
// Contents of ra: -5 - 4 - 3 - 2 - 1 0 1 2 3 4 5

// Length of ra2: 10
// Contents of ra2: 1 2 3 4 5 6 7 8 9 10

// Length of ra3: 9
// Contents of ra3: -20 - 19 - 18 - 17 - 16 - 15 - 14 - 13 - 12

// As the output verifies, objects of type RangeArray can be indexed in ways other than
// starting at zero. Let’s look more closely at how RangeArray is implemented.

// RangeArray begins by defining the following private instance variables:

// // Private data.
// int[] a; // reference to underlying array
// int lowerBound; // smallest index
// int upperBound; // largest index

// The underlying array is referred to by a. This array is allocated by the RangeArray
// constructor. The index of the lower bound of the array is stored in lowerBound, and the
// index of the upper bound is stored in upperBound.

// Next, the auto-implemented, read-only properties Length and Error are declared:

// // An auto-implemented, read-only Length property.
// public int Length { get; private set; }

// // An auto-implemented, read-only Error property.
// public bool Error { get; private set; }

// Notice that for both properties, the set accessor is private. As explained earlier in this
// chapter, this results in what is effectively a read-only, auto-implemented property.

//The RangeArray constructor is shown here:

// // Construct array given its size.
// public RangeArray(int low, int high)
// {
//    high++;
//    if (high <= low)
//    {
//        Console.WriteLine("Invalid Indixes");
//        high = 1; // create a minimal array for safety
//        low = 0;
//    }
//    a = new int[high - low];
//    Length = high - low;
//    lowerBound = low;
//    upperBound = --high;
// }

// A RangeArray is constructed by passing the lower bound index in low and the upper
// bound index in high. The value of high is then incremented because the indexes specified
// are inclusive. Next, a check is made to ensure that the upper index is greater than the lower
// index. If not, an error is reported and a one-element array is created. Next, storage for the
// array is allocated and assigned to a. Then the Length property is set equal to the number of
// elements in the array. Finally, lowerBound and upperBound are set.

// Next, RangeArray implements its indexer, as shown here:

// // This is the indexer for RangeArray.
// public int this[int index]
// {
//    // This is the get accessor.
//    get
//    {
//        if (ok(index))
//        {
//            Error = false;
//            return a[index - lowerBound];
//        }
//        else
//        {
//            Error = true;
//            return 0;
//        }
//    }
//    // This is the set accessor.
//    set
//    {
//        if (ok(index))
//        {
//            a[index - lowerBound] = value;
//            Error = false;
//        }
//        else Error = true;
//    }
// }

// This indexer is similar to the one used by FailSoftArray, with one important exception.
// Notice the expression that indexes a. It is

// index - lowerBound

// This expression transforms the index passed in index into a zero-based index suitable for
// use on a. This expression works whether lowerBound is positive, negative, or zero.

// The ok( ) method is shown here:

// // Return true if index is within bounds.
// private bool ok(int index)
// {
//    if (index >= lowerBound & index <= upperBound) return true;
//    return false;
// }

// It is similar to the one used by FailSoftArray except that the range is checked by testing it
// against the values in lowerBound and upperBound.

// RangeArray illustrates just one kind of custom array that you can create through the
// use of indexers and properties. There are, of course, several others. For example, you can
// create dynamic arrays, which expand and contract as needed, associative arrays, and sparse
// arrays. You might want to try creating one of these types of arrays as an exercise.

#endregion