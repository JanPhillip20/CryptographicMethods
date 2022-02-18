using System;

namespace cryptographicMethods
{
    public static class BruteForce
    {
        private static string textDecrypted;
        private static string textClear;

        public static string decryptionHandler(string text)
        {
            textDecrypted = text.ToUpper();

            
            for (int i = 0; i <= 26; i++)
            {
                int[] characterIndexList = new int[textDecrypted.Length];
                string encryptedText = String.Empty;
                foreach (var character in textDecrypted)
                {
                    int numberIndexClear = CharacterToNumber(character) + (26 - i) % 26;
                    var encryptedCharacter = NumberToCharater(numberIndexClear);
                    encryptedText += encryptedCharacter;
                }
                textClear = textClear + encryptedText + Environment.NewLine;
            }

            return textClear;
        }

        public static char NumberToCharater(int number)
        {
            int referencNumber = 'A';
            int realNumber = referencNumber + number;
            return (char) realNumber;
        }

        public static int CharacterToNumber(char character)
        {
            int referencNumber = 'A';
            int number = character;
            return number - referencNumber;
        }
    }
}