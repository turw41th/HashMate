﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HashMate.Access.Interface;

namespace HashMate.Client.UI
{
    internal class HashingManagerAccess
    {
        public ITextHashingManager TextHashingManager { get; set; }

        public HashingManagerAccess()
        {
            
        }
    }

    internal class AssemblyAccessor
    {
    }
}
