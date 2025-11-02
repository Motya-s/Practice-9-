using System;

class BankAccount
{
   
    private string owner;
    private double balance;

    public string Owner

    {

        get { return owner; }
        set { owner = value; }

    }

    public double Balance

    {

        get { return balance; }
        set

        {

            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("Ошибка: баланс не может быть отрицательным.");

        }
    }

    
    public BankAccount(string owner, double balance)

    {

        Owner = owner;
        Balance = balance;

    }

    public void Deposit(double amount)

    {

        if (amount > 0)

        {

            Balance += amount;
            Console.WriteLine($"{Owner}, баланс: {Balance:F2}");

        }

        else

        {

            Console.WriteLine("Ошибка: сумма должна быть больше 0.");

        }
    }

    public void Withdraw(double amount)

    {

        if (amount > 0 && amount <= Balance)

        {

            Balance -= amount;
            Console.WriteLine($"{Owner}, баланс: {Balance:F2}");

        }
        else
        {

            Console.WriteLine("Ошибка: сумма недопустима.");

        }
    }
}

class Program3

{

    static void Main()
    {

        BankAccount acc = new BankAccount("Матвей", 500);
        acc.Deposit(200);
        acc.Withdraw(100);
        acc.Withdraw(1000); 

    }
}