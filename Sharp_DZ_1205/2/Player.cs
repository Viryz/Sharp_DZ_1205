using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Player : IPlayble, IRecodable
    {
        void IPlayble.Play()
        {
            Console.WriteLine("IPlayble play");
        }

        void IPlayble.Pause()
        {
            Console.WriteLine("IPlayble pause");
        }

        void IPlayble.Stop()
        {
            Console.WriteLine("IPlayble stop");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("IRecodable record");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("IRecodable pause");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("IRecodable stop");
        }
    }
}
