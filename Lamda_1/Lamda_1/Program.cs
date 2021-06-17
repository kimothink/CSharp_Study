using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_1
{
    class Program
    {
        delegate void Lambda();
        static void Main(string[] args)
        {
            Lambda hi =
                () => Console.WriteLine("안녕하세요");
            hi();

        }
    }
}
