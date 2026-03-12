using System.Text.RegularExpressions;
public class LogParser
{
    public bool IsValidLine(string text) => Regex.IsMatch(text, @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]");

    public string[] SplitLogLine(string text) => Regex.Split(text, @"<[\\^*=\\-]+>");
    
    public int CountQuotedPasswords(string lines) => Regex.Count(lines, @"^.*"".*p.*a.*s.*s.*w.*o.*r.*d.*"".*$", RegexOptions.IgnoreCase | RegexOptions.Multiline);

    public string RemoveEndOfLineText(string line) => Regex.Replace(line, @"end-of-line\d+", "");

    public string[] ListLinesWithPasswords(string[] lines)
    {
        var regx = new Regex(@"\bpassword\w+\b", RegexOptions.IgnoreCase);
        return lines
            .Select(line =>
            {
                var match = regx.Match(line);
                return match.Success ? $"{match}: {line}" : $"--------: {line}";
            })
            .ToArray();
        
    }
}
