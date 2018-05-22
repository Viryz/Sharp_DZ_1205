using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler h;
            Console.Write("Enter the name of document with format (*.*): ");
            string doc = Console.ReadLine();
            try
            {
                if (doc.Contains(".xml"))
                {
                    Console.WriteLine("This is xml file");
                    h = new XMLHandler();
                }
                else if (doc.Contains(".txt"))
                {
                    Console.WriteLine("This is txt file");
                    h = new TXTHandler();
                }
                else if (doc.Contains(".doc"))
                {
                    Console.WriteLine("This is doc file");
                    h = new DOCHandler();
                }
                else throw new Exception("Wrong format of file");
                h.Open();
                h.Creaate();
                h.Change();
                h.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
