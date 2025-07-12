using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Regex
{
    internal class Class1
    {
        //1. Match all phone numbers in a local format like 0790xxxxxxx
        public static string LocalFormat()
        {// بداية الرقم:0790 بعدها اي 7 ارقام 
            string pattern = @"0790\d{7}";
            Match match= Regex.Match("My number is 07901234567.\r\n", pattern);
            return match.Value;
        }
        //2.Match all email addresses
        public static string IsEmail()
        {
            //حرف واحد على الاقل ثم علامة @ بعدها gmail او yahoo ثم بعدها .com
            string pattern = @"\w+@(gmail|yahoo)\.com";
            Match match = Regex.Match("Contact me at ali@gmail.com or support@halal.io\r\n", pattern);
            return match.Value;
        }
        //3.Match any word that starts with a capital letter
        public static void WordStartsWhCapitalLetter()
        {//   حرف كبير واحد ثم حرف واحد او اكثر صغير\b لحدود الكلمة  
            string pattern = @"\b[A-Z][a-z]+\b";
            MatchCollection matches = Regex.Matches("Ali went to Basra and met Noor.", pattern);
           

            foreach (Match match in matches)
            {
               Console.WriteLine(match.Value);
            }

            


        }
        //4. Match all numbers (integers only)
        public static void IntegersNumbers()
        {// رقم واحد او اكثر
            string pattern = @"\b\d+\b";
            MatchCollection matches = Regex.Matches(" I have 2 cats and 10 chickens.", pattern);
            foreach(Match match in matches)
            {
               Console.WriteLine( match.Value);
            }
          

        }
        //5.Match all hashtags
        public static void Hashtags()
        {// و بعده لا يوجد شيء او عدد من الاحرف # 
            string pattern = @"#\w*";
            MatchCollection matches = Regex.Matches("#blessed #codingLife", pattern);
            foreach( Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
           
        }
        //6.Match all words ending in "ing"
        public static void WordsEndingWithING()
        {// نهاية الكلمة ing حرف واحد او اكثر يتبعها مقطع 
            string pattern = @"[A-Za-z]+ing\b";
            MatchCollection matches = Regex.Matches(" I am coding, running, and learning.", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }

        }
        //7. Find all currency amounts ($100, $29.99)
        public static void Amounts()
        {// يبدأ المقطع ب $ ثم رقم واحد او اكثر و ينتهي المقطع او يتبعه مقطع يتكون من . بعدها رقمان 
            string pattern = @"\$\d+(\.\d{2})?";
            MatchCollection matches = Regex.Matches("I spent $100 on food and $29.99 on drinks.", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //8.Match time like 12:30 or 04:55
        public static void Time()
        {// رقمان ثم : ثم رقمين
            string pattern = @"\d{2}:\d{2}";
            MatchCollection matches = Regex.Matches("The meeting is at 12:30.", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //9. Match dates like 2025-07-10
        public static void Dates()
        {// أربع ارقام للسنة ثم يتبعها - و بعدها رقمين للشهر ثم- تليها رقمان لليوم
            string pattern = @"\d{4}-\d{2}-\d{2}";
            MatchCollection matches = Regex.Matches("Today is 2025-07-10.", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //10.Match a single Arabic word
        public static string ArabicWord()
        {// حرفان عربيان فاكثر تعتبر كلمة عربية
            string pattern = @"\b[اأب-ي]{2,}\b";

            Match match = Regex.Match(" هذه كلمة عربية", pattern);
            return match.Value;
        }
        //11.Match any word that starts with “un”
        public static void WordStartWithUN()
        {//   يليه حرف صغير او اكثرun  تبدأ الكلمة  بمقطع 
            string pattern = @"\bun[a-z]+";
            MatchCollection matches = Regex.Matches(" unknown, unhappy, unlocked", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //12.Match all Kurdish words
        public static void KurdishWords()
        {// اذا كانت الكلمة تتكون من حرف كوردي واحد او اكثر تعتبر كلمة كوردية
            string pattern = @"\b[ءئئەبپتجچحخدڕرژزسشعغفڤقکڵلمنوهیێۆە]+\b";
            MatchCollection matches = Regex.Matches(" ئەمە وشەیەکی کوردییە", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //13.Validate a username (alphanumeric, 4–12 chars)
        public static bool IsValidateUsername()
        {// يجب ان يحتويالمقطع على ارقام او احرف كبيرة او صغيرة و لا يحتوي على فراغات و يكون طوله من 4الى 12 حرف
            string pattern = @"^[0-9A-Za-z]{4,12}$";
            return Regex.IsMatch("Ali123", pattern);
            
        }
        //14. Match any HTML tag
        public static void HTMLTag()
        {//يبدا بعلامة < ثم اي شيء عدا هذه العلامة و ينتهي >ب
            string pattern = @"<[^>]+>";
            MatchCollection matches = Regex.Matches(" <div>Hello</div>", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //15.Match any sentence ending with a question mark
        public static void SentencendingWithQuestionMark()
        {//يبدا باي شيء عدا علامة ؟ و علامة! ثم يليها علامة؟ و يمكن ان تنتهي بفراغ 
            string pattern = @"[^.!?]*\?\s*";
            MatchCollection matches = Regex.Matches("How are you? Is this okay?", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //16.Find duplicate words
        public static void DuplicateWords()
        {//اذا كانت الكلمة تبدا بحرف واحد او اكثر ثم يليها فراغ واحد او اكثر ثم تعاد هذه السلسلو تعتبر كلمة مكررة
            string pattern = @"\b(\w+)\s+\1\b";

            MatchCollection matches = Regex.Matches("this is is a test", pattern);

            foreach (Match match in matches)
            {
               Console.WriteLine (match.Value);
            }

        }
        //17.Extract file extensions (.jpg, .pdf)
        public static void FileExtensions()
        {//حرف او رقم واحد فاكثر يليها نقطة و مقطع يدل على نوع الملف
            string pattern = @"\w+\.(jpg|pdf){1}\b";
            MatchCollection matches = Regex.Matches(" photo.jpg, resume.pdf", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //18.Match Iraqi license plates (e.g., ب 12345)
        public static void IraqiLicensePlates()
        {// اي حرف عربي ثم فراغ ثم 5 ارقام
            string pattern = @"^[اأب-ي]\s\d{5}$";
            MatchCollection matches = Regex.Matches("ب 12345", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //19. Find words with diacritics (Arabic harakat)
        public static void ArabicHarakat()
        {//حرف واحد او اكثر او لا شيء ثم الحركات ثم حرف واحد او  اكثر او لا شيء
            string pattern = @"\w*[\u064B-\u0652]+\w*";
            MatchCollection matches = Regex.Matches(" تَجْرِبَةٌ", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //20.Extract URLs
        public static void ExtractURLs()
        {// يبدا ب http:// او https:// ثم يتبعها اي شيء و تنتهي بفراغ 
            string pattern = @"\b(http://|https://).+\s";
            MatchCollection matches = Regex.Matches(" Visit https://halal.io today!", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //21. Validate strong password

        public static bool IsStrongPassword()
        {//اي حرف كبير كان او صغير و اي رقم و اي علامة و يتكون من 12 فأكثر
            string pattern = @"[A-Za-z\d@#!%]{12,}";
            return Regex.IsMatch("xdfgy7667uijn@", pattern);
           
        }
        //22.Match emojis 
        public static void MatchEmojis()
        {
            string pattern = @"[\u1F600-\u1F64F\u1F300-\u1F5FF\u1F680-\u1F6FF\u2600-\u26FF\u2700-\u27BF]";
            MatchCollection matches = Regex.Matches("😊 ❤️ 🔥", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //23.Match valid IPv4 addresses
        public static void IPv4addresses()
        {
            string pattern = @"[0-255]\.[0-255]\.[0-255]\.[0-255]";
            MatchCollection matches = Regex.Matches("192.168.0.1", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //24.Find Quran surah references
        public static void QuranSurahReferences()
        {// رقم من مرتبة الى ثلاث مراتب يليه : ثم رقم اخر من مرتبة الى ثلاث مراتب
            string pattern = @"\b\d{1,3}:\d{1,3}\b";
            MatchCollection matches = Regex.Matches("  See 2:255 for Ayat al-Kursi", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }

        //25.Match numbers in Arabic numerals (١٢٣٤٥)

        public static void ArabicNumerals()
        {//  رقم واحد او اكثر باللغة العربية
            string pattern = @"[٠-٩]+";
            MatchCollection matches = Regex.Matches(" سعره ١٢٣ د.ع", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //26.Match repeated character sequences

        public static void RepeatedCharacter()
        {// حرف واحد او اكثر كبير او صغير ثم يتكرر
            string pattern = @"([A-Za-z]+)\1";
            MatchCollection matches = Regex.Matches("loooool, yessss", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //27.Extract Quranic Basmalah only
        public static void QuranicBasmalah()
        {
            string pattern = @"بسم الله الرحمن الرحيم";
            MatchCollection matches = Regex.Matches(" بسم الله الرحمن الرحيم", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //28. Match IBAN numbers

        public static void IBANNumbers()
        {//حرفان ثم رقمان ثم يليها حروف او ارقام من 10 الى 30
            string pattern = @"^[A-Z]{2}[0-9]{2}[A-Z0-9]{10,30}$";
            MatchCollection matches = Regex.Matches("IQ44NBIQ123456789012345 ", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //29. Extract YouTube video ID
        public static void YouTubeVideoID()
        {//https://www.youtube.com/  يبدا ب 
            // يليه حرف او رقم او اكثر مع وجود رموز او بدون رموز
            string pattern = @"^https://www.youtube.com/\w+(?|=|%)*$";
            MatchCollection matches = Regex.Matches("https://www.youtube.com/watch?v=abc123xyz ", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
        //30.Match JSON key-value pairs

        public static void JSONKeyValuePairs()
        {
            string pattern = @"""([^""]+)""\s*:\s*((""[^""]*"")|(\d+)|true|false|null)";
            MatchCollection matches = Regex.Matches(@" { ""name"": ""Ali"", ""age"": ""30"" }", pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);

            }
        }
    }
}
