//объявляем класс ParallelVectors который будет представлять пару параллельных векторов на плоскости
public class ParallelVectors
{
    //свойства для хранения координат первого вектора (начало и конец)
    public double X1 { get; set; } //координата X начала первого вектора
    public double Y1 { get; set; } //координата Y начала первого вектора
    public double X2 { get; set; } //координата X конца первого вектора
    public double Y2 { get; set; } //координата Y конца первого вектора

    //свойства для хранения смещений определяющих расположение второго вектора относительно первого
    public double OffsetX { get; set; } //смещение по оси X (сдвиг вправо)
    public double OffsetY { get; set; } //смещение по оси Y (сдвиг вниз)

    //конструктор класса, принимает значения координат первого вектора и смещений для второго
    public ParallelVectors(double x1, double y1, double x2, double y2, double offsetX, double offsetY)
    {
        //инициализация свойств с полученными значениями
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
        OffsetX = offsetX;
        OffsetY = offsetY;
    }

    //метод для вычисления площади параллелограмма, образованного двумя векторами
    public double CalcParallelogram()
    {
        //вычисляем разницу между X координатами конца и начала первого вектора
        double dx1 = X2 - X1;
        //вычисляем разницу между Y координатами конца и начала первого вектора
        double dy1 = Y2 - Y1;

        //смещение по оси X
        double dx2 = OffsetX;
        //смещение по оси Y
        double dy2 = OffsetY;

        //вычисляем площадь параллелограмма
        return Math.Abs(dx1 * dy2 - dx2 * dy1);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //объект ParallelVectors с заданными координатами и смещениями
        //первый вектор начинается в точке (1, 1) и заканчивается в точке (4, 5), второй вектор смещен относительно первого на (2, -1)
        ParallelVectors vectors = new ParallelVectors(1, 1, 4, 5, 2, -1);

        //вызываем метод CalcParallelogram() для вычисления площади параллелограмма
        double area = vectors.CalcParallelogram();

        Console.WriteLine($"Площадь параллелограмма: {area}");
    }
}