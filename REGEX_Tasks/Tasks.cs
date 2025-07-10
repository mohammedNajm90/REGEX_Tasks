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
            // ارجع كل الكلمات الي تشبة النمط مال الايميل
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
            // ارجع كل الكلمات الي تشبة النمط مال الكلمات التي تبدي بحرف كبير
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
            // ارجع كل الكلمات الي تشبة النمط مال الأرقام
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
            // ارجع كل الكلمات الي تشبة النمط مال الكلمات التي تبدي بحرف #
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
        //--------------------------------------------Task 6------------------------------------------
        // دالة ترجع الكلمات التي تنتهي بـ ing
        public List<string> FindWordsEnding_ing(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() { "Null Or Empty" };
            }
            List<string> result = new List<string>();
            // ارجع كل الكلمات الي تشبة النمط مال الكلمات التنتهي ب ing
            MatchCollection match = Regex.Matches(inputText, @"\w+ing");
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
        //--------------------------------------------Task 7------------------------------------------
        // دالة ترجع الكلمات التي  هي صيغة المبالغ المالية
        public List<string> FindCurrencyAmounts(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() { "Null Or Empty" };
            }
            List<string> result = new List<string>();
            // ارجع كل الكلمات الي تشبة النمط مال كتابة مبلغ مالي
            MatchCollection match = Regex.Matches(inputText, @"\$\d+\.*\d*");
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
        //--------------------------------------------Task 8------------------------------------------
        // دالة ترجع الكلمات التي  هي صيغة المبالغ المالية
        public List<string> MatchTime(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() { "Null Or Empty" };
            }
            List<string> result = new List<string>();
            // ارجع كل الكلمات الي تشبة النمط مال كتابة وقت يعني ساعه : دقائق
            MatchCollection match = Regex.Matches(inputText, @"[0-2]?[0-3]:[0-5][0-9]");
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
        //--------------------------------------------Task 9------------------------------------------
        // دالة ترجع الكلمات التي  هي صيغة  التاريخ
        public List<string> MatchDates(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() { "Null Or Empty" };
            }
            List<string> result = new List<string>();
            // ارجع كل الكلمات الي تشبة النمط مال كتابة تاريخ سنه - شهر - يوم
            MatchCollection match = Regex.Matches(inputText, @"\d{4}-((0?\d)|(1[012]))-(([012]\d)|3[01])");
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
        //--------------------------------------------Task 10------------------------------------------
        // دالة ترجع  الكلمات التي  هي  كلمة عربية
        public List<string> MatchArabicWord(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() { "Null Or Empty" };
            }
            List<string> result = new List<string>();
            // ارجع كل الكلمات الي تشبة النمط مال كتابة حروف من الالف الى الياء
            MatchCollection match = Regex.Matches(inputText, @"[ا-ي]+");
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
        //--------------------------------------------Task 11------------------------------------------
        // دالة  الكلمات التي   الكلمات التي تبدأ بـ un
        public List<string> MatchWordStarts_un(string inputText)
        {
            //اجيك النص المدخل مو نل او فارغ
            if (checkStr(inputText))
            {
                return new List<string>() { "Null Or Empty" };
            }
            List<string> result = new List<string>();
            // ارجع كل الكلمات الي تشبة النمط مال اول حرفين هم un
            MatchCollection match = Regex.Matches(inputText, @"\b[un]\w+");
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
