using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DoubleItem<T>
    {
        public T Data { get; set; }
        public DoubleItem<T> Previous { get; set; }
        public DoubleItem<T> Next { get; set; }

        public DoubleItem(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}