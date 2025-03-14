using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, Автор: {Author}, Страниц: {Pages}");
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }

    public Student(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        Group = "Неизвестная группа";
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Студент: {Name}, Возраст: {Age}, Группа: {Group}");
    }
}

public class Car
{
    public string Brand { get; set; }
    public int Mileage { get; set; }

    public Car(string brand, int mileage)
    {
        Brand = brand;
        Mileage = mileage;
    }

    public void Drive(int distance)
    {
        Mileage += distance;
    }

    public void ShowMileage()
    {
        Console.WriteLine($"Марка: {Brand}, Пробег: {Mileage} км");
    }
}

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int GetArea()
    {
        return Width * Height;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Ширина: {Width}, Высота: {Height}, Площадь: {GetArea()}");
    }
}

public class BankAccount
{
    public int Balance { get; set; }

    public BankAccount(int initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Недостаточно средств на счете.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Текущий баланс: {Balance} руб.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("1984", "Джордж Оруэлл", 328);
        book1.PrintInfo();

        Student student1 = new Student("Алиса", 20, "ИС-202");
        Student student2 = new Student("Борис", 19);
        student1.ShowInfo();
        student2.ShowInfo();

        Car myCar = new Car("Toyota", 5000);
        myCar.Drive(200);
        myCar.ShowMileage();

        Rectangle rect = new Rectangle(5, 10);
        rect.PrintInfo();

        BankAccount myAccount = new BankAccount(1000);
        myAccount.Deposit(500);
        myAccount.Withdraw(200);
        myAccount.ShowBalance();
        Console.ReadKey();
    }
}