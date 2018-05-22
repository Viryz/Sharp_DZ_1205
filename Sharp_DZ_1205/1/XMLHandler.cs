using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML");
        }

        public override void Creaate()
        {
            Console.WriteLine("Create XML");
        }

        public override void Change()
        {
            Console.WriteLine("Change XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML");
        }
    }
}
