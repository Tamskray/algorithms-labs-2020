using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class DoubleLinkedList
    {
        public int Data;
        public DoubleLinkedList Next, Previous;

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
