// السلام عليكم يا ابطال كل واحد يسوي برانش باسمه ويبدي يحل 


using REGEX_Tasks;

Tasks task = new Tasks();


//Console.WriteLine("Match all phone numbers in a local format " + task.MatchAllPhoneNumbers("My number is 07601234567"));
List<string> res = new List<string>();
//res = task.ExtractEmails("Contact me at aliexample.com or supporthalal.io");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

////task3
//res = task.FindProperNouns("Contact me at Ali example.com or  .io");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

////task4
//res = task.MatchAllNumbers("I have 2 cats and 10 chickens");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

////task5
//res = task.FindHashtags("I have #blessed #codingLife cats and 10 chickens");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}
//task6
res = task.FindWordsEnding_ing("I am coding, running, and learning.");
foreach (string s in res)
{
    Console.WriteLine(s);
}

