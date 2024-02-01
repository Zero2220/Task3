
Console.WriteLine("Task 1:");
IDictionary<string, DateTime> exams= new Dictionary<string, DateTime>();
DateTime examMath = new DateTime(2024,10,10,5,5,5,5);
exams.Add("Riyaziyyat",examMath);
TimeSpan timeSpan = examMath - DateTime.UtcNow;
foreach (var item in exams)
{
    Console.WriteLine("Fenn adi:  " + item.Key + "  Fenn tarixi: " + item.Value + "aradaki vaxt: " + timeSpan);
}
Console.WriteLine("==============================================================================================");







