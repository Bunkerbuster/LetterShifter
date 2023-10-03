namespace LetterShifterService.Helper
{
    public static class CreateTranslationTable
    {
        public static Dictionary<char, char> Create()
        {
            // Create a dictionary for character translation
            Dictionary<char, char> translationTable = new Dictionary<char, char>();
            for (char c = 'a'; c <= 'z'; c++)
            {
                char translatedChar = c == 'a' ? 'z' : (char)(c - 1);
                translationTable[c] = translatedChar;
            }
            return translationTable;
        }
    }
}