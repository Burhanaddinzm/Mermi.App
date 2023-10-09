//30 mermi var 1 e basanda ulduz cixir ve 1 mermi azalir 2 e basanda butun mermileri atir
//3 e basanda reload edir 4 e basanda qalan mermileri gostersin 0 a basanda app dayansin
int Mermi = 30;
while (true)
{
    string App = Console.ReadLine();
    if (App == "1" && Mermi > 0)
    {
        Console.WriteLine("*");
        Mermi--;
    }
    else if (App == "2")
    {
        while (Mermi > 0)
        {
            Console.WriteLine("*");
            Mermi--;
        }
    }
    else if (App == "3")
    {
        Mermi = 30;
    }
    else if (App == "4")
    {
        Console.WriteLine($"{Mermi}");
    }
    else if (App == "0")
    {
        break;
    }
}