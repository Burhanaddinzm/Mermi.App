using Mermi.Service.Services.Interfaces;
namespace Mermi.Service.Services
{
    public class MermiService : IMermiService
    {
        public void BulletApp()
        {
            Console.WriteLine("1.Shoot");
            Console.WriteLine("2.Shoot All");
            Console.WriteLine("3.Reload");
            Console.WriteLine("4.Show Ammo");
            Console.WriteLine("0.Close");

            var request = new ConsoleKeyInfo();

            int BulletCount = 30;
            while (request.Key != ConsoleKey.D0)
            {
                request = Console.ReadKey();

                if (request.Key == ConsoleKey.D1)
                {
                    if (BulletCount > 0)
                    {
                        Console.WriteLine("*");
                        BulletCount--;
                    }
                    else
                    {
                        Console.WriteLine("Out of bullets!");
                    }

                }
                else if (request.Key == ConsoleKey.D2)
                {
                    while (BulletCount > 0)
                    {
                        Console.WriteLine("*");
                        BulletCount--;
                        Thread.Sleep(10);
                    }
                    Console.WriteLine("Out of bullets!");
                }
                else if (request.Key == ConsoleKey.D3)
                {
                    BulletCount = 30;
                    Console.WriteLine("Reloaded");
                }
                else if (request.Key == ConsoleKey.D4)
                {
                    Console.WriteLine($"Remaining Bullets: {BulletCount}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }


    }
}
