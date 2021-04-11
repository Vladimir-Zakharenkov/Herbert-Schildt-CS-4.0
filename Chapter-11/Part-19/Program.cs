#region Russian

// Применение виртуальных методов

// Для того чтобы стали понятнее преимущества виртуальных методов, применим их
// в классе TwoDShape. В предыдущих примерах в каждом классе, производном от класса
// TwoDShape, определялся метод Area(). Но, по - видимому, метод Area() лучше было
// бы сделать виртуальным в классе TwoDShape и тем самым предоставить возможность
// переопределить его в каждом производном классе с учетом особенностей расчета площади
// той двумерной формы, которую инкапсулирует этот класс. Именно это и сделано
// в приведенном ниже примере программы. Ради удобства демонстрации классов в
// этой программе введено также свойство name в классе TwoDShape.

//Применить виртуальные методы и полиморфизм.
using System;

class TwoDShape
{
    double pri_width;
    double pri_height;

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

    public string name { get; set; }

    //Конструктор по умолчанию.
    public TwoDShape()
    {
        Width = Height = 0.0;
    }

    //Параметризированный конструктор.
    public TwoDShape(double w, double h, string n)
    {
        Width = w;
        Height = h;
        name = n;
    }

    //Сконструировать объект равной ширины и высоты.
    public TwoDShape(double x, string n)
    {
        Width = Height = x;
        name = n;
    }

    //Сконструировать копию объекта TwoDShape.
    public TwoDShape(TwoDShape ob)
    {
        Width = ob.Width;
        Height = ob.Height;
        name = ob.name;
    }

    public void ShowDim()
    {
        Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
    }

    public virtual double Area()
    {
        Console.WriteLine("Метод Area() должен быть переопределен");
        return 0.0;
    }
}

//Класс для треугольников, производный от класса TwoDShape.
class Triangle : TwoDShape
{
    string Style;

    //Конструктор, используемый по умолчанию.
    public Triangle()
    {
        Style = null;
    }

    //Конструктор для класса Triangle.
    public Triangle(string s, double w, double h) : base(w, h, "треугольник")
    {
        Style = s;
    }

    //Сконструировать равнобедренный треугольник.
    public Triangle(double x) : base(x, "треугольник")
    {
        Style = "равнобедренный";
    }

    //Сконструировать копию объекта типа Triangle.
    public Triangle(Triangle ob) : base(ob)
    {
        Style = ob.Style;
    }

    //Переопределить метод Area() для класса Triangle.
    public override double Area()
    {
        return Width * Height / 2;
    }

    //Показать тип треугольника.
    public void ShowStyle()
    {
        Console.WriteLine("Треугольник " + Style);
    }
}

//Класс для прямоугольников, производный от класса TwoDShape.
class Rectangle : TwoDShape
{
    //Конструктор для класса Rectangle.
    public Rectangle(double w, double h) : base(w, h, "прямоугольник")
    {

    }

    //Сконструировать квадрат.
    public Rectangle(double x) : base(x, "квадрат")
    {

    }

    //Сконструировать копию объекта Rectangle.
    public Rectangle(Rectangle ob) : base(ob)
    {

    }

    //Возвратить логическое значение true, если прямоугольник окажется квадратом.
    public bool IsSquare()
    {
        if (Width == Height)
        {
            return true;
        }

        return false;
    }

    //Переопределить метод Area() для класса Rectangle.
    public override double Area()
    {
        return Width * Height;
    }
}

class DynShapes
{
    static void Main()
    {
        TwoDShape[] shapes = new TwoDShape[5];

        shapes[0] = new Triangle("прямоугольный", 8.0, 12.0);
        shapes[1] = new Rectangle(10);
        shapes[2] = new Rectangle(10, 4);
        shapes[3] = new Triangle(7.0);
        shapes[4] = new TwoDShape(10, 20, "общая форма");

        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine("Объект - " + shapes[i].name);
            Console.WriteLine("Площадь равна " + shapes[i].Area());

            Console.WriteLine();
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// Объект — треугольник
// Площадь равна 48

// Объект — прямоугольник
// Площадь равна 100

// Объект — прямоугольник
// Площадь равна 40

// Объект — треугольник
// Площадь равна 24.5

// Объект — общая форма
// Метод Area() должен быть переопределен
// Площадь равна 0

// Рассмотрим данный пример программы более подробно. Прежде всего, метод
// Area() объявляется как virtual в классе TwoDShape и переопределяется в классах
// Triangle и Rectangle по объяснявшимся ранее причинам. В классе TwoDShape метод
// Area() реализован в виде заполнителя, который сообщает о том, что пользователь
// данного метода должен переопределить его в производном классе. Каждое переопределение
// метода Area() предоставляет конкретную его реализацию, соответствующую
// типу объекта, инкапсулируемого в производном классе. Так, если реализовать класс
// для эллипсов, то метод Area() должен вычислять площадь эллипса.

// У программы из рассматриваемого здесь примера имеется еще одна примечательная
// особенность. Обратите внимание на то, что в методе Main() двумерные формы
// объявляются в виде массива объектов типа TwoDShape, но элементам этого массива
// присваиваются ссылки на объекты классов Triangle, Rectangle и TwoDShape. И это
// вполне допустимо, поскольку по ссылке на базовый класс можно обращаться к объекту
// производного класса. Далее в программе происходит циклическое обращения к
// элементам данного массива для вывода сведений о каждом объекте. Несмотря на всю
// свою простоту, данный пример наглядно демонстрирует преимущества наследования
// и переопределения методов. Тип объекта, хранящийся в переменной ссылки на базовый
// класс, определяется во время выполнения и соответственно обусловливает дальнейшие
// действия. Так, если объект является производным от класса TwoDShape, то
// для получения его площади вызывается метод Area(). Но интерфейс для выполнения
// этой операции остается тем же самым независимо от типа используемой двумерной формы.

#endregion

#region English

// Applying Virtual Methods

// To better understand the power of virtual methods, we will apply them to the TwoDShape
// class. In the preceding examples, each class derived from TwoDShape defines a method
// called Area(). This suggests that it might be better to make Area() a virtual method of the
// TwoDShape class, allowing each derived class to override it, defining how the area is
// calculated for the type of shape that the class encapsulates. The following program does
// this. For convenience, it also adds a name property to TwoDShape. (This makes it easier
// to demonstrate the classes.)

// Use virtual methods and polymorphism. 

// using System; 

// class TwoDShape
// {
//    double pri_width;
//    double pri_height;

//    // A default constructor.  
//    public TwoDShape()
//    {
//        Width = Height = 0.0;
//        name = "null";
//    }

//    // Parameterized constructor.  
//    public TwoDShape(double w, double h, string n)
//    {
//        Width = w;
//        Height = h;
//        name = n;
//    }

//    // Construct object with equal width and height.  
//    public TwoDShape(double x, string n)
//    {
//        Width = Height = x;
//        name = n;
//    }

//    // Construct a copy of a TwoDShape object. 
//    public TwoDShape(TwoDShape ob)
//    {
//        Width = ob.Width;
//        Height = ob.Height;
//        name = ob.name;
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

//    public string name { get; set; }

//    public void ShowDim()
//    {
//        Console.WriteLine("Width and height are " +
//                           Width + " and " + Height);
//    }

//    public virtual double Area()
//    {
//        Console.WriteLine("Area() must be overridden");
//        return 0.0;
//    }
// }

// // A derived class of TwoDShape for triangles. 
// class Triangle : TwoDShape
// {
//    string Style;

//    // A default constructor.  
//    public Triangle()
//    {
//        Style = "null";
//    }

//    // Constructor for Triangle.  
//    public Triangle(string s, double w, double h) :
//      base(w, h, "triangle")
//    {
//        Style = s;
//    }

//    // Construct an isosceles triangle.  
//    public Triangle(double x) : base(x, "triangle")
//    {
//        Style = "isosceles";
//    }

//    // Construct a copy of a Triangle object. 
//    public Triangle(Triangle ob) : base(ob)
//    {
//        Style = ob.Style;
//    }

//    // Override Area() for Triangle. 
//    public override double Area()
//    {
//        return Width * Height / 2;
//    }

//    // Display a triangle's style. 
//    public void ShowStyle()
//    {
//        Console.WriteLine("Triangle is " + Style);
//    }
// }

// // A derived class of TwoDShape for rectangles.   
// class Rectangle : TwoDShape
// {
//    // Constructor for Rectangle.  
//    public Rectangle(double w, double h) :
//      base(w, h, "rectangle")
//    { }

//    // Construct a square.  
//    public Rectangle(double x) :
//      base(x, "rectangle")
//    { }

//    // Construct a copy of a Rectangle object. 
//    public Rectangle(Rectangle ob) : base(ob) { }

//    // Return true if the rectangle is square. 
//    public bool IsSquare()
//    {
//        if (Width == Height) return true;
//        return false;
//    }

//    // Override Area() for Rectangle. 
//    public override double Area()
//    {
//        return Width * Height;
//    }
// }

// class DynShapes
// {
//    static void Main()
//    {
//        TwoDShape[] shapes = new TwoDShape[5];

//        shapes[0] = new Triangle("right", 8.0, 12.0);
//        shapes[1] = new Rectangle(10);
//        shapes[2] = new Rectangle(10, 4);
//        shapes[3] = new Triangle(7.0);
//        shapes[4] = new TwoDShape(10, 20, "generic");

//        for (int i = 0; i < shapes.Length; i++)
//        {
//            Console.WriteLine("object is " + shapes[i].name);
//            Console.WriteLine("Area is " + shapes[i].Area());

//            Console.WriteLine();
//        }
//    }
// }

// The output from the program is shown here:

// object is triangle
// Area is 48

// object is rectangle
// Area is 100

// object is rectangle
// Area is 40

// object is triangle
// Area is 24.5

// object is generic
// Area() must be overridden
// Area is 0

// Let’s examine this program closely. First, as explained, Area() is declared as virtual in
// the TwoDShape class and is overridden by Triangle and Rectangle. Inside TwoDShape,
// Area() is given a placeholder implementation that simply informs the user that this method
// must be overridden by a derived class. Each override of Area() supplies an implementation
// that is suitable for the type of object encapsulated by the derived class. Thus, if you were to
// implement an ellipse class, for example, then Area() would need to compute the area of an
// ellipse.

// There is one other important feature in the preceding program.Notice in Main() that
// shapes is declared as an array of TwoDShape objects.However, the elements of this array
// are assigned Triangle, Rectangle, and TwoDShape references.This is valid because a base
// class reference can refer to a derived class object.The program then cycles through the array,
// displaying information about each object. Although quite simple, this illustrates the power
// of both inheritance and method overriding. The type of object stored in a base class reference
// variable is determined at runtime and acted on accordingly. If an object is derived from
// TwoDShape, then its area can be obtained by calling Area(). The interface to this operation
// is the same no matter what type of shape is being used.

#endregion