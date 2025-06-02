using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Properties;

public static class CSharpPropertyNameGenerator
{
    public static string ComputePropertyName(
        SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var propertyName = context.PropertyName ?? throw new InvalidOperationException("Property name or parameter name is required.");

        var name = propertyName.ToPropertyName();

        name = HandleWordSeparators(name);

        if (context.Parent != null)
        {
            name = name.FixPropertyName(context.Parent.Id);
        }

        name = SanitizeName(name, context.Settings.ClsCompliantEnumPrefix, true);

        return name;
    }

    internal static string SanitizeName(string? name, string clsCompliantEnumPrefix, bool skipHandlingWordSeparators = false)
    {
        static bool InvalidFirstChar(char ch)
            => ch is not ('_' or >= 'A' and <= 'Z' or >= 'a' and <= 'z');

        static bool InvalidSubsequentChar(char ch)
            => ch is not (
                '_'
                or >= 'A' and <= 'Z'
                or >= 'a' and <= 'z'
                or >= '0' and <= '9'
                );

        if (name is null || name.Length == 0)
        {
            return "";
        }

        if (!skipHandlingWordSeparators)
        {
            name = HandleWordSeparators(name);
        }

        if (name.Length == 0)
        {
            return string.IsNullOrWhiteSpace(clsCompliantEnumPrefix)
                ? "_"
                : clsCompliantEnumPrefix;
        }

        if (InvalidFirstChar(name[0]))
        {
            name = (string.IsNullOrWhiteSpace(clsCompliantEnumPrefix)
                ? "_"
                : clsCompliantEnumPrefix) + name;
        }

        if (!name.Skip(1).Any(InvalidSubsequentChar))
        {
            return name;
        }

        Span<char> buf = stackalloc char[name.Length];
        name.AsSpan().CopyTo(buf);

        for (var i = 1; i < buf.Length; i++)
        {
            if (InvalidSubsequentChar(buf[i]))
            {
                buf[i] = '_';
            }
        }

        // Span<char>.ToString implementation checks for char type, new string(&buf[0], buf.length)
        return buf.ToString();
    }

    internal static string HandleWordSeparators(string name)
    {
        return name
            .ReplacePlusAndMinusOnStart()
            .UseWordSeparator('_', '+', '-', '/', '(', '[', ']', ')');
    }

    /// <summary>
    /// Parses the text and returns a C# namespace and a name.
    /// The namespace is onyl the part of the namespace that is maybe used inside the openapi spec.
    /// It doesn't include the namespace that is defined in the settings.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="settings"></param>
    /// <param name="parent"></param>
    /// <returns></returns>
    internal static (string, string) ToCSharpName(this string text, Settings settings, SchemaContext? parent)
    {
        //var name = text.ToPropertyName();

        //var name = HandleWordSeparators(text);

        //if (parent != null)
        //{
        //name = name.FixPropertyName(parent.Id);
        //}
        var name = text;
        var splittedName = name.Split('.');
        return (
            SanitizeName(string.Join(".", splittedName), string.Empty, true),
            SanitizeName(splittedName.Last(), settings.ClsCompliantEnumPrefix, true)
        );
    }
}