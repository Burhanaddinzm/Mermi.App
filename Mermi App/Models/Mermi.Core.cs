using Mermi_App.Models.Interface;

namespace Mermi_App.Models
{
    public class Mermi
    {
        public string Request { get; set; }
        public int BulletCount { get; set; }

        public void BulletApp()
        {
            Console.WriteLine("1.Shoot");
            Console.WriteLine("2.Shoot All");
            Console.WriteLine("3.Reload");
            Console.WriteLine("4.Show Ammo");
            Console.WriteLine("0.Close");

            BulletCount = 30;
            while (Request != "0")
            {
                Request = Console.ReadLine();
                if (Request == "1")
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
                else if (Request == "2")
                {
                    while (BulletCount > 0)
                    {
                        Console.WriteLine("*");
                        BulletCount--;
                        Thread.Sleep(10);
                    }
                    Console.WriteLine("Out of bullets!");
                }
                else if (Request == "3")
                {
                    BulletCount = 30;
                    Console.WriteLine("Reloaded");
                }
                else if (Request == "4")
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
