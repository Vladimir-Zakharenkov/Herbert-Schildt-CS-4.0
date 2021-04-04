#region Russian

//11 ГЛАВА

//Наследование

// Наследование является одним из трех основополагающих принципов объектно-ориентированного программирования,
// поскольку оно допускает создание иерархических классификаций. Благодаря наследованию
// можно создать общий класс, в котором определяются характерные особенности, присущие множеству связанных
// элементов. От этого класса могут затем наследовать другие, более конкретные классы, добавляя в него свои
// индивидуальные особенности.

// В языке C# класс, который наследуется, называется базовым, а класс, который наследует, — производным.
// Следовательно, производный класс представляет собой специализированный вариант базового класса. Он наследует
// все переменные, методы, свойства и индексаторы, определяемые в базовом классе, добавляя к ним свои собственные
// элементы.

// Основы наследования

// Поддержка наследования в C# состоит в том, что в объявление одного класса разрешается вводить другой класс. Для
// этого при объявлении производного класса указывается базовый класс. Рассмотрим для начала простой пример.
// Ниже приведен класс TwoDShape, содержащий ширину и высоту двухмерного объекта, например квадрата, прямоугольника,
// треугольника и т.д.

// Класс для двумерных объектов.
// class TwoDShape
// {
//    public double Width;
//    public double Height;

//    public void ShowDim()
//    {
//        System.Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
//    }
// }

// Класс TwoDShape может стать базовым, т.е. отправной точкой для создания классов,
// описывающих конкретные типы двумерных объектов. Например, в приведенной ниже
// программе класс TwoDShape служит для порождения производного класса Triangle.
// Обратите особое внимание на объявление класса Triangle.

//Пример простой иерархии классов.
using System;

//Класс для двумерных объектов.
class TwoDShape
{
    public double Width;
    public double Height;

    public void ShowDim()
    {
        System.Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
    }
}

//Класс Triangle, производный от класса TwoDShape.
class Triangle : TwoDShape
{
    public string Style; //тип треугольника

    //Возвратить площадь треугольника.
    public double Area()
    {
        return Width * Height / 2;
    }

    //Показать тип треугольника.
    public void ShowStyle()
    {
        Console.WriteLine("Треугольник: " + Style);
    }
}

class Shapes
{
    static void Main()
    {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle();

        t1.Width = 4.0;
        t1.Height = 4.0;
        t1.Style = "равнобедренный";

        t2.Width = 8.0;
        t2.Height = 12.0;
        t2.Style = "прямоугольный";

        Console.WriteLine("Сведения об объекте t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Площадь равна " + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Сведения об объекте t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Площадь равна " + t2.Area());

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// Сведения об объекте t1:
// Треугольник равнобедренный
// Ширина и высота равны 4 и 4
// Площадь равна 8

// Сведения об объекте t2:
// Треугольник прямоугольный
// Ширина и высота равны 8 и 12
// Площадь равна 48

// В классе Triangle создается особый тип объекта класса TwoDShape (в данном случае
// — треугольник). Кроме того, в класс Triangle входят все члены класса TwoDShape,
// к которым, в частности, добавляются методы Area() и ShowStyle(). Так, описание
// типа треугольника сохраняется в переменной Style, метод Area() рассчитывает и возвращает
// площадь треугольника, а метод ShowStyle() отображает тип треугольника.

// Обратите внимание на синтаксис, используемый в классе Triangle для наследования
// класса TwoDShape.

// class Triangle : TwoDShape
// {

// Этот синтаксис может быть обобщен. Всякий раз, когда один класс наследует от
// другого, после имени базового класса указывается имя производного класса, отделяемое
// двоеточием. В C# синтаксис наследования класса удивительно прост и удобен в использовании.

// В класс Triangle входят все члены его базового класса TwoDShape, и поэтому
// в нем переменные Width и Height доступны для метода Area(). Кроме того, объекты
// t1 и t2 в методе Main() могут обращаться непосредственно к переменным Width и
// Height, как будто они являются членами класса Triangle.

// Несмотря на то что класс TwoDShape является базовым для класса Triangle, в то
// же время он представляет собой совершенно независимый и самодостаточный класс.
// Если класс служит базовым для производного класса, то это совсем не означает, что он
// не может быть использован самостоятельно. Например, следующий фрагмент кода
// считается вполне допустимым.

// TwoDShape shape = new TwoDShape();
// shape.Width = 10;
// shape.Height = 20;
// shape.ShowDim();

// Разумеется, объект класса TwoDShape никак не связан с любым из классов, производных
// от класса TwoDShape, и вообще не имеет к ним доступа.

// Ниже приведена общая форма объявления класса, наследующего от базового класса.

// class имя_производного_класса : имя_базового_класса
// {
//    // тело класса
// }

#endregion

#region English

// 11 CHAPTER

//Inheritance

// Inheritance is one of the three foundational principles of object-oriented programming
// because it allows the creation of hierarchical classifications. Using inheritance, you can
// create a general class that defines traits common to a set of related items. This class can
// then be inherited by other, more specific classes, each adding those things that are unique
// to it.

// In the language of C#, a class that is inherited is called a base class. The class that does
// the inheriting is called a derived class. Therefore, a derived class is a specialized version of a
// base class. It inherits all of the variables, methods, properties, and indexers defined by the
// base class and adds its own unique elements.

// Inheritance Basics

// C# supports inheritance by allowing one class to incorporate another class into its declaration.
// This is done by specifying a base class when a derived class is declared. Let’s begin with
// an example. The following class called TwoDShape stores the width and height of a twodimensional
// object, such as a square, rectangle, triangle, and so on.

// A class for two-dimensional objects.
// class TwoDShape
// {
//    public double Width;
//    public double Height;

//    public void ShowDim()
//    {
//        System.Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
//    }
// }

// TwoDShape can be used as a base class (that is, as a starting point) for classes that
// describe specific types of two - dimensional objects.For example, the following program uses
// TwoDShape to derive a class called Triangle.Pay close attention to the way that Triangle is
// declared.

// / A simple class hierarchy. 

// using System; 

// // A class for two-dimensional objects. 
// class TwoDShape
// {
//    public double Width;
//    public double Height;

//    public void ShowDim()
//    {
//        Console.WriteLine("Width and height are " +
//                           Width + " and " + Height);
//    }
// }

// // Triangle is derived from TwoDShape. 
// class Triangle : TwoDShape
// {
//    public string Style; // style of triangle 

//    // Return area of triangle. 
//    public double Area()
//    {
//        return Width * Height / 2;
//    }

//    // Display a triangle's style. 
//    public void ShowStyle()
//    {
//        Console.WriteLine("Triangle is " + Style);
//    }
// }

// class Shapes
// {
//    static void Main()
//    {
//        Triangle t1 = new Triangle();
//        Triangle t2 = new Triangle();

//        t1.Width = 4.0;
//        t1.Height = 4.0;
//        t1.Style = "isosceles";

//        t2.Width = 8.0;
//        t2.Height = 12.0;
//        t2.Style = "right";

//        Console.WriteLine("Info for t1: ");
//        t1.ShowStyle();
//        t1.ShowDim();
//        Console.WriteLine("Area is " + t1.Area());

//        Console.WriteLine();

//        Console.WriteLine("Info for t2: ");
//        t2.ShowStyle();
//        t2.ShowDim();
//        Console.WriteLine("Area is " + t2.Area());
//    }
// }

// The output from this program is shown here:

// Info for t1:
// Triangle is isosceles
// Width and height are 4 and 4
// Area is 8

// Info for t2:
// Triangle is right
// Width and height are 8 and 12
// Area is 48

// The Triangle class creates a specific type of TwoDShape, in this case, a triangle. The
// Triangle class includes all of TwoDShape and adds the field Style, the method Area( ), and
// the method ShowStyle( ). A description of the type of triangle is stored in Style; Area()
// computes and returns the area of the triangle; and ShowStyle() displays the triangle style.

// Notice the syntax that Triangle uses to inherit TwoDShape:

// class Triangle : TwoDShape
// {

// This syntax can be generalized.Whenever one class inherits another, the base class name
// follows the name of the derived class, separated by a colon.In C#, the syntax for inheriting
// a class is remarkably simple and easy to use.

// Because Triangle includes all of the members of its base class, TwoDShape, it can access
// Width and Height inside Area(). Also, inside Main(), objects t1 and t2 can refer to Width
// and Height directly, as if they were part of Triangle. Figure 11-1 depicts conceptually how
// TwoDShape is incorporated into Triangle.

// Even though TwoDShape is a base for Triangle, it is also a completely independent,
// stand-alone class. Being a base class for a derived class does not mean that the base class
// cannot be used by itself. For example, the following is perfectly valid:

// TwoDShape shape = new TwoDShape();
// shape.Width = 10;
// shape.Height = 20;
// shape.ShowDim();

// Of course, an object of TwoDShape has no knowledge of or access to any classes derived
// from TwoDShape.

// The general form of a class declaration that inherits a base class is shown here:

// class derived-class-name : base -class-name {
//    // body of class
// }

#endregion