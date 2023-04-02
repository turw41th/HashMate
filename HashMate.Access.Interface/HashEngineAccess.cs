namespace HashMate.Access.Interface
{
    interface IHashEngineAccess
    {
        public bool Initialize(Dictionary<string, string> config);

        public Dictionary<string, string> GetHash(string clearText);
    }
}