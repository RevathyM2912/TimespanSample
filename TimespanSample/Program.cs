internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(3);

            var duration = end - start;
            Console.WriteLine($"Duration : {duration}");

            //Properties of TimeSpan
            var timeSpan = new TimeSpan(1, 30, 2);
            Console.WriteLine($"Minutes : {timeSpan.Minutes}");
            Console.WriteLine($"Total minutes : {timeSpan.TotalMinutes}");
            Console.WriteLine($"Total hours : {timeSpan.TotalHours}");

            //Add

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}