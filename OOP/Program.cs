using System;
using System.IO;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public void MoveBy(int dx, int dy, int dz)
    {
        X += dx;
        Y += dy;
        Z += dz;
    }
}

class User
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Patronymic { get; set; }
    public int Age { get; set; }

    public string GetFullName(string LastName, string FirstName, string Patronymic, int Age)
    {
        return $"{LastName} {FirstName} {Patronymic} {Age}";
    }
}

class PersonalComputer
{
    public string Model { get; set; }
    public double ProcessorFrequency { get; set; }
    public int RAMSize { get; set; }
    public int HardDiskSize { get; set; }

    public void Info(string Model, double ProcessorFrequency, int RAMsize, int HardDiskSize)
    {
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Тактовая частота процессора: {ProcessorFrequency} ГГц");
        Console.WriteLine($"Объем оперативной памяти: {RAMSize} ГБ");
        Console.WriteLine($"Объем жесткого диска: {HardDiskSize} ГБ");
    }
}

class Laptop
{
    public string Model { get; set; }
    public double ProcessorFrequency { get; set; }
    public int RAMSize { get; set; }
    public int HardDiskSize { get; set; }
    public double Weight { get; set; }

    public void Info()
    {
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Тактовая частота процессора: {ProcessorFrequency} ГГц");
        Console.WriteLine($"Объем оперативной памяти: {RAMSize} ГБ");
        Console.WriteLine($"Объем жесткого диска: {HardDiskSize} ГБ");
        Console.WriteLine($"Масса: {Weight} кг");
    }
}

class Smartphone
{
    public string Model { get; set; }
    public double ProcessorFrequency { get; set; }
    public int RAMSize { get; set; }
    public int InternalMemorySize { get; set; }
    public string OperatingSystem { get; set; }
    public double Weight { get; set; }

    public string Info => $"Модель: {Model}, " +
                          $"Тактовая частота процессора: {ProcessorFrequency} ГГц, " +
                          $"Объем оперативной памяти: {RAMSize} ГБ, " +
                          $"Объем постоянной памяти: {InternalMemorySize} ГБ, " +
                          $"Операционная система: {OperatingSystem}, " +
                          $"Масса: {Weight} кг";
}

class Rectangle
{
    public int Right { get; set; }
    public int Bottom { get; set; }

    public int Perimeter()
    {
        return 2 * (Bottom + Right);
    }

    public int Area()
    {
        return Bottom * Right;
    }
}

class Triangle
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public double Perimeter(double Side1, double Side2, double Side3)
    {
        double result = Side1 + Side2 + Side3;
        return result;
    }

    public void PrintSides()
    {
        Console.WriteLine($"Сторона 1: {Side1}");
        Console.WriteLine($"Сторона 2: {Side2}");
        Console.WriteLine($"Сторона 3: {Side3}");
    }
}

class MailItem
{
    public int Index { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Building { get; set; }
    public int Apartment { get; set; }
    public string Message { get; set; }

    public string GetAddress()
    {
        return $"{Index}, {City}, ул. {Street}, д. {House}, к. {Building}, кв. {Apartment}, Сообщение: '{Message}' ";
    }
}

class Circle
{
    public double CenterX { get; set; }
    public double CenterY { get; set; }
    public double Radius { get; set; }

    public double Circumference()
    {
        return 2 * Math.PI * Radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

class Square
{
    public int SideLength { get; set; }

    public int Area()
    {
        return SideLength * SideLength;
    }

    public int Perimeter()
    {
        return 4 * SideLength;
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Выберите необходимый класс для исполнения:");
        Console.WriteLine("«Точка» (1), «Пользователь» (2), «Персональный компьютер» (3), «Ноутбук» (4), «Смартфон» (5), «Прямоугольник» (6), «Треугольник» (7), «Почтовое отправление» (8), «Окружность» (9), «Квадрат» (10)");
        int response = Convert.ToInt32(Console.ReadLine());

        if (response == 1)
        {
            // Создание экземпляра класса Point
            Point point1 = new Point();
            point1.X = 1;
            point1.Y = 2;
            point1.Z = 3;

            Console.WriteLine($"Точка 1 до: X={point1.X}, Y={point1.Y}, Z={point1.Z}");

            Point point2 = new Point();
            Console.WriteLine("Введите коордитанты точки 2");
            point2.X = Convert.ToInt32(Console.ReadLine());
            point2.Y = Convert.ToInt32(Console.ReadLine());
            point2.Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Точка 2 до: X={point2.X}, Y={point2.Y}, Z={point2.Z}");

            Console.WriteLine("Введите значения смещения точек для X, Y, Z:");
            int XPointOffset = Convert.ToInt32(Console.ReadLine());
            int YPointOffset = Convert.ToInt32(Console.ReadLine());
            int ZPointOffset = Convert.ToInt32(Console.ReadLine());

            point1.MoveBy(XPointOffset, YPointOffset, ZPointOffset);
            point2.MoveBy(XPointOffset, YPointOffset, ZPointOffset);
            Console.WriteLine($"Точка 1 после: X={point1.X}, Y={point1.Y}, Z={point1.Z}");
            Console.WriteLine($"Точка 2 после: X={point2.X}, Y={point2.Y}, Z={point2.Z}");
        }
        else if (response == 2)
        {
            // Создание экземпляра класса User
            User user1 = new User();
            user1.LastName = "Иванов";
            user1.FirstName = "Иван";
            user1.Patronymic = "Иванович";
            user1.Age = 30;
            string fullName = user1.GetFullName(user1.LastName, user1.FirstName, user1.Patronymic, user1.Age);
            Console.WriteLine($"Пользователь 1: ФИО и возраст: {fullName}");

            User user2 = new User();
            Console.WriteLine("Введите фамилию, имя, отчество и возраст пользователя");
            user2.LastName = Console.ReadLine();
            user2.FirstName = Console.ReadLine();
            user2.Patronymic = Console.ReadLine();
            user2.Age = Convert.ToInt32(Console.ReadLine());
            string fullName2 = user2.GetFullName(user2.LastName, user2.FirstName, user2.Patronymic, user2.Age);
            Console.WriteLine($"Пользовател 2: ФИО и возраст: {fullName2}");


        }
        else if (response == 3)
        {
            // Создание экземпляра класса PersonalComputer
            PersonalComputer pc1 = new PersonalComputer();
            pc1.Model = "Dell XPS";
            pc1.ProcessorFrequency = 2.8;
            pc1.RAMSize = 16;
            pc1.HardDiskSize = 500;
            Console.WriteLine("Информация о компьютере 1:");
            pc1.Info(pc1.Model, pc1.ProcessorFrequency, pc1.RAMSize, pc1.HardDiskSize);

            PersonalComputer pc2 = new PersonalComputer();
            Console.WriteLine("Введите информацию о компьютере 2: модель, тактовая частота процессора, объем оперативной памяти, объем жесткого диска:");
            pc2.Model = Console.ReadLine();
            pc2.ProcessorFrequency = Convert.ToDouble(Console.ReadLine());
            pc2.RAMSize = Convert.ToInt32(Console.ReadLine());
            pc2.HardDiskSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Информация о компьютере 2:");
            pc2.Info(pc2.Model, pc2.ProcessorFrequency, pc2.RAMSize, pc2.HardDiskSize);

        }
        else if (response == 4)
        {
            // Создание экземпляра класса Laptop
            Laptop laptop1 = new Laptop();
            laptop1.Model = "Lenovo ThinkPad";
            laptop1.ProcessorFrequency = 2.4;
            laptop1.RAMSize = 8;
            laptop1.HardDiskSize = 256;
            laptop1.Weight = 2.5;
            Console.WriteLine("Информация о ноутбуке 1:");
            laptop1.Info();

            Laptop laptop2 = new Laptop();
            Console.WriteLine("Введите информацию о ноутбуке 2: модель, тактовая частота процессора, объем оперативной памяти, объем жесткого диска, масса:");
            laptop2.Model = Console.ReadLine();
            laptop2.ProcessorFrequency = Convert.ToDouble(Console.ReadLine());
            laptop2.RAMSize = Convert.ToInt32(Console.ReadLine());
            laptop2.HardDiskSize = Convert.ToInt32(Console.ReadLine());
            laptop2.Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Информация о ноутбуке 2:");
            laptop2.Info();
        }
        else if (response == 5)
        {
            // Создание экземпляра класса Smartphone
            Smartphone smartphone1 = new Smartphone();
            smartphone1.Model = "iPhone 13";
            smartphone1.ProcessorFrequency = 2.5;
            smartphone1.RAMSize = 4;
            smartphone1.InternalMemorySize = 64;
            smartphone1.OperatingSystem = "iOS";
            smartphone1.Weight = 0.2;
            Console.WriteLine($"Смартфон 1: {smartphone1.Info}");

            Smartphone smartphone2 = new Smartphone();
            Console.WriteLine("Введите информацию о смартфоне 2: модель,  тактовая частота процессора, объем оперативной памяти, объем постоянной памяти, тип операционной системы, масса");
            smartphone2.Model = Console.ReadLine();
            smartphone2.ProcessorFrequency = Convert.ToDouble(Console.ReadLine());
            smartphone2.RAMSize = Convert.ToInt32(Console.ReadLine());
            smartphone2.InternalMemorySize = Convert.ToInt32(Console.ReadLine());
            smartphone2.OperatingSystem = Console.ReadLine();
            smartphone2.Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Смартфон 2: {smartphone2.Info}");
        }
        else if (response == 6)
        {
            // Создание экземпляра класса Rectangle
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Right = 5;
            rectangle1.Bottom = 3;
            int perimeter = rectangle1.Perimeter();
            int area = rectangle1.Area();
            Console.WriteLine($"Прямоугольник 1 до вычислений - длинна: {rectangle1.Right}, ширина: {rectangle1.Bottom}");
            Console.WriteLine($"Прямоугольник 1: Периметр={perimeter}, Площадь={area}");

            Rectangle rectangle2 = new Rectangle();

            Console.WriteLine("Введите стороны - длинну и ширину: ");
            rectangle2.Right = Convert.ToInt32(Console.ReadLine());
            rectangle2.Bottom = Convert.ToInt32(Console.ReadLine());
            int perimeter2 = rectangle2.Perimeter();
            int area2 = rectangle2.Area();
            Console.WriteLine($"Прямоугольник 2 до вычислений - длинна: {rectangle2.Right}, ширина: {rectangle2.Bottom}");
            Console.WriteLine($"Прямоугольник 2: Периметр: {perimeter2}, Площадь: {area2}");
        }
        else if (response == 7)
        {
            // Создание экземпляра класса Triangle
            Triangle triangle1 = new Triangle();
            double trianglePerimeter = triangle1.Perimeter(3.4, 4.1, 5.2);

            Console.WriteLine($"Сторона 1: 3.4, Сторона 2: 4.1, Сторона 3: 5.2");
            Console.WriteLine($"Результат: {trianglePerimeter}");

            Triangle triangle2 = new Triangle();

            Console.WriteLine("Введите стороны:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Результат: {triangle2.Perimeter(side1, side2, side3)}");
        }
        else if (response == 8)
        {
            MailItem mailItem1 = new MailItem();
            mailItem1.Index = 123112;
            mailItem1.City = "Тверь";
            mailItem1.Street = "Ленина";
            mailItem1.House = "14";
            mailItem1.Building = "2";
            mailItem1.Apartment = 26;
            mailItem1.Message = "С новым годом!";
            Console.WriteLine("Почтовое отправление 1:");
            Console.WriteLine($"{mailItem1.GetAddress()}");

            MailItem mailItem2 = new MailItem();
            Console.WriteLine("Введите данные о почтовом отправлении 2 - индекс, город, улица, дом, корпус, квартира и сообщение:");
            mailItem2.Index = Convert.ToInt32(Console.ReadLine());
            mailItem2.City = Console.ReadLine();
            mailItem2.Street = Console.ReadLine();
            mailItem2.House = Console.ReadLine();
            mailItem2.Building = Console.ReadLine();
            mailItem2.Apartment = Convert.ToInt32(Console.ReadLine());
            mailItem2.Message = Console.ReadLine();
            Console.WriteLine("Почтовое отправление 2:");
            Console.WriteLine($"{mailItem2.GetAddress()}");
        } 
        else if (response == 9)
        {
            Circle circle1 = new Circle();
            circle1.CenterX = 5; 
            circle1.CenterY = 5;
            circle1.Radius = 5;
            Console.WriteLine($"Окружность 1 - центр: ({circle1.CenterX};{circle1.CenterY}), радиус: {circle1.Radius}");
            Console.WriteLine($"Длина окружности 1: {circle1.Circumference()}");
            Console.WriteLine($"Площадь окружности 1: {circle1.Area()}");

            Circle circle2 = new Circle();
            Console.WriteLine("Введите координаты центра окружности 2 и ее радиус");
            Console.Write("Х: ");
            circle2.CenterX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            circle2.CenterY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Радиус: ");
            circle2.Radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Окружность 2 - центр: ({circle2.CenterX};{circle2.CenterY}), радиус: {circle2.Radius}");
            Console.WriteLine($"Длина окружности 2: {circle2.Circumference()}");
            Console.WriteLine($"Площадь окружности 2: {circle2.Area()}");
        } 
        else if (response == 10)
        {
            Square square1 = new Square();
            square1.SideLength = 5;
            Console.WriteLine($"Сторона квадрата 1: {square1.SideLength}");
            Console.WriteLine($"Периметр квадрата 1: {square1.Perimeter()}");
            Console.WriteLine($"Площадь квадрата 1: {square1.Area()}");

            Square square2 = new Square();
            Console.WriteLine("Введите сторону квадрата 2:");
            square2.SideLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сторона квадрата 2: {square2.SideLength}");
            Console.WriteLine($"Периметр квадрата 2: {square2.Perimeter()}");
            Console.WriteLine($"Площадь квадрата 2: {square2.Area()}");
        }
        
    }
}