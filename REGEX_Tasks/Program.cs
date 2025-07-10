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

////task6
//res = task.FindWordsEnding_ing("I am coding, running, and learning.");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

////task7
//res = task.FindCurrencyAmounts("I spent $100 on food and $29.99 on drinks.");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

////task8
//res = task.MatchTime("The meeting is at 3:59.");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

////task9
//res = task.MatchDates("Today is 2025-7-10");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

////task10
//res = task.MatchArabicWord("Test String: هذه كلمة عربية.");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

//task11
//res = task.MatchWordStarts_un("Test String: unknown, xcv unhappy, unlocked");
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

////task13
//Console.WriteLine("Test String: 'Ali123' " + task.isValidUserName("Ali123"));

//task14
res = task.MatchHTMLTag("Test String: <div>Hello</div>");
foreach (string s in res)
{
    Console.WriteLine(s);
}
