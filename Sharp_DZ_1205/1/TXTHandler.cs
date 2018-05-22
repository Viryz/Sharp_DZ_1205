using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Creaate()
        {
            Console.WriteLine("Create TXT");
        }

        public override void Change()
        {
            Console.WriteLine("Change TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    }
}
