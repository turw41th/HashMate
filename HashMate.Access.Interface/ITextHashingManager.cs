namespace HashMate.Access.Interface
{
    interface ITextHashingManager
    {
        public bool Initialize(Dictionary<string, string> config);

        public Dictionary<string, string> GetHashFromText(string clearText);
    }
}