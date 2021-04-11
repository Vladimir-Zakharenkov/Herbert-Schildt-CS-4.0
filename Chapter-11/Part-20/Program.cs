#region Russian

// Применение абстрактных классов

// Иногда требуется создать базовый класс, в котором определяется лишь самая общая
// форма для всех его производных классов, а наполнение ее деталями предоставляется
// каждому из этих классов. В таком классе определяется лишь характер методов,
// которые должны быть конкретно реализованы в производных классах, а не в самом базовом
// классе. Подобная ситуация возникает, например, в связи с невозможностью получить
// содержательную реализацию метода в базовом классе. Именно такая ситуация
// была продемонстрирована в варианте класса TwoDShape из предыдущего примера,
// где метод Area() был просто определен как заполнитель. Такой метод не вычисляет и
// не выводит площадь двумерного объекта любого типа.

// Создавая собственные библиотеки классов, вы можете сами убедиться в том, что
// у метода зачастую отсутствует содержательное определение в контексте его базового
// класса. Подобная ситуация разрешается двумя способами. Один из них, как показано
// в предыдущем примере, состоит в том, чтобы просто выдать предупреждающее сообщение.
// Такой способ может пригодиться в определенных ситуациях, например при
// отладке, но в практике программирования он обычно не применяется. Ведь в базовом
// классе могут быть объявлены методы, которые должны быть переопределены в производном
// классе, чтобы этот класс стал содержательным. Рассмотрим для примера класс
// Triangle. Он был бы неполным, если бы в нем не был переопределен метод Area().
// В подобных случаях требуется какой-то способ, гарантирующий, что в производном
// классе действительно будут переопределены все необходимые методы. И такой способ
// в С# имеется. Он состоит в использовании абстрактного метода.

// Абстрактный метод создается с помощью указываемого модификатора типа
// abstract. У абстрактного метода отсутствует тело, и поэтому он не реализуется в базовом
// классе. Это означает, что он должен быть переопределен в производном классе,
// поскольку его вариант из базового класса просто непригоден для использования. Нетрудно
// догадаться, что абстрактный метод автоматически становится виртуальным и
// не требует указания модификатора virtual. В действительности совместное использование
// модификаторов virtual и abstract считается ошибкой.

// Для определения абстрактного метода служит приведенная ниже общая форма.

// abstract тип имя(список_параметров);

// Как видите, у абстрактного метода отсутствует тело. Модификатор abstract может
// применяться только в методах экземпляра, но не в статических методах (static).
// Абстрактными могут быть также индексаторы и свойства.

// Класс, содержащий один или больше абстрактных методов, должен быть также
// объявлен как абстрактный, и для этого перед его объявлением class указывается модификатор
// abstract. А поскольку реализация абстрактного класса не определяется
// полностью, то у него не может быть объектов. Следовательно, попытка создать объект абстрактного
// класса с помощью оператора new приведет к ошибке во время компиляции.

// Когда производный класс наследует абстрактный класс, в нем должны быть реализованы
// все абстрактные методы базового класса. В противном случае производный
// класс должен быть также определен как abstract. Таким образом, атрибут abstract
// наследуется до тех пор, пока не будет достигнута полная реализация класса.

// Используя абстрактный класс, мы можем усовершенствовать рассматривавшийся
// ранее класс TwoDShape. Для неопределенной двухмерной фигуры понятие площади
// не имеет никакого смысла, поэтому в приведенном ниже варианте класса TwoDShape
// метод Area() и сам класс TwoDShape объявляются как abstract. Это, конечно, означает,
// что во всех классах, производных от класса TwoDShape, должен быть переопределен
// метод Area().

//Создать абстрактный класс.
using System;

abstract class TwoDShape
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

    //Теперь метод Area() является абстрактным.
    public abstract double Area();
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
        TwoDShape[] shapes = new TwoDShape[4];

        shapes[0] = new Triangle("прямоугольный", 8.0, 12.0);
        shapes[1] = new Rectangle(10);
        shapes[2] = new Rectangle(10, 4);
        shapes[3] = new Triangle(7.0);

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

// Как показывает представленный выше пример программы, во всех производных
// классах метод Area() должен быть непременно переопределен, а также объявлен абстрактным.
// Убедитесь в этом сами, попробовав создать производный класс, в котором
// не переопределен метод Area(). В итоге вы получите сообщение об ошибке во время
// компиляции. Конечно, возможность создавать ссылки на объекты типа TwoDShape по-
// прежнему существует, и это было сделано в приведенном выше примере программы,
// но объявлять объекты типа TwoDShape уже нельзя. Именно поэтому массив shapes
// сокращен в методе Main() до 4 элементов, а объект типа TwoDShape для общей двухмерной
// формы больше не создается.

// Обратите также внимание на то, что в класс TwoDShape по-прежнему входит метод
// ShowDim() и что он не объявляется с модификатором abstract. В абстрактные классы
// вполне допускается (и часто практикуется) включать конкретные методы, которые
// могут быть использованы в своем исходном виде в производном классе. А переопределению
// в производных классах подлежат только те методы, которые объявлены как abstract.

#endregion

#region English

// Using Abstract Classes

// Sometimes you will want to create a base class that defines only a generalized form that will
// be shared by all of its derived classes, leaving it to each derived class to fill in the details.
// Such a class determines the nature of the methods that the derived classes must implement,
// but does not, itself, provide an implementation of one or more of these methods. One way
// this situation can occur is when a base class is unable to create a meaningful implementation
// for a method. This is the case with the version of TwoDShape used in the preceding example.
// The definition of Area( ) is simply a placeholder.It will not compute and display the area of
// any type of object.

// You will see as you create your own class libraries that it is not uncommon for a method
// to have no meaningful definition in the context of its base class. You can handle this situation
// two ways. One way, as shown in the previous example, is to simply have it report a warning
// message. Although this approach can be useful in certain situations—such as debugging—it
// is not usually appropriate. You may have methods that must be overridden by the derived
// class in order for the derived class to have any meaning. Consider the class Triangle. It is
// incomplete if Area() is not defined.In such a case, you want some way to ensure that a
// derived class does, indeed, override all necessary methods. C#’s solution to this problem
// is the abstract method.

// An abstract method is created by specifying the abstract type modifier.An abstract
// method contains no body and is, therefore, not implemented by the base class. Thus, a
// derived class must override it—it cannot simply use the version defined in the base class.
// As you can probably guess, an abstract method is automatically virtual, and there is no
// need to use the virtual modifier. In fact, it is an error to use virtual and abstract together.

// To declare an abstract method, use this general form:

// abstract type name(parameter-list);

// As you can see, no method body is present. The abstract modifier can be used only on
// instance methods. It cannot be applied to static methods.Properties and indexers can also
// be abstract.

// A class that contains one or more abstract methods must also be declared as abstract by
// preceding its class declaration with the abstract specifier.Since an abstract class does not
// define a complete implementation, there can be no objects of an abstract class. Thus, attempting
// to create an object of an abstract class by using new will result in a compile-time error.

// When a derived class inherits an abstract class, it must implement all of the abstract
// methods in the base class. If it doesn’t, then the derived class must also be specified as
// abstract. Thus, the abstract attribute is inherited until such time as a complete implementation
// is achieved.

// Using an abstract class, you can improve the TwoDShape class. Since there is no meaningful
// concept of area for an undefined two-dimensional figure, the following version of the preceding
// program declares Area() as abstract inside TwoDShape and TwoDShape as abstract. This,
// of course, means that all classes derived from TwoDShape must override Area().

// Create an abstract class. 

// using System; 

// abstract class TwoDShape
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

//    // Now, Area() is abstract. 
//    public abstract double Area();
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
//}

// class AbsShape
// {
//    static void Main()
//    {
//        TwoDShape[] shapes = new TwoDShape[4];

//        shapes[0] = new Triangle("right", 8.0, 12.0);
//        shapes[1] = new Rectangle(10);
//        shapes[2] = new Rectangle(10, 4);
//        shapes[3] = new Triangle(7.0);

//        for (int i = 0; i < shapes.Length; i++)
//        {
//            Console.WriteLine("object is " + shapes[i].name);
//            Console.WriteLine("Area is " + shapes[i].Area());

//            Console.WriteLine();
//        }
//    }
// }

// As the program illustrates, all derived classes must override Area() (or also be declared
// abstract). To prove this to yourself, try creating a derived class that does not override Area( ).
// You will receive a compile-time error. Of course, it is still possible to create an object reference
// of type TwoDShape, which the program does. However, it is no longer possible to declare
// objects of type TwoDShape. Because of this, in Main() the shapes array has been shortened
// to 4, and a generic TwoDShape object is no longer created.

// One other point: Notice that TwoDShape still includes the ShowDim() method and
// that it is not modified by abstract. It is perfectly acceptable—indeed, quite common—for an
// abstract class to contain concrete methods that a derived class is free to use as-is.Only those
// methods declared as abstract must be overridden by derived classes.

#endregion