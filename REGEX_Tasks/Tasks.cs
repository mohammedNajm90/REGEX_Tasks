using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection.Metadata.Ecma335;

namespace REGEX_Tasks
{
    internal class Tasks
    {
        // داله اجيك بيها هل السلسله هي مو فارغه ولا نل
        public bool checkStr(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;
            return false;
        }
        //--------------------------------------------Task 1------------------------------------------
        // دالة  استخراج أرقام الهواتف المحلية
        public bool MatchAllPhoneNumbers(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if(checkStr(inputText))
            {
                return false;
            }
            // ارجع ترو اذا كان اسيا او عراقنا او كورك حيث يبدي بمفتاح الشركه مع 8 ارقام
            return Regex.IsMatch(inputText, @"(079\d{8})|(077\d{8})|(075\d{8})") ? true : false;
        }
        //--------------------------------------------Task 2------------------------------------------
        // دالة  استخراج البريد الإلكتروني
        public List<string> ExtractEmails(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() {"Null Or Empty" };
            }
            List<string> result = new List<string>();  
            // ارجع كل الانماط الي تشبة النمط مال الايميل
            MatchCollection match = Regex.Matches(inputText, @"\w+@\w+\.\w+");
            // اتاكد انه لقى شي يبدي يضيفهن بقائمه حتى ارجعها
            if (match.Count > 0)
            {
                foreach (Match m in match)
                {
                    result.Add(m.Value);
                }
            }
            else
            {
                // اذا لم يجد شي يرجع نص ماكو
                result.Add("Not Found");
            }
            return result;
        }
        //--------------------------------------------Task 3------------------------------------------
        // دالة  إيجاد أسماء العلم كل اسم يبدي بحرف كبير
        public List<string> FindProperNouns(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() { "Null Or Empty" };
            }
            List<string> result = new List<string>();
            // ارجع كل الانماط الي تشبة النمط مال الكلمات التي تبدي بحرف كبير
            // b لبداية الكلمة ونهايتها
            MatchCollection match = Regex.Matches(inputText, @"\b[A-Z][a-zA-Z]*\b");
            // اتاكد انه لقى شي يبدي يضيفهن بقائمه حتى ارجعها
            if (match.Count > 0)
            {
                foreach (Match m in match)
                {
                    result.Add(m.Value);
                }
            }
            else
            {
                // اذا لم يجد شي يرجع نص ماكو
                result.Add("Not Found");
            }
            return result;
        }
        //--------------------------------------------Task 4------------------------------------------
        // دالة  إيجاد الأرقام
        public List<string> MatchAllNumbers(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() { "Null Or Empty" };
            }
            List<string> result = new List<string>();
            // ارجع كل الانماط الي تشبة النمط مال الأرقام
            MatchCollection match = Regex.Matches(inputText, @"\d+");
            // اتاكد انه لقى شي يبدي يضيفهن بقائمه حتى ارجعها
            if (match.Count > 0)
            {
                foreach (Match m in match)
                {
                    result.Add(m.Value);
                }
            }
            else
            {
                // اذا لم يجد شي يرجع نص ماكو
                result.Add("Not Found");
            }
            return result;
        }
        //--------------------------------------------Task 5------------------------------------------
        // دالة  استخراج الهاشتاغ
        public List<string> FindHashtags(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() { "Null Or Empty" };
            }
            List<string> result = new List<string>();
            // ارجع كل الانماط الي تشبة النمط مال الكلمات التي تبدي بحرف #
            // b لبداية الكلمة ونهايتها
            MatchCollection match = Regex.Matches(inputText, @"#\w+");
            // اتاكد انه لقى شي يبدي يضيفهن بقائمه حتى ارجعها
            if (match.Count > 0)
            {
                foreach (Match m in match)
                {
                    result.Add(m.Value);
                }
            }
            else
            {
                // اذا لم يجد شي يرجع نص ماكو
                result.Add("Not Found");
            }
            return result;
        }
    }
}
