using System;

namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string firstText = "";
        private string textNow = "";

        public void inputText(string text)
        {
            firstText = text;
            textNow = text;
        }

        public string showText()
        {
            return textNow;
        }

        public void makeUpper()
        {
            textNow = textNow.ToUpper();
        }

        public void makeLower()
        {
            textNow = textNow.ToLower();
        }

        public int countChars()
        {
            return textNow.Length;
        }

        public bool checkWord(string word)
        {
            return textNow.Contains(word);
        }

        public void changeWord(string oldWord, string newWord)
        {
            textNow = textNow.Replace(oldWord, newWord);
        }

        public void getSubstring(int start, int length)
        {
            textNow = textNow.Substring(start, length);
        }

        public void trimText()
        {
            textNow = textNow.Trim();
        }

        public void resetText()
        {
            textNow = firstText;
        }
    }
}
