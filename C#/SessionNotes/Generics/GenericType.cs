using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericType<K>
    {
        public K Value { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Type: {0}", this.Value.GetType());
            Console.WriteLine(this.Value.ToString());
            Console.WriteLine();
        }

    }
}
