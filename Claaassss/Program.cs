using System;

class BankAccount
{
    public decimal Balance;

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Начальный баланс не может быть отрицательным.");

        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма пополнения должна быть положительной.");

        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > Balance || amount <= 0)
            return false;

        Balance -= amount;
        return true;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Текущий баланс: {Balance:F2} руб.");
    }
}
class Rectangle
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Ширина: {Width}, Высота: {Height}, Площадь: {GetArea():F2}");
    }
}
class Car
{
    public string Brand;
    public int Mileage;

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
class Book
{
    public string Title;
    public string Author;
    public int Pages;

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
class Student
{
    public string Name;
    public string Group;
    public int Age;
    public Student(string name, string group, int age)
    {
        Name = name;
        Group = group;
        Age = age;
    }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, группа: {Group}, возраст: {Age}");
        Console.WriteLine($"Имя: {Name}, группа: по умолчанию, возраст: {Age}");

    }
}
class Program
{
    static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount(1000);
        myAccount.Deposit(500);
        myAccount.Withdraw(200);
        myAccount.ShowBalance();

        Rectangle rect = new Rectangle(5, 10);
        rect.PrintInfo();

        Car myCar = new Car("Toyota", 5000);
        myCar.Drive(200);
        myCar.ShowMileage();

        Book b = new Book("1984", "Chert", 123);
        b.PrintInfo();

        Student s = new Student("123456", "4567", 123456);
        s.ShowInfo();
        Student a = new Student("12345", 44444);
        Console.ReadKey(); 

    }
}
