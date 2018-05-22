using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayble p1;
            IRecodable p2;
            
            Console.WriteLine("Enter \n1: play\n2: record");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    p1 = player;
                    p1.Play();
                    p1.Pause();
                    p1.Stop();
                }
                else if (choice == 2)
                {
                    p2 = player;
                    p2.Record();
                    p2.Pause();
                    p2.Stop();
                }
                else throw new Exception("Wrong chioce");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
