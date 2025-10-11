using Newtonsoft.Json;
using regax;
using System;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

static class Program
{
    static void Main(string[] args)
    {
        #region linq
        //string filePath = "C:\\Users\\My Laptop\\source\\repos\\REGEX_Tasks\\regax\\bin\\Debug\\net8.0\\HealthCare.json"; //مسار الملف
        //string jsonContent = File.ReadAllText(filePath);
        //if (!File.Exists(filePath))
        //{
        //    Console.WriteLine("File not found.");
        //    return;
        //}
        //else
        //{
        //    Console.WriteLine("File found.");
        //    var data = System.Text.Json.JsonSerializer.Deserialize<List<HealthCare>>(jsonContent);
        //    var first100 = data.Take(100).OrderBy(p => p.Sleep_Hours).ToList(); // take first 100 records and sort by sleep hours

        #region filter according to stress level & coffee intake and group by country
        //var peopleHighStreetAndTakeCofeeMoreThan3 = data.Where(p => p.Stress_Level == "High" && p.Coffee_Intake >= 3).GroupBy(p => p.Country).ToList();
        //foreach (var item1 in peopleHighStreetAndTakeCofeeMoreThan3.Take(100))
        //{
        //    Console.WriteLine($"Country: {item1.Key}, Count: {item1.Count()}");
        //    Console.WriteLine("--------------------------------------------------");
        //    foreach (var item2 in item1)
        //    {
        //        Console.WriteLine($"HeartRate: {item2.Heart_Rate}, Gender: {item2.Gender}, BMI: {item2.BMI}");
        //    }
        //    Console.WriteLine("--------------------------------------------------");
        //}

        #endregion

        #region filter according to age & BMI & gender and sort by age descending
        //var filteredData = data.Where(h => h.Age > 30 && h.BMI < 25 && h.Gender == "Female").OrderByDescending(p => p.Age).ToList(); // 
        //foreach (var item in filteredData.Take(100))
        //{
        //    Console.WriteLine($"Age:{item.Age}\t BMI:{item.BMI}\t StressLevel:{item.Stress_Level}\t");
        //}
        #endregion

        #region filter according to physical activity & sleep quality and group by occupation
        //var averageSleepHours = first100.Average(p => p.Sleep_Hours); // calculate average sleep hours
        //var minSleepHours = first100.Min(p => p.Sleep_Hours); // calculate min sleep hours
        //var maxSleepHours = first100.Max(p => p.Sleep_Hours); // calculate max sleep hours

        //for (int i = 0; i < first100.Count; i++)
        //{
        //    Console.WriteLine($"Sleep Hours: {first100[i].Sleep_Hours}");
        //}
        //Console.WriteLine("--------------------------------------------------");
        //Console.WriteLine($"Min Sleep Hours For above: {minSleepHours}");
        //Console.WriteLine($"maxSleepHours Sleep Hours For above: {maxSleepHours}");
        //Console.WriteLine($"Average Sleep Hours For above: {averageSleepHours}");
        #endregion

        #region group by sleep quality
        //var groubedBySleepQuality = first100.GroupBy( p => new {p.Sleep_Quality,p.Country} ); // group by sleep quality

        //foreach (var item1 in groubedBySleepQuality)
        //{
        //    Console.WriteLine($"Country: {item1.Key.Country}, Count: {item1.Count()}");
        //    Console.WriteLine("--------------------------------------------------");
        //    foreach (var item2 in item1)
        //    {
        //        Console.WriteLine($"Sleep Hours: {item2.Sleep_Hours}\tSleep_Quality{item2.Sleep_Quality}");
        //    }
        //    Console.WriteLine("--------------------------------------------------");
        //}

        #endregion
        //var DistinctAge = first100.Select(p => p.Age).Order().Distinct();
        //foreach (var item in DistinctAge)
        //{
        //    Console.WriteLine($"Age: {item}");
        //}

        #region something
        //var JapanCount = first100.Count(p => p.Country == "Japan");
        //var JapanCountry = first100.Where(p => p.Country == "Japan");
        //var GroupByJapan = first100.Where(p => p.Country == "Japan").GroupBy(p => p.Country).ToList();
        //foreach (var item1 in GroupByJapan)
        //{
        //    Console.WriteLine($"{item1.Key}");
        //    foreach (var item2 in item1)
        //    {
        //        Console.WriteLine($"{item2.Stress_Level}");
        //    }
        //}

        //var AverageCoffeeIntakeAndGroupByCountry = first100.GroupBy(p => p.Country)
        //    .Select(g => new
        //    {
        //        Country = g.Key,
        //        AverageCoffeeIntake = g.Average(p => p.Coffee_Intake)
        //    }).OrderByDescending(p => p.AverageCoffeeIntake).ToList();
        #endregion
        //    }
        #endregion

        #region readtoend
        //string path = @"D:\\New folder";
        //try
        //{
        //    List<string> files = Directory.GetFiles(path, "*.txt").ToList(); // get all text files in the directory

        //    foreach (var item in files)
        //    {
        //        try
        //        {
        //            string content = "";
        //            using (FileStream fs = new FileStream(item, FileMode.Open, FileAccess.Read)) ;
        //            using (StreamReader sr = new StreamReader(item, Encoding.UTF8))
        //            {

        //                content = sr.ReadToEnd();
        //            }

        //            var words = content.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        //            int wordCount = words.Length;
        //            int BaghdadCount = words.Count(w => w.Equals("بغداد", StringComparison.OrdinalIgnoreCase));

        //            Console.WriteLine($"File: {Path.GetFileName(item)}");
        //            Console.WriteLine($"Total Words: {wordCount}");
        //            Console.WriteLine($"Occurrences of 'Baghdad': {BaghdadCount}");
        //            Console.WriteLine("-----------------------------------");
        //        }
        //        catch (Exception exFile)
        //        {

        //            Console.WriteLine($"⚠️ Error while reading file {Path.GetFileName(item)}: {exFile.Message}");
        //        }


        //    }
        //}
        //catch (Exception ex)
        //{

        //    Console.WriteLine($"General Error: {ex.Message}");
        //}
        #endregion
        #region using ReadToLing    
        //string path = @"D:\\New folder";
        //try
        //{
        //    List<string> files = Directory.GetFiles(path, "*.txt").ToList(); // get all text files in the directory

        //    foreach (var item in files)
        //    {
        //        try
        //        {
        //            int wordCount = 0;
        //            int BaghdadCount = 0;

        //            using (FileStream fs = new FileStream(item, FileMode.Open, FileAccess.Read)) ;
        //            using (StreamReader sr = new StreamReader(item, Encoding.UTF8))
        //            {
        //                string line;
        //                while ((line = sr.ReadLine()) != null)
        //                {
        //                    var words = line.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        //                    wordCount += words.Length;
        //                    BaghdadCount += words.Count(w => w.Equals("بغداد", StringComparison.OrdinalIgnoreCase));
        //                }
        //            }

        //            Console.WriteLine($"File: {Path.GetFileName(item)}");
        //            Console.WriteLine($"Total Words: {wordCount}");
        //            Console.WriteLine($"Occurrences of 'Baghdad': {BaghdadCount}");
        //            Console.WriteLine("-----------------------------------");
        //        }
        //        catch (Exception exFile)
        //        {

        //            Console.WriteLine($"⚠️ Error while reading file {Path.GetFileName(item)}: {exFile.Message}");
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{

        //    Console.WriteLine($"General Error: {ex.Message}");
        //}
        #endregion
        #region Json to TXT
        //string jsonFilePath = "C:\\Users\\My Laptop\\source\\repos\\REGEX_Tasks\\regax\\bin\\Debug\\net8.0\\HealthCare.json"; //مسار الملف
        //string txtFilePath = "C:\\Users\\My Laptop\\source\\repos\\REGEX_Tasks\\regax\\bin\\Debug\\net8.0\\HealthCare.txt"; //مسار الملف
        //try
        //{
        //    string jsonData = File.ReadAllText(jsonFilePath);
        //    File.WriteAllText(txtFilePath, jsonData);
        //    Console.WriteLine("JSON data has been written to the text file successfully.");
        //}
        //catch (Exception)
        //{

        //    throw;
        //}
        #endregion
        #region linersearch and binary search
        //int size = 20;
        //int[] numbers = new int[size];
        //int no = 15;
        //for (int i = 0; i < size; i++)
        //{
        //    //numbers[i] = rand.Next(1, 100000); // Fill the array with random numbers
        //    numbers[i] = no + 15;
        //    no += 15;
        //}
        //foreach (var item in numbers)
        //{
        //    Console.WriteLine(item);
        //}
        ////int target = numbers[rand.Next(size)]; // Randomly select a target number from the array
        //int target = 406;
        ////Array.Sort(numbers); // Sort the array for binary search
        //int linearSteps, binarySteps;
        //var sw = System.Diagnostics.Stopwatch.StartNew();
        //int linearResult = LinearSearch(numbers, target, out linearSteps);
        //sw.Stop();
        //Console.WriteLine($"Linear Search: Target: {target} found at index {linearResult} in {linearSteps} steps, Time taken: {sw.ElapsedMilliseconds} ms");

        //sw.Restart();
        //int binaryResult = BinarySearch(numbers, target, out binarySteps);
        //sw.Stop();
        //Console.WriteLine($"Binary Search: Target: {target} found at index {binaryResult} in {binarySteps} steps, Time taken: {sw.ElapsedMilliseconds} ms");
        #endregion

        #region linked list
        LinkedList<int> numbers = new LinkedList<int>(); // Create a new linked list to hold integers
        //enter values from user
        Console.WriteLine("Enter integers to add to the linked list (type 'done' to finish):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;

            if (int.TryParse(input, out int value))
            {
                numbers.AddLast(value);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer or 'done' to finish.");
            }
        }
        linkedListHelper.PrintList(numbers); // Print the linked list in order and reverse order
        Console.WriteLine("Enter an integer to search in the linked list:");
        string intInput = Console.ReadLine();
        int searchValue = 0;
        int.TryParse(intInput, out searchValue);

        if (searchValue != 0)
        {
            int index = linkedListHelper.SearchNode(numbers, searchValue); //call function from Class helper
            if (index != -1)
            {
                Console.WriteLine($"Value {searchValue} found at index {index} in the linked list.");
            }
            else
            {
                Console.WriteLine($"Value {searchValue} not found in the linked list.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        //enter value at begin of linked list
        Console.WriteLine("Enter an integer to insert at the beginning of the linked list:");
        string intInput2 = Console.ReadLine();
        int insertValue = 0;
        int.TryParse(intInput2, out insertValue);
        if (insertValue != 0)
        {
            linkedListHelper.insestAtBeging(numbers, insertValue); //call function from Class helper
            Console.WriteLine($"Value {insertValue} has been inserted at the beginning of the linked list.");
            linkedListHelper.PrintList(numbers); // Print the linked list in order and reverse order
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        #endregion
    }

    static int BinarySearch(int[] arr, int target, out int steps)
    {

        steps = 0;
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            steps++;
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid; // Target found
            }
            else if (arr[mid] < target)
            {
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }
        if (target < arr[0])
            return left;
        else if (target > arr[arr.Length - 1])
            return right;
        else
            return -1; // Target not found


    }


    static int LinearSearch(int[] arr, int target, out int steps)
    {
        steps = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            steps++;
            if (arr[i] == target)
            {
                return i; // Target found
            }
        }
        return -1; // Target not found
    }


    public class HealthCare
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public float Coffee_Intake { get; set; }
        public float Caffeine_mg { get; set; }
        public float Sleep_Hours { get; set; }
        public string Sleep_Quality { get; set; }
        public float BMI { get; set; }
        public int Heart_Rate { get; set; }
        public string Stress_Level { get; set; }
        public float Physical_Activity_Hours { get; set; }
        public string Health_Issues { get; set; }
        public string Occupation { get; set; }
        public int Smoking { get; set; }
        public int Alcohol_Consumption { get; set; }
    }




}


