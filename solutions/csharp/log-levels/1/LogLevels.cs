static class LogLine
{
    public static string Message(string logLine) => logLine.Substring(logLine.IndexOf(':') + 1).Trim();

    public static string LogLevel(string logLine){
        var colonPos = logLine.IndexOf(":");
        var level = logLine.Substring(1, colonPos - 2);
        return level.ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
