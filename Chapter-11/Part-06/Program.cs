#region Russian

// Вызов конструкторов базового класса

// С помощью формы расширенного объявления конструктора производного класса
// и ключевого слова base в производном классе может быть вызван конструктор, определенный
// в его базовом классе. Ниже приведена общая форма этого расширенного
// объявления:

// конструктор_производного_класса(список_параметров) : base(список_аргументов) {
//    // тело конструктора
//  }

//  где список_аргументов обозначает любые аргументы, необходимые конструктору
//  в базовом классе. Обратите внимание на местоположение двоеточия.

//  Для того чтобы продемонстрировать применение ключевого слова base на конкретном
//  примере, рассмотрим еще один вариант класса TwoDShape в приведенной
//  ниже программе. В данном примере определяется конструктор, инициализирующий
//  свойства Width и Height. Затем этот конструктор вызывается конструктором класса
//  Triangle.

//Добавить конструктор в класс TwoDShape.
using System;

//Класс для двумерных объектов.
class TwoDShape
{
    double pri_width;
    double pri_height;

    //Конструктор класса TwoDShape.
    public TwoDShape(double w, double h)
    {
        Width = w;
        Height = h;
    }

    //Свойства ширины и высоты объекта.
    public double Width
    {
        get
        {
            return pri_width;
        }
        set
        {
            pri_width = value < 0 ? -value : value;
        }
    }

    public double Height
    {
        get
        {
            return pri_height;
        }
        set
        {
            pri_height = value < 0 ? -value : value;
        }
    }

    public void ShowDim()
    {
        Console.WriteLine("Ширина и длина равны " + Width + " и " + Height);
    }

}

//Класс для треугольников, производный от класса TwoDShape.
class Triangle : TwoDShape
{
    string Style;

    //Вызвать конструктор базового класса.
    public Triangle(string s, double w, double h) : base(w, h)
    {
        Style = s;
    }

    //Возвратить площадь треугольника.
    public double Area()
    {
        return Width * Height / 2;
    }

    //Показать тип треугольника.
    public void ShowStyle()
    {
        Console.WriteLine("Треугольник " + Style);
    }
}

class Shape3
{
    static void Main()
    {
        Triangle t1 = new Triangle("равнобедренный", 4.0, 4.0);
        Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);

        Console.WriteLine("Сведения об объекте t1:");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Площадь равна " + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Сведения об объекте t2:");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Площадь равна " + t2.Area());

        //Задержка программы.
        Console.ReadKey();
    }
}

// Теперь конструктор класса Triangle объявляется следующим образом.

// public Triangle(
// string s, double w, double h) : base(w, h) {

// В данном варианте конструктор Triangle() вызывает метод base с параметрами
// w и h. Это, в свою очередь, приводит к вызову конструктора TwoDShape(), инициализирующего
// свойства Width и Height значениями параметров w и h. Они больше
// не инициализируются средствами самого класса Triangle, где теперь остается инициализировать
// только его собственный член Style, определяющий тип треугольника.
// Благодаря этому класс TwoDShape высвобождается для конструирования своего подобъекта
// любым избранным способом. Более того, в класс TwoDShape можно ввести
// функции, о которых даже не будут подозревать производные классы, что предотвращает
// нарушение существующего кода.

#endregion

#region English

// Calling Base Class Constructors

// A derived class can call a constructor defined in its base class by using an expanded form
// of the derived class’ constructor declaration and the base keyword. The general form of this
// expanded declaration is shown here:

// derived - constructor(parameter - list) : base(arg - list) {
//    // body of constructor
// }

// Here, arg - list specifies any arguments needed by the constructor in the base class. Notice the
// placement of the colon.

// To see how base is used, consider the version of TwoDShape in the following program.
// It defines a constructor that initializes the Width and Height properties. This constructor is
// then called by the Triangle constructor.


// // Add constructor to TwoDShape. 

// using System; 

// // A class for two-dimensional objects. 
// class TwoDShape
// {
//    double pri_width;
//    double pri_height;

//    // Constructor for TwoDShape. 
//    public TwoDShape(double w, double h)
//    {
//        Width = w;
//        Height = h;
//    }

//    // Properties for Width and Height. 
//    public double Width
//    {
//        get { return pri_width; }
//        set { pri_width = value < 0 ? -value : value; }
//    }

//    public double Height
//    {
//        get { return pri_height; }
//        set { pri_height = value < 0 ? -value : value; }
//    }

//    public void ShowDim()
//    {
//        Console.WriteLine("Width and height are " +
//                           Width + " and " + Height);
//    }
// }

// // A derived class of TwoDShape for triangles. 
// class Triangle : TwoDShape
// {
//    string Style;

//    // Call the base class constructor. 
//    public Triangle(string s, double w, double h) : base(w, h)
//    {
//        Style = s;
//    }

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

// class Shapes4
// {
//    static void Main()
//    {
//        Triangle t1 = new Triangle("isosceles", 4.0, 4.0);
//        Triangle t2 = new Triangle("right", 8.0, 12.0);

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

// Notice that the Triangle constructor is now declared as shown here.

// public Triangle(string s, double w, double h) : base(w, h) {

// In this version, Triangle() calls base with the parameters w and h. This causes the
// TwoDShape() constructor to be called, which initializes Width and Height using these
// values.Triangle no longer initializes these values itself.It need only initialize the value
// unique to it: Style.This leaves TwoDShape free to construct its subobject in any manner
// that it chooses.Furthermore, TwoDShape can add functionality about which existing
// derived classes have no knowledge, thus preventing existing code from breaking.

#endregion