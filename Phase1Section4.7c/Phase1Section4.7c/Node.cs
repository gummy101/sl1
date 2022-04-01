using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._7c
{
    internal class Node
    {
        internal string Data { get; set; }
        internal Node Next { get; set; }
        internal Node Previous { get; set; }

        internal Node() { }
        internal Node(string data)
        {
            Data = data;
        }
    }
}
