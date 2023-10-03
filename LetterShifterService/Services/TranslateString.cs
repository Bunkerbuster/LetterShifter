using LetterShifterService.Interface;
using LetterShifterService.Helper;
using System.Security.Cryptography.X509Certificates;

namespace LetterShifterService.Services
{
    public class TranslateString : ITranslateString
    {
       private Dictionary<char, char> _TranslationTable { get; set; }


        public TranslateString()
        {
            _TranslationTable = CreateTranslationTable.Create();
        }


        public string Translate(string _Input,int _Reverse)
        {
            char[] inputArray = _Input.ToCharArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                char currentChar = inputArray[i];

                if (_Reverse == 1)
                {
                    // Find the value of the dictionary object  to search for the key
                    if (char.IsLower(currentChar) && _TranslationTable.ContainsKey(currentChar))
                    {
                        // Translate the character using the dictionary
                        inputArray[i] = _TranslationTable[currentChar];
                    }
                }
                else 
                {
                    if (char.IsLower(currentChar) && _TranslationTable.ContainsValue(currentChar))
                    {
                        // Translate the character using the dictionary but now on the value to get the Key
                        inputArray[i] = _TranslationTable.FirstOrDefault(x => x.Value == currentChar).Key; 
                    }
                }

                // If it's not a lowercase character or not found in the dictionary, leave it unchanged
            }
            return new string(inputArray);
        }
    }
}
