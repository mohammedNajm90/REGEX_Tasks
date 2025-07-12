using System;
using System.Collections.Generic;

namespace RegEx_Moosa
{
    class Program
    {
        static void Main(string[] args) {
            List <String> phones = RegEx_Solutions.FindLocalPhoneNumbers("My number is 07901234567.");
            Console.WriteLine(string.Join(", ", phones));

            List<String> emails = RegEx_Solutions.FindallEmailAddresses("Contact me at ali@example.com or support@halal.io");
            Console.WriteLine(string.Join(", ", emails));

            List<String> words = RegEx_Solutions.FindallWordsStartWithCapitalLetter("Ali went to Basra and met Noor.");
            Console.WriteLine(string.Join(", ", words));

            List<String> numbers = RegEx_Solutions.FindallNumbers("I have 2 cats and 10 chickens");
            Console.WriteLine(string.Join(", ", numbers));

            List<String> hashtags = RegEx_Solutions.FindallHashtags("#blessed #codingLife");
            Console.WriteLine(string.Join(", ", hashtags));

            List<String> wordsEndWithIng = RegEx_Solutions.FindallWordsEndingWithIng("I am coding, running, and learning.");
            Console.WriteLine(string.Join(", ", wordsEndWithIng));

            List<String> amounts = RegEx_Solutions.FindallCurrencyAmounts(" I spent $100 on food and $29.99 on drinks.");
            Console.WriteLine(string.Join(", ", amounts));

            List<String> times = RegEx_Solutions.FindTime("The meeting is at 12:30.");
            Console.WriteLine(string.Join(", ", times));

            List<String> dates = RegEx_Solutions.FindDate("Today is 2025-07-10");
            Console.WriteLine(string.Join(", ", dates));

            List<String> wordsStartWithUn = RegEx_Solutions.FindallWordsstartWithUn(" unknown, unhappy, unlocked");
            Console.WriteLine(string.Join(", ", wordsStartWithUn));

            String username = "Ali123";
            Console.WriteLine($"is {username} valid username ? " + RegEx_Solutions.IsValidUsername(username));

            List<String> HTMLTags = RegEx_Solutions.FindHTMLTags("<div>Hello</div>");
            Console.WriteLine(string.Join(", ", HTMLTags));

            List<String> wordsEndWithQuestionMark = RegEx_Solutions.FindAllWordsEndingQuestionMark("How are you? Is this okay?");
            Console.WriteLine(string.Join(", ", wordsEndWithQuestionMark));

            List<String> Files = RegEx_Solutions.FindAllFileExtention("photo.jpg, resume.pdf");
            Console.WriteLine(string.Join(", ", Files));

            List<String> URLs = RegEx_Solutions.FindAllURLs("Visit https://halal.io today!");
            Console.WriteLine(string.Join(", ", URLs));
        }
    }
}
