namespace HashMate.Access.Interface
{
    public interface ITextHashingManager
    {
        public bool Initialize(Dictionary<string, string> config);

        public Dictionary<ContentConstants.HashAlgorithms, string> GetHashFromText(string clearText);
    }
}