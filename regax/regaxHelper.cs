using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regax
{
    public static class regaxHelper
    {
        static string FileNo1 = "D:\\FileNo1.txt"; //هذا هو مسار الملف الأول
        static string FileNo2 = "D:\\FileNo2.txt"; //هذا هو مسار الملف الثاني
        public static void WriteSMSintoFile(string message)
        {
            //هذه الدالة تقوم بكتابة رسالة نصية معينة بداخل ملف 
            try
            {
                using (StreamWriter writer = new StreamWriter(FileNo1, true))
                { // فتح الملف للكتابة، إذا لم يكن موجودًا سيتم إنشاؤه
                    writer.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public static void ReadSMSfromFile()
        {
            //هذه الدالة تقوم بقراءة محتويات الملف وعرضها على الشاشة
            try
            {
                using (StreamReader reader = new StreamReader(FileNo1))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("Content of the file:");
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }
        }

        public static void CopySMSfromFile1toFile2()
        {
            //هذه الدالة تقوم بنسخ محتويات الملف الأول إلى الملف الثاني
            try
            {
                using (StreamReader reader = new StreamReader(FileNo1)) // فتح الملف الأول للقراءة
                using (StreamWriter writer = new StreamWriter(FileNo2, false)) // فتح الملف الثاني للكتابة (إذا كان موجودًا سيتم الكتابة فوقه)
                {
                    string content = reader.ReadToEnd();
                    writer.Write(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error copying from file 1 to file 2: {ex.Message}");
            }
        }

        public static void MoveFileToNewFolder()
        {
            //هذه الدالة تقوم بنقل الملف الأول إلى مجلد جديد
            try
            {
                string newFolderPath = "D:\\NewFolder";
                if (!Directory.Exists(newFolderPath))
                {
                    Directory.CreateDirectory(newFolderPath);
                }

                string destinationFilePath = Path.Combine(newFolderPath, Path.GetFileName(FileNo1));
                File.Move(FileNo1, destinationFilePath);
                Console.WriteLine($"File moved to: {destinationFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error moving file: {ex.Message}");
            }
        }

        public static void DeleteFile()
        {
            //هذه الدالة تقوم بحذف الملف الأول
            try
            {
                if (File.Exists(FileNo2))
                {
                    File.Delete(FileNo2);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting file: {ex.Message}");
            }
        }
        public static void ListTxtFiles() {
            //هذه الدالة تقوم بعرض جميع الملفات النصية في المجلد
            try
            {
                string directoryPath = "D:\\";
                var txtFiles = Directory.GetFiles(directoryPath, "*.txt");

                Console.WriteLine("Text files in the directory:");
                foreach (var file in txtFiles)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error listing text files: {ex.Message}");
            }
        }
        public static void GetFileSize()
        {
            //هذا الدالة تقوم بعرض حجم الملف اذا كان موجود
            try
            {
                if (File.Exists(FileNo1))
                {
                    long fileSize = new FileInfo(FileNo1).Length;
                    Console.WriteLine($"File size: {fileSize} bytes");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting file size: {ex.Message}");
            }
        }
        public static void CountWordsInFile()
        {
            //هذه الدالة تقوم بعد الكلمات في الملف بعد تجيك المسار ل
            try
            {
                if (File.Exists(FileNo1))
                {
                    string content = File.ReadAllText(FileNo1);
                    int wordCount = content.Split(new char[] { ' ', '\n', '\r','.',';','!','?' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    Console.WriteLine($"Word count in the file: {wordCount}");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error counting words in file: {ex.Message}");
            }
        }

    }
}
