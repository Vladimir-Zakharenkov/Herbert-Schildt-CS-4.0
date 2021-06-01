#region Russian
/*
 18 ГЛАВА
Обобщения

Эта глава посвящена обобщениям — одному из самых сложных и эффективных средств С#. Любопытно,
что обобщения не вошли в первоначальную версию 1.0 и появились лишь в версии 2.0, но теперь они являются
неотъемлемой частью языка С#. Не будет преувеличением сказать, что внедрение обобщений коренным образом изменило
характер С#. Это нововведение не только означало появление нового элемента синтаксиса данного языка, но и
открыло новые возможности для внесения многочисленных изменений и обновлений в библиотеку классов. И хотя после
внедрения обобщений прошло уже несколько лет, последствия этого важного шага до сих пор сказываются на
развитии С# как языка программирования.

Обобщения как языковое средство очень важны потому, что они позволяют создавать классы, структуры, интерфейсы,
методы и делегаты для обработки разнотипных данных с соблюдением типовой безопасности. Как вам должно
быть известно, многие алгоритмы очень похожи по своей логике независимо от типа данных, к которым они применяются.
Например, механизм, поддерживающий очередь, остается одинаковым независимо от того, предназначена ли
очередь для хранения элементов типа int, string, object или для класса, определяемого пользователем. До появления
обобщений для обработки данных разных типов приходилось создавать различные варианты одного и того же
алгоритма. А благодаря обобщениям можно сначала выработать единое решение независимо от конкретного типа
данных, а затем применить его к обработке данных самых разных типов без каких-либо дополнительных усилий.

В этой главе описываются синтаксис, теория и практика применения обобщений,
а также показывается, каким образом обобщения обеспечивают типовую безопасность
в ряде случаев, которые раньше считались сложными. После прочтения настоящей
главы у вас невольно возникнет желание ознакомиться с материалом главы 25, посвященной
коллекциям, так как в ней приведено немало примеров применения обобщений
в классах обобщенных коллекций.

Что такое обобщения

Термин обобщение, по существу, означает параметризированный тип. Особая роль
параметризированных типов состоит в том, что они позволяют создавать классы,
структуры, интерфейсы, методы и делегаты, в которых обрабатываемые данные указываются
в виде параметра. С помощью обобщений можно, например, создать единый
класс, который автоматически становится пригодным для обработки разнотипных
данных. Класс, структура, интерфейс, метод или делегат, оперирующий параметризированным
типом данных, называется обобщенным, как, например, обобщенный класс или обобщенный метод.

Следует особо подчеркнуть, что в C# всегда имелась возможность создавать обобщенный
код, оперируя ссылками типа object. А поскольку класс object является
базовым для всех остальных классов, то по ссылке типа object можно обращаться
к объекту любого типа. Таким образом, до появления обобщений для оперирования
разнотипными объектами в программах служил обобщенный код, в котором для этой
цели использовались ссылки типа object.

Но дело в том, что в таком коде трудно было соблюсти типовую безопасность, поскольку
для преобразования типа object в конкретный тип данных требовалось приведение
типов. А это служило потенциальным источником ошибок из-за того, что
приведение типов могло быть неумышленно выполнено неверно. Это затруднение позволяют
преодолеть обобщения, обеспечивая типовую безопасность, которой раньше
так недоставало. Кроме того, обобщения упрощают весь процесс, поскольку исключают
необходимость выполнять приведение типов для преобразования объекта или другого
типа обрабатываемых данных. Таким образом, обобщения расширяют возможности
повторного использования кода и позволяют делать это надежно и просто.

ПРИМЕЧАНИЕ
Программирующим на C++ и Java необходимо иметь в виду, что обобщения в C# не следует
путать с шаблонами в C++ и обобщениями в Java, поскольку это разные, хотя и похожие
средства. В действительности между этими тремя подходами к реализации обобщений существуют
коренные различия. Если вы имеете некоторый опыт программирования на C++ или
Java, то постарайтесь на основании этого опыта не делать никаких далеко идущих выводов
о том, как обобщения действуют в С#.

Простой пример обобщений

Начнем рассмотрение обобщений с простого примера обобщенного класса. В приведенной
ниже программе определяются два класса. Первым из них является обобщенный
класс Gen, вторым — класс GenericsDemo, в котором используется класс Gen.
*/

//Простой пример обобщенного класса.
using System;

//В приведенном ниже классе Gen параметр типа T заменяется реальным типом данных при создании объекта типа Gen.
class Gen<T>
{
    T ob; //обьявить переменную типа Т

    //Обратите внимание на то, что у этого конструктора имеется параметр типа T
    public Gen(T o)
    {
        ob = o;
    }

    //Возвратить переменную экземпляра ob, которая относится к типу T.
    public T GetOb()
    {
        return ob;
    }

    //Показать тип T.
    public void ShowType()
    {
        Console.WriteLine("К типу T относится " + typeof(T));
    }
}

//Продемонстрировать применение обобщенного класса.
class GenericDemo
{
    static void Main()
    {
        //Создать переменную ссылки на объект Gen типа int.
        Gen<int> iOb;

        //Создать объект типа Gen<int> и присвоить ссылку на него переменной iOb.
        iOb = new Gen<int>(102);

        //Показать тип данных, хранящихся в переменной iOb.
        iOb.ShowType();

        //Получить значение переменной iOb.
        int v = iOb.GetOb();
        Console.WriteLine("Значение: " + v);

        Console.WriteLine();

        //Создать объект типа Gen для строк.
        Gen<string> strOb = new Gen<string>("Обобщения повышают эффективность.");

        //Показать тип данных, хранящихся в переменной strOb.
        strOb.ShowType();

        //Получить значение переменной strOb.
        string str = strOb.GetOb();
        Console.WriteLine("Значение: " + str);

        //Задержка программы.
        Console.ReadKey();
    }
}

/*
 Эта программа дает следующий результат.

К типу Т относится System.Int32
Значение: 102

К типу Т относится System.String
Значение: Обобщения повышают эффективность.

Внимательно проанализируем эту программу. Прежде всего обратите внимание на
объявление класса Gen в приведенной ниже строке кода:

class Gen<T> {

где Т — это имя параметра типа. Это имя служит в качестве метки-заполнителя конкретного
типа, который указывается при создании объекта класса Gen. Следовательно,
имя Т используется в классе Gen всякий раз, когда требуется параметр типа. Обратите
внимание на то, что имя Т заключается в угловые скобки (< >). Этот синтаксис можно
обобщить: всякий раз, когда объявляется параметр типа, он указывается в угловых
скобках. А поскольку параметр типа используется в классе Gen, то такой класс считается
обобщенным.

В объявлении класса Gen можно указывать любое имя параметра типа, но по традиции
выбирается имя Т. К числу других наиболее употребительных имен параметров
типа относятся V и Е. Вы, конечно, вольны использовать и более описательные имена,
например TValue или ТКеу. Но в этом случае первой в имени параметра типа принято
указывать прописную букву Т.

Далее имя Т используется для объявления переменной ob, как показано в следующей
строке кода.

Т ob; // объявить переменную типа Т

Как пояснялось выше, имя параметра типа Т служит меткой-заполнителем конкретного
типа, указываемого при создании объекта класса Gen. Поэтому переменная
ob будет иметь тип, привязываемый к Т при получении экземпляра объекта класса Gen.
Так, если вместо Т указывается тип string, то в экземпляре данного объекта переменная
оb будет иметь тип string.

А теперь рассмотрим конструктор класса Gen.

public Gen(Т о) {
ob = о;
}

Как видите, параметр о этого конструктора относится к типу Т. Это означает, что
конкретный тип параметра о определяется типом, привязываемым к Т при создании
объекта класса Gen. А поскольку параметр о и переменная экземпляра ob относятся
к типу Т, то после создания объекта класса Gen их конкретный тип окажется одним и
тем же.

С помощью параметра типа Т можно также указывать тип, возвращаемый методом,
как показано ниже на примере метода GetOb().

public Т GetOb() {
return ob;
}

Переменная ob также относится к типу Т, поэтому ее тип совпадает с типом, возвращаемым
методом GetOb().

Метод ShowType() отображает тип параметра Т, передавая его оператору typeof.
Но поскольку реальный тип подставляется вместо Т при создании объекта класса Gen,
то оператор typeof получит необходимую информацию о конкретном типе.

В классе GenericsDemo демонстрируется применение обобщенного класса Gen.
Сначала в нем создается вариант класса Gen для типа int.

Gen<int> iOb;

Внимательно проанализируем это объявление. Прежде всего обратите внимание на
то, что тип int указывается в угловых скобках после имени класса Gen. В этом случае
int служит аргументом типа, привязанным к параметру типа Т в классе Gen. В данном
объявлении создается вариант класса Gen, в котором тип Т заменяется типом int везде,
где он встречается. Следовательно, после этого объявления int становится типом
переменной ob и возвращаемым типом метода GetOb().

В следующей строке кода переменной iOb присваивается ссылка на экземпляр
объекта класса Gen для варианта типа int.

iOb = new Gen<int>(102);

Обратите внимание на то, что при вызове конструктора класса Gen указывается также
аргумент типа int. Это необходимо потому, что переменная (в данном случае —
iOb), которой присваивается ссылка, относится к типу Gen<int>. Поэтому ссылка, возвращаемая
оператором new, также должна относиться к типу Gen<int>. В противном
случае во время компиляции возникнет ошибка. Например, приведенное ниже присваивание
станет причиной ошибки во время компиляции.

iOb = new Gen<double>(118.12); // Ошибка!

Переменная iOb относится к типу Gen<int> и поэтому не может использоваться
для ссылки на объект типа Gen<double>. Такой контроль типов относится к одним из
главных преимуществ обобщений, поскольку он обеспечивает типовую безопасность.

Затем в программе отображается тип переменной ob в объекте iOb — тип System.Int32. 
Это структура .NET, соответствующая типу int. Далее значение переменной ob
получается в следующей строке кода.

int v = iOb.GetOb();

Возвращаемым для метода GetOb() является тип Т, который был заменен на тип
int при объявлении переменной iOb, и поэтому метод GetOb() возвращает значение
того же типа int. Следовательно, данное значение может быть присвоено переменной
v типа int.

Далее в классе GenericsDemo объявляется объект типа Gen<string>.

Gen<string> strOb = new Gen<string>("Обобщения повышают эффективность.");

В этом объявлении указывается аргумент типа string, поэтому в объекте класса Gen
вместо Т подставляется тип string. В итоге создается вариант класса Gen для типа string,
как демонстрируют остальные строки кода рассматриваемой здесь программы.

Прежде чем продолжить изложение, следует дать определение некоторым терминам.
Когда для класса Gen указывается аргумент типа, например int или string, то
создается так называемый в C# закрыто сконструированный тип. В частности, Gen<int>
является закрыто сконструированным типом. Ведь, по существу, такой обобщенный
тип, как Gen<T>, является абстракцией. И только после того, как будет сконструирован
конкретный вариант, например Gen<int>, создается конкретный тип. А конструкция, 
подобная Gen<T>, называется в C# открыто сконструированным типом, поскольку
в ней указывается параметр типа Т, но не такой конкретный тип, как int.

В С# чаще определяются такие понятия, как открытый и закрытый типы. Открытым
типом считается такой параметр типа или любой обобщенный тип, для которого
аргумент типа является параметром типа или же включает его в себя. А любой тип, не
относящийся к открытому, считается закрытым. Сконструированным типом считается
такой обобщенный тип, для которого предоставлены все аргументы типов. Если все
эти аргументы относятся к закрытым типам, то такой тип считается закрыто сконструированным.
А если один или несколько аргументов типа относятся к открытым типам,
то такой тип считается открыто сконструированным.

*/
#endregion

#region English
/*
 18 CHAPTER
Generics

This chapter examines one of C#’s most sophisticated and powerful features: generics.
Interestingly, although generics are now an indispensable part of C# programming,
they were not included in the original 1.0 release. Instead, they were added by C# 2.0.
It is not an overstatement to say that the addition of generics fundamentally changed the
character of C#. Not only did it add a new syntactic element, it also added new capabilities
and resulted in many changes and upgrades to the library. Although it has been a few years
since the inclusion of generics in C#, the effects still reverberate throughout the language.

The generics feature is so important because it enables the creation of classes, structures,
interfaces, methods, and delegates that work in a type-safe manner with various kinds of
data. As you may know, many algorithms are logically the same no matter what type of
data they are being applied to. For example, the mechanism that supports a queue is the
same whether the queue is storing items of type int, string, object, or a user-defined class.
Prior to generics, you might have created several different versions of the same algorithm to
handle different types of data. Through the use of generics, you can define a solution once,
independently of any specific type of data, and then apply that solution to a wide variety of
data types without any additional effort.

This chapter describes the syntax, theory, and use of generics. It also shows how generics
provide type safety for some previously difficult cases. Once you have completed this chapter,
you will want to examine Chapter 25, which covers Collections. There you will find many
examples of generics at work in the generic collection classes.

What Are Generics?

At its core, the term generics means parameterized types. Parameterized types are important
because they enable you to create classes, structures, interfaces, methods, and delegates in
which the type of data upon which they operate is specified as a parameter. Using generics,
it is possible to create a single class, for example, that automatically works with different
types of data. A class, structure, interface, method, or delegate that operates on a parameterized
type is called generic, as in generic class or generic method.

It is important to understand that C# has always given you the ability to create generalized
code by operating through references of type object. Because object is the base class of all
other classes, an object reference can refer to any type of object. Thus, in pre-generics code,
generalized code used object references to operate on a variety of different kinds of objects.
The problem was that it could not do so with type safety because casts were needed to convert
between the object type and the actual type of the data. This was a potential source of errors
because it was possible to accidentally use an incorrect cast. Generics avoid this problem by
providing the type safety that was lacking. Generics also streamline the process because it is
no longer necessary to employ casts to translate between object and the type of data that is
actually being operated upon. Thus, generics expand your ability to re-use code, and let
you do so safely and easily.

NOTE
A Warning to C++ and Java Programmers: Although C# generics are similar to templates
in C++ and generics in Java, they are not the same as either. In fact, there are some fundamental
differences among these three approaches to generics. If you have a background in C++ or Java, it
is important to not jump to conclusions about how generics work in C#.

A Simple Generics Example

Let’s begin with a simple example of a generic class. The following program defines two
classes. The first is the generic class Gen, and the second is GenericsDemo, which uses Gen.
 */

// A simple generic class.  

// using System; 

//// In the following Gen class, T is a type parameter 
//// that will be replaced by a real type when an object 
//// of type Gen is created. 
// class Gen<T>
// {
//    T ob; // declare a variable of type T 

//    // Notice that this constructor has a parameter of type T. 
//    public Gen(T o)
//    {
//        ob = o;
//    }

//    // Return ob, which is of type T. 
//    public T GetOb()
//    {
//        return ob;
//    }

//    // Show type of T. 
//    public void ShowType()
//    {
//        Console.WriteLine("Type of T is " + typeof(T));
//    }
// }

//// Demonstrate the generic class. 
// class GenericsDemo
// {
//    static void Main()
//    {
//        // Create a Gen reference for int. 
//        Gen<int> iOb;

//        // Create a Gen<int> object and assign its reference to iOb. 
//        iOb = new Gen<int>(102);

//        // Show the type of data used by iOb. 
//        iOb.ShowType();

//        // Get the value in iOb. 
//        int v = iOb.GetOb();
//        Console.WriteLine("value: " + v);

//        Console.WriteLine();

//        // Create a Gen object for strings. 
//        Gen<string> strOb = new Gen<string>("Generics add power.");

//        // Show the type of data stored in strOb. 
//        strOb.ShowType();

//        // Get the value in strOb. 
//        string str = strOb.GetOb();
//        Console.WriteLine("value: " + str);
//    }
// }

/*
 The output produced by the program is shown here:

Type of T is System.Int32
value: 102

Type of T is System.String
value: Generics add power.

Let’s examine this program carefully.

First, notice how Gen is declared by the following line.

class Gen<T> {

Here, T is the name of a type parameter. This name is used as a placeholder for the actual
type that will be specified when a Gen object is created. Thus, T is used within Gen whenever
the type parameter is needed. Notice that T is contained within < >. This syntax can be
generalized. Whenever a type parameter is being declared, it is specified within angle brackets.
Because Gen uses a type parameter, Gen is a generic class.

In the declaration of Gen, there is no special significance to the name T. Any valid
identifier could have been used, but T is traditional. Other commonly used type parameter
names include V and E. Of course, you can also use descriptive names for type parameters,
such as TValue or TKey. When using a descriptive name, it is common practice to use T as
the first letter.

Next, T is used to declare a variable called ob, as shown here:

T ob; // declare a variable of type T

As explained, T is a placeholder for the actual type that will be specified when a Gen object
is created. Thus, ob will be a variable of the type bound to T when a Gen object is instantiated.
For example, if type string is specified for T, then in that instance, ob will be of type string.

Now consider Gen’s constructor:

public Gen(T o) {
ob = o;
}

Notice that its parameter, o, is of type T. This means that the actual type of o is determined
by the type bound to T when a Gen object is created. Also, because both the parameter o
and the instance variable ob are of type T, they will both be of the same actual type when a
Gen object is created.

The type parameter T can also be used to specify the return type of a method, as is the
case with the GetOb( ) method, shown here:

public T GetOb() {
return ob;
}

Because ob is also of type T, its type is compatible with the return type specified by GetOb( ).

The ShowType( ) method displays the type of T by passing T to the typeof operator.
Because a real type will be substituted for T when an object of type Gen is created, typeof
will obtain type information about the actual type.

The GenericsDemo class demonstrates the generic Gen class. It first creates a version of
Gen for type int, as shown here:

Gen<int> iOb;

Look closely at this declaration. First, notice that the type int is specified within the angle
brackets after Gen. In this case, int is a type argument that is bound to Gen’s type parameter,
T. This creates a version of Gen in which all uses of T are replaced by int. Thus, for this
declaration, ob is of type int, and the return type of GetOb( ) is of type int.

The next line assigns to iOb a reference to an instance of an int version of the Gen class: 

iOb = new Gen<int>(102);    
                          
Notice that when the Gen constructor is called, the type argument int is also specified. This
is necessary because the type of the variable (in this case iOb) to which the reference is being
assigned is of type Gen<int>. Thus, the reference returned by new must also be of type
Gen<int>. If it isn’t, a compile-time error will result. For example, the following assignment
will cause a compile-time error:

iOb = new Gen<double>(118.12); // Error!

Because iOb is of type Gen<int>, it can’t be used to refer to an object of Gen<double>. This
type checking is one of the main benefits of generics because it ensures type safety.

The program then displays the type of ob within iOb, which is System.Int32. This is the
.NET structure that corresponds to int. Next, the program obtains the value of ob by use of
the following line:

int v = iOb.GetOb();

Because the return type of GetOb( ) is T, which was replaced by int when iOb was declared,
the return type of GetOb( ) is also int. Thus, this value can be assigned to an int variable.

Next, GenericsDemo declares an object of type Gen<string>:

Gen<string> strOb = new Gen<string>("Generics add power.");

Because the type argument is string, string is substituted for T inside Gen. This creates a
string version of Gen, as the remaining lines in the program demonstrate.

Before moving on, a few terms need to be defined. When you specify a type argument
such as int or string for Gen, you are creating what is referred to in C# as a closed constructed
type. Thus, Gen<int> is a closed constructed type. In essence, a generic type, such as
Gen<T>, is an abstraction. It is only after a specific version, such as Gen<int>, has been
constructed that a concrete type has been created. In C# terminology, a construct such as
Gen<T> is called an open constructed type, because the type parameter T (rather than an
actual type, such as int) is specified.

More generally, C# defines the concepts of an open type and a closed type. An open type is
a type parameter or any generic type whose type argument is (or involves) a type parameter.
Any type that is not an open type is a closed type. A constructed type is a generic type for
which all type arguments have been supplied. If those type arguments are all closed types,
then it is a closed constructed type. If one or more of those type arguments are open types,
it is an open constructed type.
 */
#endregion