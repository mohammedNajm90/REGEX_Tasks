using Newtonsoft.Json;
using regax;
using System;
using System.Globalization;
using System.Text.Json;
using System.Xml.Linq;

static class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\My Laptop\\source\\repos\\REGEX_Tasks\\regax\\bin\\Debug\\net8.0\\HealthCare.json"; //مسار الملف
        string jsonContent = File.ReadAllText(filePath);
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }
        else
        {
            Console.WriteLine("File found.");
            var data = System.Text.Json.JsonSerializer.Deserialize<List<HealthCare>>(jsonContent);
            var first100 = data.Take(100).OrderBy(p => p.Sleep_Hours).ToList(); // take first 100 records and sort by sleep hours

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

            var JapanCount = first100.Count(p => p.Country == "Japan");
            var JapanCountry = first100.Where(p => p.Country == "Japan");
            var GroupByJapan = first100.Where(p => p.Country == "Japan").GroupBy(p => p.Country).ToList();
            foreach (var item1 in GroupByJapan)
            {
                Console.WriteLine($"{item1.Key}");
                foreach (var item2 in item1)
                {
                    Console.WriteLine($"{item2.Stress_Level}");
                }
            }

            var AverageCoffeeIntakeAndGroupByCountry = first100.GroupBy(p => p.Country)
                .Select(g => new
                {
                    Country = g.Key,
                    AverageCoffeeIntake = g.Average(p => p.Coffee_Intake)
                }).OrderByDescending(p => p.AverageCoffeeIntake).ToList();
        }
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

public class People
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
    public string mac { get; set; }
    public string creditcard { get; set; }
}
