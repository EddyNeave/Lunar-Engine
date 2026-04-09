namespace Intersect.Client.Framework.General;

public static class VariableTextResolver
{
    public static Dictionary<string, string> VariableValues { get; set; } = new();

    public static string Resolve(string text)
    {
        if (string.IsNullOrEmpty(text) || !text.Contains(@"\pv{"))
            return text;

        return System.Text.RegularExpressions.Regex.Replace(
            text,
            @"\\pv\{([^}]+)\}",
            match => VariableValues.TryGetValue(match.Groups[1].Value, out var val) ? val : "0"
        );
    }
}