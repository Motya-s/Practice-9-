using System;

class Pet
{

    private string name;
    private int energy;

    public string Name

    {

        get { return name; }
        set { name = value; }

    }

    public int Energy

    {

        get { return energy; }
        set

        {

            if (value < 0)
                energy = 0;
            else if (value > 100)
                energy = 100;
            else
                energy = value;

        }

    }

    public Pet(string name, int energy)
    {

        Name = name;
        Energy = energy;

    }

    public void Play()

    {
        Energy -= 20;
        Console.WriteLine($"{Name} играет, энергия: {Energy}%.");

    }

    public void Rest()

    {

        Energy += 30;
        Console.WriteLine($"{Name} отдыхает, энергия: {Energy}%.");

    }

}

class Program
{
    static void Main(string[] args)
    {

        Pet pet = new Pet("Шарик", 80);
        pet.Play();
        pet.Rest();

        Pet pet2 = new Pet("Муська", 150);
        pet2.Play();

    }
}