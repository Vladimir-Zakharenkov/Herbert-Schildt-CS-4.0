#region Russian

// Упаковка и распаковка позволяют полностью унифицировать систему типов в С#.
// Благодаря тому что все типы являются производными от класса object, ссылка на
// значение любого типа может быть просто присвоена переменной ссылочного типа
// object, а все остальное возьмут на себя упаковка и распаковка. Более того, методы
// класса object оказываются доступными всем типам, поскольку они являются производными
// от этого класса. В качестве примера рассмотрим довольно любопытную программу.

// Благодаря упаковке становится возможным вызов методов по значению!
using System;

class MethOnValue
{
    static void Main()
    {
        Console.WriteLine(10.ToString());

        //Задержка программы.
        Console.ReadKey();
    }
}

// В результате выполнения этой программы выводится значение 10. Дело в том, что
// метод ToString() возвращает строковое представление объекта, для которого он вызывается.
// В данном случае строковым представлением значения 10 как вызывающего
// объекта является само значение 10!

#endregion

#region English

// Boxing and unboxing allow C#’s type system to be fully unified. All types derive from
// object. A reference to any type can be assigned to a variable of type object. Boxing and
// unboxing automatically handle the details for the value types. Furthermore, because all
// types are derived from object, they all have access to object’s methods. For example,
// consider the following rather surprising program:

// Boxing makes it possible to call methods on a value! 

// using System; 

// class MethOnValue
// {
//    static void Main()
//    {

//        Console.WriteLine(10.ToString());

//    }
// }

// This program displays 10. The reason is that the ToString( ) method returns a string
// representation of the object on which it is called. In this case, the string representation
// of 10 is 10!

#endregion