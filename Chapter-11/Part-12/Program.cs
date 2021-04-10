#region Russian

// Порядок вызова конструкторов

// В связи с изложенными выше в отношении наследования и иерархии классов может
// возникнуть следующий резонный вопрос: когда создается объект производного
// класса и какой конструктор выполняется первым — тот, что определен в производном
// классе, или же тот, что определен в базовом классе? Так, если имеется базовый класс А
// и производный класс В, то вызывается ли конструктор класса А раньше конструктора
// класса В? Ответ на этот вопрос состоит в том, что в иерархии классов конструкторы вызываются
// по порядку выведения классов: от базового к производному. Более того, этот
// порядок остается неизменным независимо от использования ключевого слова base.
// Так, если ключевое слово base не используется, то выполняется конструктор по умолчанию,
// т.е. конструктор без параметров. В приведенном ниже примере программы
// демонстрируется порядок вызова и выполнения конструкторов.

//Продемонстрировать порядок вызова конструкторов.
using System;

//Создать базовый класс.
class A
{
    public A()
    {
        Console.WriteLine("Конструирование класса А.");
    }
}

//Создать класс, производный от класса A.
class B : A
{
    public B()
    {
        Console.WriteLine("Конструирование класса B.");
    }
}

//Создать класс, производный от класса B.
class C : B
{
    public C()
    {
        Console.WriteLine("Конструирование класса C.");
    }
}

class OrderOfCConstruction
{
    static void Main()
    {
        C c = new C();

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этой программы.

// Конструирование класса А.
// Конструирование класса В.
// Конструирование класса С.

// Как видите, конструкторы вызываются по порядку выведения их классов.

// Если хорошенько подумать, то в вызове конструкторов по порядку выведения их
// классов можно обнаружить определенный смысл. Ведь базовому классу ничего неизвестно
// ни об одном из производных от него классов, и поэтому любая инициализация,
// которая требуется его членам, осуществляется совершенно отдельно от инициализации
// членов производного класса, а возможно, это и необходимое условие. Следовательно,
// она должна выполняться первой.

#endregion

#region English

// When Are Constructors Called?

// In the foregoing discussion of inheritance and class hierarchies, an important question may
// have occurred to you: When a derived class object is created, whose constructor is executed
// first? The one in the derived class or the one defined by the base class? For example, given a
// derived class called B and a base class called A, is A’s constructor called before B’s, or vice
// versa? The answer is that in a class hierarchy, constructors are called in order of derivation,
// from base class to derived class. Furthermore, this order is the same whether or not base is
// used. If base is not used, then the default (parameterless) constructor of each base class will
// be executed.The following program illustrates the order of constructor execution:

// Demonstrate when constructors are called. 

// using System; 

// // Create a base class. 
// class A
// {
//    public A()
//    {
//        Console.WriteLine("Constructing A.");
//    }
// }

// // Create a class derived from A. 
// class B : A
// {
//    public B()
//    {
//        Console.WriteLine("Constructing B.");
//    }
// }

// // Create a class derived from B. 
// class C : B
// {
//    public C()
//    {
//        Console.WriteLine("Constructing C.");
//    }
// }

// class OrderOfConstruction
// {
//    static void Main()
//    {
//        C c = new C();
//    }
// }

// The output from this program is shown here:

// Constructing A.
// Constructing B.
// Constructing C.

// As you can see, the constructors are called in order of derivation.

// If you think about it, it makes sense that constructors are executed in order of derivation.
// Because a base class has no knowledge of any derived class, any initialization it needs to
// perform is separate from and possibly prerequisite to any initialization performed by the
// derived class. Therefore, it must be executed first.

#endregion