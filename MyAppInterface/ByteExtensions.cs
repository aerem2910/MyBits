using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppInterface
{
    internal static class ByteExtensions
    {
        public static Bits ToBits(this byte value)
        {
            return new Bits(value);
        }
    }
}