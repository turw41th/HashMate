using HashMate.Access.Interface;

namespace HashMate.Manager.Service
{
    public class TextHashingManager : ITextHashingManager
    {
        private TextHashingEngine engine;

        public bool Initialize(Dictionary<string, string> config)
        {
            try
            {
                engine = new TextHashingEngine();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Dictionary<ContentConstants.HashAlgorithms, string> GetHashFromText(string clearText)
        {
            var result = new Dictionary<ContentConstants.HashAlgorithms, string>() 
            {
                { ContentConstants.HashAlgorithms.MD5, engine.GetMD5Hash(clearText) },
                { ContentConstants.HashAlgorithms.SHA1, engine.GetSHA1Hash(clearText) },
                { ContentConstants.HashAlgorithms.SHA256, engine.GetSHA256Hash(clearText) },
                { ContentConstants.HashAlgorithms.SHA512, engine.GetSHA512Hash(clearText) }
            };


            return result;
        }
    }
}