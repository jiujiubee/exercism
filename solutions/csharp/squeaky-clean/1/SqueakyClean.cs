using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (identifier.Length == 0) return "";
        bool isKabab = false;
        StringBuilder sb = new StringBuilder();
        foreach (char c in identifier) {
            if (char.IsWhiteSpace(c)) sb.Append('_');
            else if (char.IsControl(c)) sb.Append("CTRL");
            else if (c == '-') isKabab = true;
            else if (!char.IsLetter(c) || char.IsBetween(c, 'α', 'ω')) continue;
            else if (isKabab) { sb.Append(char.ToUpperInvariant(c)); isKabab = false; }
            else sb.Append(c); 
        }
        return sb.ToString();
    }
}