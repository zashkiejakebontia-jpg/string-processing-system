using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private StringService service = new StringService();
        private bool isRunning = true;

        public void runProgram()
        {
            while (isRunning)
            {
                showMenu();
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        enterText();
                        break;

                    case "2":
                        viewText();
                        break;

                    case "3":
                        service.makeUpper();
                        Console.WriteLine("Text converted to uppercase.");
                        break;

                    case "4":
                        service.makeLower();
                        Console.WriteLine("Text converted to lowercase.");
                        break;

                    case "5":
                        Console.WriteLine("Character Count: " + service.countChars());
                        break;

                    case "6":
                        checkWord();
                        break;

                    case "7":
                        changeWord();
                        break;

                    case "8":
                        getSubstring();
                        break;

                    case "9":
                        service.trimText();
                        Console.WriteLine("Spaces trimmed.");
                        break;

                    case "10":
                        service.resetText();
                        Console.WriteLine("Text reset.");
                        break;

                    case "11":
                        isRunning = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void showMenu()
        {
            Console.WriteLine("===== String Processing System =====");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
        }

        private void enterText()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            service.inputText(text);
            Console.WriteLine("Text saved.");
        }

        private void viewText()
        {
            Console.WriteLine("Current Text: " + service.showText());
        }

        private void checkWord()
        {
            Console.Write("Enter word to check: ");
            string word = Console.ReadLine();

            bool result = service.checkWord(word);
            Console.WriteLine(result ? "Word found." : "Word not found.");
        }

        private void changeWord()
        {
            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();

            service.changeWord(oldWord, newWord);
            Console.WriteLine("Word replaced.");
        }

        private void getSubstring()
        {
            Console.Write("Enter start index: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());

            service.getSubstring(start, length);
            Console.WriteLine("Substring extracted.");
        }
    }
}
