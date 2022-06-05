string[] commands = { "/show-recent-currency-rates", "/find-currency-rate-by-code", "/calculate-amount-by-currecy", "/EXIT" };

for (int i = 0; i < commands.Length; i++)
{
    Console.WriteLine(commands[i]);
}
string[] currencycommand = { "USD", "EURO", "AUD" };
float[] currencycost = { 1.7f, 1.82f, 1.23f };

Console.WriteLine("ENTER amount :");
double amount = Convert.ToDouble(Console.ReadLine());

for (int i = 0; i < currencycost.Length; i++)
{
    Console.WriteLine($"{currencycost[i]}-{currencycommand[i]}");
}
Console.WriteLine("----------------HELLO");
Console.WriteLine("Chose the Commands ");
while (true)
{

    string x = Console.ReadLine();
    if (x == commands[0])
    {
        for (int i = 0; i < currencycost.Length; i++)
        {
            Console.WriteLine($"{currencycost[i]}-{currencycommand[i]}");
        }


    }
    else if (x == commands[3])
    {
        Console.WriteLine("Thank You");
        break;
    }
    else if (x == commands[1])
    {
        string y = Console.ReadLine();

        for (int i = 0; i < currencycommand.Length; i++)
        {
            if (y == currencycommand[i])
            {
                Console.WriteLine(currencycost[i]);
            }
        }
    }
    else if (x == commands[2])
    {
        string z = Console.ReadLine();
        for (int i = 0; i < currencycommand.Length; i++)
        {
            if (z == currencycommand[i])
            {
                Console.WriteLine(amount / currencycost[i]);

            }
        }
    }
    else
    {
        for (int i = 0; i < commands.Length; i++)
        {
            Console.WriteLine(commands[i]);
        }
        Console.WriteLine("Use These Commands n");
    }
}