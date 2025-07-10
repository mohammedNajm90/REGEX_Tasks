// السلام عليكم يا ابطال كل واحد يسوي برانش باسمه ويبدي يحل 


using REGEX_Tasks;

Tasks task = new Tasks();


//Console.WriteLine("Match all phone numbers in a local format " + task.MatchAllPhoneNumbers("My number is 07601234567"));
List<string> res = new List<string>();
res = task.ExtractEmails("Contact me at aliexample.com or supporthalal.io");
foreach (string s in res)
{
    Console.WriteLine(s);
}
