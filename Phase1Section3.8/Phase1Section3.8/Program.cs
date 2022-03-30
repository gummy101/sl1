// See https://aka.ms/new-console-template for more information
DoApp();

void DoApp()
{
    DateTime now = DateTime.Now;
    Console.WriteLine("Current date and time are " + now.ToString());
    Console.WriteLine("Default short date string " + now.ToShortDateString());
    Console.WriteLine("Default short time string " + now.ToShortTimeString());
    Console.WriteLine("Default long date string " + now.ToLongDateString());
    Console.WriteLine("Custom Date strings ");
    Console.WriteLine("Year string " + now.ToString("yyyy"));
    Console.WriteLine("Year string " + now.ToString("y"));
    Console.WriteLine("Month string " + now.ToString("MMM"));
    Console.WriteLine("date string " + now.ToString("dd"));
    Console.WriteLine("date string " + now.ToString("d"));
    Console.WriteLine("date string " + now.ToString("D"));
    Console.WriteLine("full date string " + now.ToString("F"));
    Console.WriteLine("date format string " + now.ToString("MM-dd-yyyy"));
    Console.WriteLine("Year string " + now.ToString("dddd, MMMMM d yyyy"));

    Console.WriteLine("Add 5 days " + now.AddDays(5).ToShortDateString());
    Console.WriteLine("Subtract 5 days " + now.AddDays(-5).ToShortDateString());

    DateTime date1 = new DateTime(2022, 1, 4, 4, 0, 15);
    DateTime date2 = new DateTime(2022, 1, 2, 14, 0, 15);
    TimeSpan time1 = date1 - date2;
    Console.WriteLine($"Timespan between date1 and date2 is {time1.Days} days and {time1.Hours} hours = {time1.TotalHours} total hours");


}