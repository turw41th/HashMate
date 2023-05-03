using HashMate.Access.Interface;
using HashMate.Manager.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace HashMate.Client.UI
{
    internal class HashingManagerAccess
    {
        public ITextHashingManager TextHashingManager { get; set; }

        public HashingManagerAccess()
        {
            TextHashingManager = new TextHashingManager();
        }

        public bool Initialize(Dictionary<string, string> config)
        {
            return TextHashingManager.Initialize(config);
        }

        public Dictionary<string, string> GetHashFromText(string clearText)
        {
            return TextHashingManager.GetHashFromText(clearText);
        }
    }
}
