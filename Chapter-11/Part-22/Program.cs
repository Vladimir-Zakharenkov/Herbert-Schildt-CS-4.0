#region Russian

// Класс object

// В C# предусмотрен специальный класс object, который неявно считается базовым
// классом для всех остальных классов и типов, включая и типы значений. Иными словами,
// все остальные типы являются производными от object. Это, в частности, означает,
// что переменная ссылочного типа object может ссылаться на объект любого другого
// типа. Кроме того, переменная типа object может ссылаться на любой массив, поскольку
// в C# массивы реализуются как объекты. Формально имя object считается в
// C# еще одним обозначением класса System.Object, входящего в библиотеку классов
// для среды .NET Framework.

// В классе object определяются методы, приведенные в табл. 11.1. Это означает, что
// они доступны для каждого объекта.

// Некоторые из этих методов требуют дополнительных пояснений. По умолчанию
// метод Equals(object) определяет, ссылается ли вызывающий объект на тот же самый
// объект, что и объект, указываемый в качества аргумента этого метода, т.е. он определяет,
// являются ли обе ссылки одинаковыми. Метод Equals(object) возвращает
// логическое значение true, если сравниваемые объекты одинаковы, в противном случае
// — логическое значение false. Он может быть также переопределен в создаваемых
// классах. Это позволяет выяснить, что же означает равенство объектов для создаваемого
// класса. Например, метод Equals(object) можно определить таким образом, чтобы
// в нем сравнивалось содержимое двух объектов.

// Таблица 11.1. Методы класса object

// Метод                                                    Назначение

// public virtual bool Equals(object ob)                    Определяет, является ли вызывающий объект таким же,
//                                                          как и объект, доступный по ссылке ob

// public static bool Equals(object objA, object objB)      Определяет, является ли объект, доступный по ссылке
//                                                          objA, таким же, как и объект, доступный по ссылке objB

// protected Finalize()                                     Выполняет завершающие действия перед "сборкой мусора”.
//                                                          В C# метод Finalize() доступен посредством деструктора

//public virtual intGetHashCode()                           Возвращает хеш-код, связанный с вызывающим объектом

// public Type GetType()                                    Получает тип объекта во время выполнения программы

// protected object MemberwiseClone()                       Выполняет неполное копирование объекта, т.е. копируются
//                                                          только члены, но не объекты, на которые ссылаются эти члены

// public static bool ReferenceEquals(obj objA, object objB)Определяет, делаются ли ссылки objA и objB на один
//                                                          и тот же объект

// public virtual string ToString()                         Возвращает строку, которая описывает объект

// Метод GetHashCode() возвращает хеш-код, связанный с вызывающим объектом.
// Этот хеш-код можно затем использовать в любом алгоритме, где хеширование применяется
// в качестве средства доступа к хранимым объектам. Следует, однако, иметь в
// виду, что стандартная реализация метода GetHashCode() не пригодна на все случаи
// применения.

// Как упоминалось в главе 9, если перегружается оператор ==, то обычно приходится
// переопределять методы Equals(object) и GetHashCode(), поскольку чаще всего
// требуется, чтобы метод Equals(object) и оператор == функционировали одинаково.
// Когда же переопределяется метод Equals(object), то следует переопределить и метод
// GetHashCode(), чтобы оба метода оказались совместимыми.

// Метод ToString() возвращает символьную строку, содержащую описание того
// объекта, для которого он вызывается. Кроме того, метод ToString() автоматически
// вызывается при выводе содержимого объекта с помощью метода WriteLine(). Этот
// метод переопределяется во многих классах, что позволяет приспосабливать описание
// к конкретным типам объектов, создаваемых в этих классах. Ниже приведен пример
// применения данного метода.

//Продемонстрировать применение метода ToString()
using System;

class MyClass
{
    static int count = 0;
    int id;

    public MyClass()
    {
        id = count;
        count++;
    }

    public override string ToString()
    {
        return "Объект #" + id + " типа MyClass";
    }
}

class Test
{
    static void Main()
    {
        MyClass ob1 = new MyClass();
        MyClass ob2 = new MyClass();
        MyClass ob3 = new MyClass();

        Console.WriteLine(ob1);
        Console.WriteLine(ob2);
        Console.WriteLine(ob3);

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этого кода получается следующий результат.

// Объект #0 типа MyClass
// Объект #1 типа MyClass
// Объект #2 типа MyClass

#endregion

#region English

// The object Class

// C# defines one special class called object that is an implicit base class of all other classes and
// for all other types (including the value types). In other words, all other types are derived
// from object. This means that a reference variable of type object can refer to an object of any
// other type. Also, since arrays are implemented as objects, a variable of type object can also
// refer to any array.Technically, the C# name object is just another name for System.Object,
// which is part of the.NET Framework class library.

// The object class defines the methods shown in Table 11-1, which means that they are
// available in every object.

// A few of these methods warrant some additional explanation. By default, the Equals(object)
// method determines if the invoking object refers to the same object as the one referred to by
// the argument. (That is, it determines if the two references are the same.) It returns true if the
// objects are the same, and false otherwise. You can override this method in classes that you
// create. Doing so allows you to define what equality means relative to a class. For example,
// you could define Equals(object) so that it compares the contents of two objects for equality.

// The GetHashCode() method returns a hash code associated with the invoking object. A
// hash code is needed by any algorithm that employs hashing as a means of accessing stored
// objects. It is important to understand that the default implementation of GetHashCode()
// will not be adequate for all uses.

// As mentioned in Chapter 9, if you overload the = = operator, then you will usually need
// to override Equals(object) and GetHashCode() because most of the time you will want
// the = = operator and the Equals(object) methods to function the same. When Equals()
// is overridden, you often need to override GetHashCode( ), so that the two methods are
// compatible.

// Method                                                    Purpose

// public virtual bool Equals(object ob)                    Determines whether the invoking object is the
//                                                          same as the one referred to by obj.

// public static bool Equals(object objA, object objB)      Determines whether objA is the same as objB.

// protected Finalize()                                     Performs shutdown actions prior to garbage  collection.
//                                                          In C#, Finalize( ) is accessed through a destructor.

//public virtual intGetHashCode()                           Returns the hash code associated with the invoking object.

// public Type GetType()                                    Obtains the type of an object at runtime.

// protected object MemberwiseClone()                       Makes a “shallow copy” of the object. This
//                                                          is one in which the members are copied, but
//                                                          objects referred to by members are not.

// public static bool ReferenceEquals(obj objA, object objB)Determines whether objA and objB refer to the
//                                                          same object.

// public virtual string ToString()                         Returns a string that describes the object.



// The ToString() method returns a string that contains a description of the object on
// which it is called. Also, this method is automatically called when an object is output using
// WriteLine().Many classes override this method.Doing so allows them to tailor a
// description specifically for the types of objects that they create.For example:

// Demonstrate ToString() 

// using System; 

// class MyClass
// {
//    static int count = 0;
//    int id;

//    public MyClass()
//    {
//        id = count;
//        count++;
//    }

//    public override string ToString()
//    {
//        return "MyClass object #" + id;
//    }
// }

// class Test
// {
//    static void Main()
//    {
//        MyClass ob1 = new MyClass();
//        MyClass ob2 = new MyClass();
//        MyClass ob3 = new MyClass();

//        Console.WriteLine(ob1);
//        Console.WriteLine(ob2);
//        Console.WriteLine(ob3);
//    }
// }

// The output from the program is shown here:

// MyClass object #0
// MyClass object #1
// MyClass object #2

#endregion