using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.AnyOfs;

public static class SmartNamedAnyOfNames
{
    public static string ComputePropertyName(IList<SchemaContext> children, string className, int i)
    {
        var child = children.ElementAt(i);
        return ShouldUseSmartName(children, className)
            ? ComputeSmartName(
                GetCandidateName(child),
                className)
            : $"Value{i + 1}";
    }

    public static bool ShouldUseSmartName(IList<SchemaContext> children, string className)
    {
        return children.All(x =>
            !string.IsNullOrWhiteSpace(ComputeSmartName(GetCandidateName(x), className)));
    }

    public static string ComputeSmartName(TypeData typeData, string className)
    {
        return ComputeSmartName(typeData.ShortCSharpTypeWithoutNullability, className);
    }

    public static string ComputeSmartName(string typeName, string className)
    {
        if (string.IsNullOrWhiteSpace(typeName))
        {
            return string.Empty;
        }

        var nameWords = SplitToWordsByUpperCharacters(typeName);
        var classNameWords = SplitToWordsByUpperCharacters(className);
        var reducedName = string.Concat(
            nameWords.Except(classNameWords));

        return string.IsNullOrWhiteSpace(reducedName) || IsAnonymousVariantName(reducedName)
            ? typeName
            : reducedName;
    }

    public static string ComputeSmartNameForCombinedEnums(string[] names)
    {
        var words = names
            .SelectMany(SplitToWordsByUpperCharacters)
            .GroupBy(x => x)
            .Where(x => x.Count() == names.Length)
            .Select(x => x.Key)
            .ToArray();

        return string.Concat(words);
    }

    public static IReadOnlyList<string> SplitToWordsByUpperCharacters(string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        var words = new List<string>();
        var startIndex = 0;
        for (var i = 1; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                words.Add(text.Substring(startIndex, i - startIndex));
                startIndex = i;
            }
        }

        words.Add(text.Substring(startIndex));

        return words;
    }

    private static bool IsAnonymousVariantName(string text)
    {
        return text.StartsWith("Variant", StringComparison.Ordinal) &&
               text.Length > "Variant".Length &&
               text.AsSpan("Variant".Length).ToString().All(char.IsDigit);
    }

    private static string GetCandidateName(SchemaContext context)
    {
        var typeName = context.TypeData.ShortCSharpTypeWithoutNullability;
        if (LooksLikeGeneratedIdentifier(typeName))
        {
            return typeName;
        }

        return LooksLikeGeneratedIdentifier(context.Id)
            ? context.Id
            : string.Empty;
    }

    private static bool LooksLikeGeneratedIdentifier(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        if (!char.IsUpper(text[0]) && text[0] != '_')
        {
            return false;
        }

        for (var i = 1; i < text.Length; i++)
        {
            if (!char.IsLetterOrDigit(text[i]) && text[i] != '_')
            {
                return false;
            }
        }

        return true;
    }
}
