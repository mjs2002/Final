
while (true)
{
    try
    {
        Console.Write("Enter your birthdate: ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        int Days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (birthDate.Year * 365 + birthDate.DayOfYear);
        int Years = Days / 365;
        string message = (Days >= 365) ? " Your age: " + Years + " years" : "Your age: " + Days + " days";
        Console.WriteLine(message);
    }
    catch
    {
        Console.WriteLine("You have entered an invalid date.\n");
    }
}