﻿using HashMate.Access.Interface;
using HashMate.Client.UI.Utilities;
using System.Collections.Generic;

namespace HashMate.Client.UI.ViewModels
{
    public class TextToHashViewModel : BaseNotifier
    {
        private string plainText;
        private string hashedMD5;
        private string hashedSHA1;
        private string hashedSHA2;
        private string hashedSHA3;

        private HashingManagerAccess access;

        public string PlainText 
        { 
            get => plainText;
            set
            {
                SetProperty(ref plainText, value);
                OnHashButtonClicked(new object());
            }
        }
        public string HashedMD5 { get => hashedMD5; set => SetProperty(ref hashedMD5, value); }
        public string HashedSHA1 { get => hashedSHA1; set => SetProperty(ref hashedSHA1, value); }
        public string HashedSHA2 { get => hashedSHA2; set => SetProperty(ref hashedSHA2, value); }
        public string HashedSHA3 { get => hashedSHA3; set => SetProperty(ref hashedSHA3, value); }

        public TextToHashViewModel()
        {
            access = new HashingManagerAccess();

            access.Initialize(new Dictionary<string, string>());
        }

        public void OnHashButtonClicked(object o)
        {
            string clearText = PlainText;
            if (string.IsNullOrWhiteSpace(clearText)) return;

            var result = access.GetHashFromText(clearText);

            FillTextboxes(result);
        }

        private void FillTextboxes(Dictionary<ContentConstants.HashAlgorithms, string> args)
        {
            HashedMD5 = args[ContentConstants.HashAlgorithms.MD5];
            HashedSHA1 = args[ContentConstants.HashAlgorithms.SHA1];
            HashedSHA2 = args[ContentConstants.HashAlgorithms.SHA256];
        }
    }
}
