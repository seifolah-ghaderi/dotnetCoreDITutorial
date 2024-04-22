namespace Tools
{
    public class SeifLogger
    {
        public void Log(string message)
        { Console.WriteLine($"Logging-{DateTime.Now}: {message}"); }
    }
}