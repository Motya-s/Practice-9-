using System;

class Person
{
    
    private string name;
    private int age;

    public string Name
    {

        get { return name; }
        set { name = value; }

    }

    public int Age
    {

        get { return age; }
        set

        {

            if (value >= 0 && value <= 120)
                age = value;
            else
                Console.WriteLine("Ошибка: возраст должен быть от 0 до 120.");

        }

    }
    public Person(string name, int age)

    {

        Age = age;
        Name = name
        

    }

    public void SayHello()
    {

        Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");

    }
}

class Program
{

    static void Main()

    {

        Person p = new Person("Матвей", 17);
        p.SayHello();
        Console.WriteLine();

    }


}
