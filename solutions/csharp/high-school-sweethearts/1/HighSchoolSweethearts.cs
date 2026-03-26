using System.Globalization;
using System.Xml.Linq;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string name1, string name2)
    {
        var message = $"{name1} ♡ {name2}";
        var totalPadding = 61 - message.Length;
        var leftPadding = totalPadding / 2;
        return message.PadLeft(message.Length + leftPadding - 1).PadRight(61);
    }
    public static string DisplayBanner(string studentA, string studentB)
    {
        var top = @"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
";
        var middle = $"**     {studentA} +  {studentB}    **\n";
        var bottom = @" **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
";
        return top + middle + bottom;
    }


    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours) => string.Format(new CultureInfo("de-DE"),
        "{0} and {1} have been dating since {2:d} - that's {3:N2} hours",
        studentA, studentB, start, hours);
}
