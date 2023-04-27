using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMate.Access.Interface
{
    public class ContentConstants
    {
        public enum HashAlgorithms
        {
            MD5,
            SHA1,
            SHA256,
            SHA3_256,
            BLAKE2,
            WHIRLPOOL,
            RIPEMD,
            TIGER,
            GOST,
            SIPHASH
        }
    }
}
