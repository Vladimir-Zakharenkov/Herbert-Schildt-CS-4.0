// В классах, реализующих интерфейсы, разрешается и часто практикуется определять
// их собственные дополнительные члены. В качестве примера ниже приведен другой
// вариант класса ByTwos, в который добавлен метод GetPrevious(), возвращающий
// предыдущее значение.

//Реализовать интерфейс ISeries и добавить в класс ByTwos метод GetPrevious().
using Part_04;

class ByTwos : ISeries
{
    int start;
    int val;
    int prev;

    public ByTwos()
    {
        start = 0;
        val = 0;
        prev = -2;
    }

    public int GetNext()
    {
        prev = val;
        val += 2;
        return val;
    }

    public void Reset()
    {
        val = start;
        prev = start - 2;
    }

    public void SetStart(int x)
    {
        start = x;
        val = start;
        prev = val - 2;
    }

    //Метод , не указанный в интерфейсе ISeries.
    public int GetPrevious()
    {
        return prev;
    }
}

// Как видите, для того чтобы добавить метод GetPrevious(), потребовалось внести
// изменения в реализацию методов, определяемых в интерфейсе ISeries. Но поскольку
// интерфейс для этих методов остается прежним, то такие изменения не вызывают
// никаких осложнений и не нарушают уже существующий код. В этом и заключается
// одно из преимуществ интерфейсов.