using System.Globalization;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace AutoSDK.Extensions;

public static class StringExtensions
{
    /// <summary>
    /// Concatenates strings and cleans up line breaks at the beginning and end of the resulting string. <br/>
    /// Returns " " if collection is empty(to use with <see cref="RemoveBlankLinesWhereOnlyWhitespaces(string)"/>).
    /// </summary>
    /// <param name="values"></param>
    /// <param name="emptyValue"></param>
    /// <returns></returns>
    public static string Inject(this IEnumerable<string> values, string emptyValue = " ")
    {
        var text = string.Concat(values)
            .TrimStart('\r', '\n')
            .TrimEnd('\r', '\n');
        if (string.IsNullOrWhiteSpace(text))
        {
            return emptyValue;
        }

        return text;
    }
    
    /// <summary>
    /// Makes the first letter of the name uppercase.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static string ToPropertyName(this string input)
    {
        return input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => string.Empty,
#if NET6_0_OR_GREATER
            _ => string.Concat(input[0].ToString().ToUpper(CultureInfo.InvariantCulture), input.AsSpan(1)),
#else
            _ => input[0].ToString().ToUpper(CultureInfo.InvariantCulture) + input.Substring(1),
#endif
        };
    }
    
    /// <summary>
    /// Makes the first letter of the name lowercase.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static string ToParameterName(this string input)
    {
        return input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => string.Empty,
            "Event" => "@event",
            "event" => "@event",
            "Object" => "@object",
            "object" => "@object",
            "Namespace" => "@namespace",
            "namespace" => "@namespace",
#pragma warning disable CA1308 // Normalize strings to uppercase
#if NET6_0_OR_GREATER
            _ => string.Concat(input[0].ToString().ToLower(CultureInfo.InvariantCulture), input.AsSpan(1)),
#else
            _ => input[0].ToString().ToLower(CultureInfo.InvariantCulture) + input.Substring(1),
#endif
#pragma warning restore CA1308 // Normalize strings to uppercase
        };
    }
    
    /// <summary>
    /// Normalizes line endings to '\n' or your endings.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="newLine">'\n' by default</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string NormalizeLineEndings(
        this string text,
        string? newLine = null)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        var newText = text
            .Replace("\r\n", "\n")
            .Replace("\r", "\n");
        if (newLine != null)
        {
            newText = newText.Replace("\n", newLine);
        }

        return newText;
    }
    
    private static readonly char[] Separator = { '\n' };

    /// <summary>
    /// Removes blank lines where there are only spaces.
    /// Used to preserve formatting in code where lines of code may be missing based on conditions.
    /// Just return a string with spaces to remove it.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string RemoveBlankLinesWhereOnlyWhitespaces(this string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        return string.Join(
            separator: "\n",
            values: text
                .NormalizeLineEndings()
                .Split(Separator, StringSplitOptions.None)
                .Where(static line => line.Length == 0 || !line.All(char.IsWhiteSpace)));
    }
    
    public static string AsArray(this string type)
    {
        return $"global::System.Collections.Generic.IList<{type}>";
    }
    
    public static string? WithPostfix(this string? type, string postfix)
    {
        if (type == null)
        {
            return null;
        }
        
        return type + postfix;
    }
    
    public static string ToXmlDocumentation(
        this string text,
        int level = 4,
        bool returnIfSingleLine = false)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        
        var lines = text.Split(NewLine, StringSplitOptions.RemoveEmptyEntries);
        if (lines.Length == 0)
        {
            lines = [string.Empty];
        }
        
        if (returnIfSingleLine && lines.Length == 1)
        {
            return $"{lines[0]}";
        }
        
        var spaces = new string(' ', level);
        var value = string.Join("\n", lines
            .Select((line, i) => $"{spaces}/// {line}{(i != lines.Length - 1 ? "<br/>" : string.Empty)}"));
        
        return value;
    }
    
    public static string ToXmlDocumentationSummary(
        this string text,
        int level = 4)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        
        var spaces = new string(' ', level);
        var value = ToXmlDocumentation(text, level);
        
        return $@"/// <summary>
{value}
{spaces}/// </summary>";
    }
    
    public static string ToXmlDocumentationExample(
        this string text,
        int level = 4)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        
        if (string.IsNullOrWhiteSpace(text))
        {
            return string.Empty;
        }
        
        var value = ToXmlDocumentation(text, level, returnIfSingleLine: true);
        if (!value.Contains("\n"))
        {
            return $"/// <example>{value}</example>";
        }
        
        var spaces = new string(' ', level);
        
        return $@"/// <example>
{value}
{spaces}/// </example>";
    }
    
    public static string ToXmlDocumentationDefault(
        this string text,
        int level = 4)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        if (string.IsNullOrWhiteSpace(text))
        {
            return string.Empty;
        }
        
        var value = ToXmlDocumentation(text, level, returnIfSingleLine: true);
        if (!value.Contains("\n"))
        {
            return $"/// <default>{value}</default>";
        }
        
        var spaces = new string(' ', level);
        
        return $@"/// <default>
{value}
{spaces}/// </default>";
    }
    
    public static string ToXmlDocumentationForParam(
        this string text,
        string parameterName,
        int level = 4)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        parameterName = parameterName ?? throw new ArgumentNullException(nameof(parameterName));
        
        var spaces = new string(' ', level);
        var value = ToXmlDocumentation(text, level);
        
        return string.IsNullOrWhiteSpace(text)
            ? $@"/// <param name=""{parameterName.TrimStart('@')}""></param>"
            : $@"/// <param name=""{parameterName.TrimStart('@')}"">
{value}
{spaces}/// </param>";
    }
    
    public static string UseWordSeparator(
        this string propertyName,
        params char[] separator)
    {
        propertyName = propertyName ?? throw new ArgumentNullException(nameof(propertyName));
        
        if (!separator.Any(propertyName.Contains))
        {
            return propertyName;
        }
        
        return string.Join(
            string.Empty,
            propertyName
                .Split(separator)
                .Select(word => word.ToPropertyName()));
    }
    
    private readonly static string[] NewLine = { "\n" };
    
    public static string AddIndent(
        this string text,
        int level)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        if (level < 1)
        {
            return text;
        }
        
        var lines = text.Split(NewLine, StringSplitOptions.None);
        var spaces = new string(' ', level * 4);
        
        return string.Join("\n", lines
            .Select(line => string.IsNullOrEmpty(line) ? line : $"{spaces}{line}"));
    }
    
    public static string FixPropertyName(
        this string propertyName,
        string className)
    {
        return propertyName == className
            ? $"{propertyName}1"
            : propertyName;
    }
    
    public static string ToClassName(
        this string text)
    {
        return text
            .ToPropertyName()
            .UseWordSeparator('_', '-', '.', ' ', '\\', '/', '[', ']');
    }
    
    public static string ReplaceIfEquals(
        this string text,
        string oldValue,
        string newValue)
    {
        return text == oldValue
            ? newValue
            : text;
    }
    
    /// <summary>
    /// Returns the first “word” of a string.
    /// A word = sequence of letters up to the first:
    ///   • space / tab / underscore, or
    ///   • Camel/Pascal-case boundary (lower → upper).
    /// </summary>
    public static string FirstWord(this string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        int end = text!.Length;

        // 1️⃣ Stop at obvious separators
        int sep = text.IndexOfAny([' ', '\t', '_']);
        if (sep >= 0) end = sep;

        // 2️⃣ Detect camel/pascal boundary (…aB… → break before B)
        for (int i = 1; i < end; i++)
            if (char.IsLower(text[i - 1]) && char.IsUpper(text[i]))
            {
                end = i;
                break;
            }

        return text.Substring(0, end);
    }
}