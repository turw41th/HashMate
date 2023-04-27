using HashMate.Access.Interface;
using System;
using System.IO;
using System.Reflection;

namespace HashMate.Client.UI
{
    internal class HashingManagerAccess
    {
        public ITextHashingManager TextHashingManager { get; set; }

        public HashingManagerAccess()
        {
            Assembly assembly = Assembly.LoadFrom(Path.GetFullPath("HashMate.Manager.Service"));
            Type type = assembly.GetType("HashMate.Manager.Service.TextHashingManager");
            object instance = Activator.CreateInstance(type);

            TextHashingManager = (ITextHashingManager)instance;
        }
    }

    
}
