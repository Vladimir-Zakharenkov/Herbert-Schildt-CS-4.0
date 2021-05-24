#region Russian

// Обращение со строками

// Класс типа string содержит ряд методов для обращения со строками. Некоторые
// из этих методов перечислены в табл. 7.1. Обратите внимание на то, что некоторые
// методы принимают параметр типа StringComparison. Это перечислимый
// тип, определяющий различные значения, которые определяют порядок сравнения
// символьных строк. (О перечислениях речь пойдет в главе 12, но для применения типа
// StringComparison к символьным строкам знать о перечислениях необязательно.)
// Нетрудно догадаться, что символьные строки можно сравнивать разными способами.
// Например, их можно сравнивать на основании двоичных значений символов, из
// которых они состоят. Такое сравнение называется порядковым. Строки можно также
// сравнивать с учетом различных особенностей культурной среды, например, в лексикографическом
// порядке. Это так называемое сравнение с учетом культурной среды.
// (Учитывать культурную среду особенно важно в локализуемых приложениях.) Кроме
// того, строки можно сравнивать с учетом или без учета регистра. Несмотря на то что
// существуют перегружаемые варианты методов Compare(), Equals(), IndexOf()
// и LastIndexOf(), обеспечивающие используемый по умолчанию подход к сравнению
// символьных строк, в настоящее время считается более приемлемым явно указывать
// способ требуемого сравнения, чтобы избежать неоднозначности, а также упростить
// локализацию приложений. Именно поэтому здесь рассматривают разные способы
// сравнения символьных строк.

// Как правило и за рядом исключений, для сравнения символьных строк с учетом
// культурной среды (т.е. языковых и региональных стандартов) применяется
// способ StringComparison.CurrentCulture. Если же требуется сравнить строки
// только на основании значений их символов, то лучше воспользоваться способом
// StringComparison.Ordinal, а для сравнения строк без учета регистра — одним
// из двух способов: StringComparison.CurrentCultureIgnoreCase или
// StringComparison.OrdinalIgnoreCase. Кроме того, можно указать сравнение
// строк без учета культурной среды (подробнее об этом — в главе 22).

// Обратите внимание на то, что метод Compare() объявляется в табл. 7.1 как static.
// Подробнее о модификаторе static речь пойдет в главе 8, а до тех пор вкратце поясним,
// что он обозначает следующее: метод Compare() вызывается по имени своего
//класса, а не по его экземпляру. Следовательно, для вызова метода Compare() служит
//следующая общая форма:

// результат = string.Compare(str1, str2, способ);

// где способ обозначает конкретный подход к сравнению символьных строк.

// ПРИМЕЧАНИЕ
// Дополнительные сведения о способах сравнения и поиска символьных строк, включая
// и особое значение выбора подходящего способа, приведены в главе 22, где подробно
// рассматривается обработка строк.

// Обратите также внимание на методы ToUpper() и ToLower(), преобразующие содержимое
// строки в символы верхнего и нижнего регистра соответственно. Их формы,
// представленные в табл. 7.1, содержат параметр CultureInfо, относящийся к классу,
// в котором описываются атрибуты культурной среды, применяемые для сравнения.
// В примерах, приведенных в этой книге, используются текущие настройки культурной
// среды (т.е. текущие языковые и региональные стандарты). Эти настройки указываются
// при передаче методу аргумента CultureInfo.CurrentCulture. Класс CultureInfo
// относится к пространству имен System.Globalization. Любопытно, имеются варианты
// рассматриваемых здесь методов, в которых текущая культурная среда используется
// по умолчанию, но во избежание неоднозначности в примерах из этой книги
// аргумент CultureInfo.CurrentCulture указывается явно.

// Объекты типа string содержат также свойство Length, где хранится длина строки.

// Таблица 7.1. Некоторые общеупотребительные методы обращения со строками

// Метод                                    Описание

//  static int Compare(string                 Возвращает отрицательное значение, если строка
//  strA, string strB,                        strA меньше строки strB; положительное значение,
//  StringComparison                          если строка strA больше строки strВ; и нуль,
//  comparisonType)                           если сравниваемые строки равны. Способ сравнения
//                                            определяется аргументом comparisonType

// bool Equals(string                         Возвращает логическое значение true, если вызывающая
// value, StringComparison                    строка имеет такое же значение, как и у
// comparisonType)                            аргумента value. Способ сравнения определяется
//                                            аргументом comparisonType


// int IndexOf(char value)                    Осуществляет поиск в вызывающей строке первого
//                                            вхождения символа, определяемого аргументом
//                                            value. Применяется порядковый способ поиска.
//                                            Возвращает индекс первого совпадения с искомым
//                                            символом или -1, если он не обнаружен

// int IndexOf(string                         Осуществляет поиск в вызывающей строке первого
// value, StringComparison                    вхождения подстроки, определяемой аргументом
// comparisonType)                            value. Возвращает индекс первого совпадения
//                                            с искомой подстрокой или -1, если она не обнаружена.
//                                            Способ поиска определяется аргументом comparisonType

// int LastIndexOf(char value)                Осуществляет поиск в вызывающей строке последнего
//                                            вхождения символа, определяемого аргументом
//                                            value. Применяется порядковый способ поиска.
//                                            Возвращает индекс последнего совпадения с искомым
//                                            символом или -1, если он не обнаружен

//int LastIndexOf(string                      Осуществляет поиск в вызывающей строке последнего
//value, StringComparison                     вхождения подстроки, определяемой аргументом
//comparisonType)                             value. Возвращает индекс последнего совпадения
//                                            с искомой подстрокой или -1, если она не обнаружена.
//                                            Способ поиска определяется аргументом comparisonType

//string ToLower(CultureInfo.                 Возвращает вариант вызывающей строки в нижнем
//CurrentCulture culture)                     регистре. Способ преобразования определяется аргументом
//                                            culture

//string ToUpper(CultureInfo.                 Возвращает вариант вызывающей строки в верхнем
//CurrentCulture culture)                     регистре. Способ преобразования определяется аргументом
//                                            culture


// Отдельный символ выбирается из строки с помощью индекса, как в приведенном
// ниже фрагменте кода.

// string str = "тест";
// Console.WriteLine(str[0]);

// В этом фрагменте кода выводится символ "т", который является первым в строке
// "тест". Как и в массивах, индексирование строк начинается с нуля. Следует, однако,
// иметь в виду, что с помощью индекса нельзя присвоить новое значение символу в строке.
// Индекс может служить только для выборки символа из строки.

// Для проверки двух строк на равенство служит оператор ==. Как правило, если оператор
// == применяется к ссылкам на объект, то он определяет, являются ли они ссылками
// на один и тот же объект. Совсем иначе обстоит дело с объектами типа string.
// Когда оператор == применяется к ссылкам на две строки, он сравнивает содержимое
// этих строк. Это же относится и к оператору !=. В обоих случаях выполняется порядковое
// сравнение. Для проверки двух строк на равенство с учетом культурной среды
// служит метод Equals(), где непременно нужно указать способ сравнения в виде аргумента
// StringComparison.CurrentCulture. Следует также иметь в виду, что метод
// Compare() служит для сравнения строк с целью определить отношение порядка,
// например для сортировки. Если же требуется проверить символьные строки на равенство,
// то для этой цели лучше воспользоваться методом Equals() или строковыми
// операторами.

// В приведенном ниже примере программы демонстрируется несколько операций со строками.

//Некоторые операции со строками.
using System;
using System.Globalization;

class StrOps
{
    static void Main()
    {
        string str1 = "Программировать в .NET лучше всего на C#.";
        string str2 = "Программировать в .NET лучше всего на C#.";
        string str3 = "Строки в C# весьма эффективны.";
        string strUp, strLow;
        int result, idx;

        Console.WriteLine("str1: " + str1);
        Console.WriteLine("Длина строки str1: " + str1.Length);

        Console.WriteLine();

        //Создать варианты строки str1, набранные прописными и строчными буквами.
        strLow = str1.ToLower(CultureInfo.CurrentCulture);
        strUp = str1.ToUpper(CultureInfo.CurrentCulture);

        Console.WriteLine("Вариант строки str1, набранный строчными буквами:\n" + strLow + "\n");
        Console.WriteLine("Вариант строки str1, набранный прописными буквами:\n" + strUp);

        Console.WriteLine();

        //Вывести строку str1 посимвольно.
        Console.WriteLine("Вывод строки str1 посимвольно.");
        for (int i = 0; i < str1.Length; i++)
        {
            Console.Write(str1[i]);
        }

        Console.WriteLine("\n");

        //Сравнить строки способом порядкового сравнения.
        if (str1 == str2)
        {
            Console.WriteLine("str1 == str2");
        }
        else
        {
            Console.WriteLine("str1 != str2");
        }

        if (str1 == str3)
        {
            Console.WriteLine("str1 == str3");
        }
        else
        {
            Console.WriteLine("str1 != str3");
        }

        Console.WriteLine();

        //Сравнить строки с учетом культурной среды.
        result = string.Compare(str3, str1, StringComparison.CurrentCulture);

        if (result == 0)
        {
            Console.WriteLine("Строки str1 и str3 равны");
        }
        else if (result < 0)
        {
            Console.WriteLine("Строка str1 меньше строки str3");
        }
        else
        {
            Console.WriteLine("Строка str1 больше строки str3");
        }

        Console.WriteLine();

        //Присвоить новую строку переменной str2.
        str2 = "Один Два Три Один";

        //Поиск подстроки.
        idx = str2.IndexOf("Один", StringComparison.Ordinal);
        Console.WriteLine("Индекс первого вхождения подстроки <Один>: " + idx + "\n");

        idx = str2.LastIndexOf("Один", StringComparison.Ordinal);
        Console.WriteLine("Индекс последнего вхождения подстроки <Один>: " + idx + "\n");

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// str1: Программировать в.NET лучше всего на С#.
// Длина строки str1: 41

// Вариант строки str1, набранный строчными буквами:
// программировать в .net лучше всего на c#.

// Вариант строки str1, набранный прописными буквами:
// ПРОГРАММИРОВАТЬ В .NET ЛУЧШЕ ВСЕГО НА C#.

// Вывод строки str1 посимвольно.
// Программировать в .NET лучше всего на С#.

// str1 == str2
// str1 != str3

// Строка str1 больше строки str3

// Индекс первого вхождения подстроки <Один>: 0
// Индекс последнего вхождения подстроки <Один>: 13

// Прежде чем читать дальше, обратите внимание на то, что метод Compare() вызывается
// следующим образом.

// result = string.Compare(str1, str3, StringComparison.CurrentCulture);

// Как пояснялось ранее, метод Compare() объявляется как static, и поэтому он вызывается
// по имени, а не по экземпляру своего класса.

// С помощью оператора + можно сцепить (т.е. объединить вместе) две строки.
// Например, в следующем фрагменте кода:

// string str1 = "Один";
// string str2 = "Два";
// string str3 = "Три";
// string str4 = str1 + str2 + str3;

// переменная str4 инициализируется строкой "ОдинДваТри".

// И еще одно замечание: ключевое слово string является псевдонимом класса
// System.String, определенного в библиотеке классов для среды .NET Framework,
// т.е. оно устанавливает прямое соответствие с этим классом. Следовательно, поля
// и методы, определяемые типом string, относятся непосредственно к классу
// System.String, в который входят и многие другие компоненты. Подробнее о классе
// System.String речь пойдет в части II этой книги.

#endregion

#region English

// Operating on Strings

// The string class contains several methods that operate on strings. Table 7-1 shows a few.
// Notice that several of the methods take a parameter of type StringComparison. This is an
// enumeration type that defines various values that determine how a comparison involving
// strings will be conducted. (Enumerations are described in Chapter 12, and the use of
// StringComparison here does not require an understanding of enumerations.) As you
// might guess, there are various ways in which two strings can be compared. For example,
// they can be compared based on the binary values of the characters that comprise them.
// This is called an ordinal comparison. Strings can also be compared in a way that takes into
// account various cultural metrics, such as dictionary order. This type of comparison is
// called culture-sensitive. (Culture sensitivity is especially important in applications that are
// being internationalized.) Furthermore, comparisons can either be case-sensitive or ignore
// case differences. Although overloads of methods such as Compare(), Equals(), IndexOf(),
// and LastIndexOf() do exist that provide a default string comparison approach, it is now
// considered best to explicitly specify what type of comparison you want. Doing so helps
// avoid ambiguity in this regard. (It also helps with internationalizing an application.) This
// is why these forms are shown here.

// In general, and with some exceptions, if you want to compare two strings for sorting
// relative to the cultural norms, you will use StringComparison.CurrentCulture as the
// comparison approach. If you want to compare two strings based solely on the value
// of their characters, it is usually best to use StringComparison.Ordinal. To ignore
// case differences, specify either StringComparison.CurrentCultureIgnoreCase or
// StringComparison.OrdinalIgnoreCase. You can also specify an invariant culture.
// (See Chapter 22.)

// Notice that in Table 7-1, Compare() is declared as static. The static modifier is described
// in Chapter 8, but briefly, as it is used here, it means that Compare( ) is called on its class
// name, not an instance of its class. Thus, to call Compare( ), you will use this general form:

// result = string.Compare(str1, str2, how);

// where how specifies the string comparison approach.

// NOTE
// Additional information about approaches to string comparisons and searches, including the
// importance of choosing the right technique, is found in Chapter 22, where string handling is
// discussed in detail.

// Also notice the two methods ToUpper() and ToLower(), which uppercase or lowercase
// a string, respectively. The forms shown here both have a CultureInfo parameter. This is a
// class that describes the cultural attributes to use for the conversion. The examples in
// this book use the current culture settings. These settings are specified by passing
// CultureInfo.CurrentCulture. The CultureInfo class is in System.Globalization.As a
// point of interest, there are versions of these methods that use the current culture by default,
// but to avoid ambiguity on this point, this book will explicitly specify this argument.

// The string type also includes the Length property, which contains the length of the string.

// Method                                           Description

// static int Compare(string strA, string strB,     Returns less than zero if strA is less than strB, greater
//      StringComparison comparisonType)            than zero if strA is greater than strB, and zero if the strings
//                                                  are equal. How the comparison is conducted is specified
//                                                  by comparisonType.

// bool Equals(string value,                        Returns true if the invoking string is the same as value.
//      StringComparison comparisonType)            How the comparison is conducted is specified by
//                                                  comparisonType.

// int IndexOf(char value)                          Searches the invoking string for the first occurrence of the
//                                                  character specified by value. An ordinal search is used.
//                                                  Returns the index of the first match, or –1 on failure.

// int IndexOf(string value,                        Searches the invoking string for the first occurrence of the
//      StringComparison comparisonType)            substring specified by value. How the search is conducted is
//                                                  specified by comparisonType. Returns the index of the first
//                                                  match, or –1 on failure.

// int LastIndexOf(char value)                      Searches the invoking string for the last occurrence of the
//                                                  character specified by value. An ordinal search is used.
//                                                  Returns the index of the first match, or –1 on failure.

// int LastIndexOf(string value,                    Searches the invoking string for the last occurrence of the
//      StringComparison comparisonType)            substring specified by value. How the search is conducted is
//                                                  specified by comparisonType. Returns the index of the last
//                                                  match, or –1 on failure.


// string ToLower(                                  Returns a lowercase version of the invoking string. How the
//      CultureInfo.CurrentCulture culture)         conversion is performed is specified by culture.


// string ToUpper(                                  Returns an uppercase version of the invoking string. How
//      CultureInfo.CurrentCulture culture)         the conversion is performed is specified by culture.

// To obtain the value of an individual character of a string, you simply use an index. For
// example:

// string str = "test";
// Console.WriteLine(str[0]);

// This displays “t”, the first character of “test”. Like arrays, string indexes begin at zero. One
// important point, however, is that you cannot assign a new value to a character within a
// string using an index. An index can only be used to obtain a character.

// You can use the = = operator to test two strings for equality. Normally, when the = =
// operator is applied to object references, it determines if both references refer to the same
// object. This differs for objects of type string. When the = = is applied to two string
// references, the contents of the strings themselves are compared for equality. The same is
// true for the != operator: when comparing string objects, the contents of the strings are
// compared. In both cases, an ordinal comparison is performed. To test two strings for
// equality using cultural information, use Equals() and specify the comparison approach,
// such as StringComparison.CurrentCulture. One other point: the Compare() method is
// intended to compare strings to determine an ordering relationship, such as for sorting. To
// test for equality, use Equals( ) or the string operators.

// Here is a program that demonstrates several string operations:

// Some string operations.  
// using System; 
// using System.Globalization;  

// class StrOps
// {
//    static void Main()
//    {
//        string str1 = "When it comes to .NET programming, C# is #1.";
//        string str2 = "When it comes to .NET programming, C# is #1.";
//        string str3 = "C# strings are powerful.";
//        string strUp, strLow;
//        int result, idx;

//        Console.WriteLine("str1: " + str1);

//        Console.WriteLine("Length of str1: " + str1.Length);

//        // Create upper- and lowercase versions of str1. 
//        strLow = str1.ToLower(CultureInfo.CurrentCulture);
//        strUp = str1.ToUpper(CultureInfo.CurrentCulture);
//        Console.WriteLine("Lowercase version of str1:\n    " +
//                          strLow);
//        Console.WriteLine("Uppercase version of str1:\n    " +
//                          strUp);

//        Console.WriteLine();

//        // Display str1, one char at a time.  
//        Console.WriteLine("Display str1, one char at a time.");
//        for (int i = 0; i < str1.Length; i++)
//            Console.Write(str1[i]);
//        Console.WriteLine("\n");

//        // Compare strings using == and !=. These comparisons are ordinal. 
//        if (str1 == str2)
//            Console.WriteLine("str1 == str2");
//        else
//            Console.WriteLine("str1 != str2");

//        if (str1 == str3)
//            Console.WriteLine("str1 == str3");
//        else
//            Console.WriteLine("str1 != str3");

//        // This comparison is culture-sensitive. 
//        result = string.Compare(str1, str3, StringComparison.CurrentCulture);
//        if (result == 0)
//            Console.WriteLine("str1 and str3 are equal");
//        else if (result < 0)
//            Console.WriteLine("str1 is less than str3");
//        else
//            Console.WriteLine("str1 is greater than str3");

//        Console.WriteLine();

//        // Assign a new string to str2. 
//        str2 = "One Two Three One";

//        // Search a string. 
//        idx = str2.IndexOf("One", StringComparison.Ordinal);
//        Console.WriteLine("Index of first occurrence of One: " + idx);
//        idx = str2.LastIndexOf("One", StringComparison.Ordinal);
//        Console.WriteLine("Index of last occurrence of One: " + idx);

//    }
// }

// This program generates the following output:

// str1: When it comes to.NET programming, C# is #1.
// Length of str1: 44

// Lowercase version of str1:
// when it comes to .net programming, c# is #1.
// Uppercase version of str1:
// WHEN IT COMES TO .NET PROGRAMMING, C# IS #1.

// Display str1, one char at a time.
// When it comes to .NET programming, C# is #1.

// str1 == str2
// str1 != str3
// str1 is greater than str3

// Index of first occurrence of One: 0
// Index of last occurrence of One: 14

// Before moving on, in the program notice that Compare( ) is called as shown here:

// result = string.Compare(str1, str3, StringComparison.CurrentCulture);

// As explained, because Compare( ) is declared as static, it is called on its class name, not an
// instance of its class.
// You can concatenate (join together) two strings using the + operator. For example, this
// statement:

// string str1 = "One";
// string str2 = "Two";
// string str3 = "Three";
// string str4 = str1 + str2 + str3;

// initializes str4 with the string “OneTwoThree”.

// One other point: The string keyword is an alias for (that is, maps directly to) the
// System.String class defined by the.NET Framework class library. Thus, the fields and
// methods defined by string are those of the System.String class, which includes more
// than the sampling described here. System.String is examined in detail in Part II.

#endregion