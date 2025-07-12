using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace RegEx_Moosa
{
    class RegEx_Solutions
    {
        //Method to Match all phone numbers
        public static List<String> FindLocalPhoneNumbers(String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"0790\d{7}");
                List<string> phoneNumbers = new List<string>();

                foreach (Match match in matches)
                    phoneNumbers.Add(match.Value);

                return phoneNumbers;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //Method to print all email addresses
        public static List<String> FindallEmailAddresses(String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"[\w\.-]+@[\w\.-]+\.\w+");
                List<String> emails = new List<string>();
                foreach (Match match in matches)
                    emails.Add(match.Value);

                return emails;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //Method to print any word that starts with a capital letter
        public static List <String> FindallWordsStartWithCapitalLetter(String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"\b[A-Z][a-z]*");
                List<String> words = new List<String>();

                foreach (Match match in matches)
                    words.Add(match.Value);

                return words;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<String>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<String>();
            }
        }

        //Method to print all integrs
        public static List<String> FindallNumbers(String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"\b\d+\b");
                List<String> numbers = new List<string>();

                foreach (Match match in matches)
                    numbers.Add(match.Value);
                return numbers;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //method to print all hashtags
        public static List <String> FindallHashtags(String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"#\w+");
                List<String> hashtags = new List<string>();

                foreach (Match match in matches)
                    hashtags.Add(match.Value);

                return hashtags;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //method to print all words that ends with ing
        public static List <String> FindallWordsEndingWithIng (String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"\b\w+ing\b");
                List<String> words = new List<string>();
                foreach (Match match in matches)
                    words.Add(match.Value);

                return words;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //Method to print Find all currency amounts
        public static List <String> FindallCurrencyAmounts (String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"\$\d+(\.\d{2})?");
                List<String> amounts = new List<string>();

                foreach (Match match in matches)
                    amounts.Add(match.Value);

                return amounts;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //Method to print time
        public static List <String> FindTime (String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"\b\d{1,2}:\d{2}\b");
                List<String> times = new List<string>();
                foreach (Match match in matches)
                    times.Add(match.Value);

                return times;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //Method to print Date
        public static List <String> FindDate (String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"\b\d{4}-\d{2}-\d{2}\b");
                List<String> dates = new List<string>();

                foreach (Match match in matches)
                    dates.Add(match.Value);

                return dates;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //Method to print any word that starts with "un"
        public static List<String> FindallWordsstartWithUn (String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"un\w+");
                List<String> words = new List<string>();

                foreach (Match match in matches)
                    words.Add(match.Value);

                return words;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //Method to check username
        public static bool IsValidUsername(string username)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(username);

                return Regex.IsMatch(username, @"^[a-zA-Z0-9]{4,12}$");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }

        }

        //Method to Match any HTML tag
        public static List<String> FindHTMLTags(String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"<\w+>.*?<\/\w+>");
                List<String> HTMLTags = new List<string>();

                foreach (Match match in matches)
                    HTMLTags.Add(match.Value);

                return HTMLTags;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //method to print all words that ends with question mark
        public static List<String> FindAllWordsEndingQuestionMark (String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"[^.?!]*\?");
                List<String> words = new List<string>();
                foreach (Match match in matches)
                    words.Add(match.Value);

                return words;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //method to extract file extensions
        public static List<String> FindAllFileExtention (String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"\.\w+");
                List<String> filesExtentions = new List<string>();

                foreach (Match match in matches)
                    filesExtentions.Add(match.Value);

                return filesExtentions;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }

        //method to extract file extensions
        public static List<String> FindAllURLs (String input)
        {
            try
            {
                //Safety check to check if input is null or whiteSpace
                HelperMethods.SafetyCheck(input);

                MatchCollection matches = Regex.Matches(input, @"https?:\/\/[^\s]+");
                List<String> URLs = new List<string>();

                foreach (Match match in matches)
                    URLs.Add(match.Value);

                return URLs;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<string>();
            }
        }


    }
}
