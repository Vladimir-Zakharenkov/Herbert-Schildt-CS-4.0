#region Russian

// Предотвращение наследования с помощью ключевого слова sealed

// Несмотря на всю эффективность и полезность наследования, иногда возникает потребность
// предотвратить его. Допустим, что имеется класс, инкапсулирующий последовательность
// инициализации некоторого специального оборудования, например
// медицинского монитора. В этом случае требуется, чтобы пользователи данного класса
// не могли изменять порядок инициализации монитора, чтобы исключить его неправильную
// настройку. Но независимо от конкретных причин в C# имеется возможность
// предотвратить наследование класса с помощью ключевого слова sealed.

// Для того чтобы предотвратить наследование класса, достаточно указать ключевое
// слово sealed перед определением класса.Как и следовало ожидать, класс не допускается
// объявлять одновременно как abstract и sealed, поскольку сам абстрактный
// класс реализован не полностью и опирается в этом отношении на свои производные
// классы, обеспечивающие полную реализацию.

// Ниже приведен пример объявления класса типа sealed.

// sealed class А
// {
//    // ...
// }

// Следующий класс недопустим.

// class В : A{ // ОШИБКА! Наследовать класс А нельзя
// ...
// }

// Как следует из комментариев в приведенном выше фрагменте кода, класс В не может
// наследовать класс А, потому что последний объявлен как sealed.

// И еще одно замечание: ключевое слово sealed может быть также использовано
// в виртуальных методах для предотвращения их дальнейшего переопределения. Допустим,
// что имеется базовый класс В и производный класс D. Метод, объявленный
// в классе В как virtual, может быть объявлен в классе D как sealed. Благодаря этому
// в любом классе, наследующем от класса предотвращается переопределение данного
// метода. Подобная ситуация демонстрируется в приведенном ниже фрагменте кода.

class B
{
    public virtual void MyMethod()
    {

    }
}

class D : B
{
    //Здесь герметизируется метод MyMethod() и предотвращается его дальнейшее переопределение.
    public sealed override void MyMethod()
    {
        
    }
}

class X : D
{
    //Ошибка! Метод MyMethod() герметизирован!
    public override void MyMethod()
    {

    }
}

// Метод MyMethod() герметизирован в классе D, и поэтому не может быть переопределен
// в классе X.

#endregion

#region English

// Using sealed to Prevent Inheritance

// As powerful and useful as inheritance is, sometimes you will want to prevent it. For
// example, you might have a class that encapsulates the initialization sequence of some
// specialized hardware device, such as a medical monitor. In this case, you don’t want users
// of your class to be able to change the way the monitor is initialized, possibly setting the
// device incorrectly. Whatever the reason, in C# it is easy to prevent a class from being
// inherited by using the keyword sealed.

// To prevent a class from being inherited, precede its declaration with sealed. As you
// might expect, it is illegal to declare a class as both abstract and sealed because an abstract
// class is incomplete by itself and relies upon its derived classes to provide complete
// implementations.

// Here is an example of a sealed class:

// sealed class A
// {
//    // ...
// }
// // The following class is illegal.
// class B : A
// { // ERROR! Can't derive from class A
//  // ...
// }

// As the comments imply, it is illegal for B to inherit A because A is declared as sealed.

// One other point: sealed can also be used on virtual methods to prevent further
// overrrides. For example, assume a base class called B and a derived class called D.A
// method declared virtual in B can be declared sealed by D.This would prevent any class
// that inherits D from overriding the method. This situation is illustrated by the following:

// class B
// {
//    public virtual void MyMethod() { /* ... */ }
// }

// lass D : B
// {
//    // This seals MyMethod() and prevents further overrides. 
//    sealed public override void MyMethod() { /* ... */ }
// }

// class X : D
// {
//    // Error! MyMethod() is sealed! 
//    public override void MyMethod() { /* ... */ }
// }

// Because MyMethod() is sealed by D, it can’t be overridden by X.

#endregion