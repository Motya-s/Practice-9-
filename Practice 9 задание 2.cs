using System;

class Phone

{
    
    private string brand;
    private int batteryLevel;

    public string Brand
    {

        get { return brand; }
        set { brand = value; }

    }

    public int BatteryLevel

    {

        get { return batteryLevel; }
        set
        {

            if (value >= 0 && value <= 100)
                batteryLevel = value;
            else
                Console.WriteLine("Ошибка: заряд должен быть от 0 до 100%.");

        }

    }

    public Phone(string brand, int batteryLevel)
    {
        Brand = brand;
        BatteryLevel = batteryLevel;
    }

    public void UsePhone()

    {

        if (batteryLevel >= 10)
            batteryLevel -= 10;
        else
            batteryLevel = 0;

        Console.WriteLine($"Телефон {Brand}, заряд: {batteryLevel}%.");

    }
}

class Program2

{
    static void Main()

    {

        Phone phone = new Phone("Poco", 66);
        phone.UsePhone();
        phone.UsePhone();
        phone.BatteryLevel = -10; 
        Console.WriteLine();

    }

}