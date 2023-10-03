# LetterShifter

Demo project to shift letters using a Dictionary object, and you can reverse the proces when needed.

String input = "hello world"
Reverse = 1 (default)

String Output = "gdkkn vnqkc"

String input = "gdkkn vnqkc"
Reverse = 0 

String Output = "hello world"

The Class CreateTranslationTable creates a Dictionary table that looks like this
![DictionaryObject](https://github.com/Bunkerbuster/LetterShifter/assets/562235/7508160c-e87d-444d-a68a-b7d8787a537d)

Al the letters in the alphabet are mapped and they are unique. 

In the first case (when shifting for the first time you match the letter of your input with the Key to get the matching value)
When you want to reverse the the outcome you need the Value to get the matching Key.
