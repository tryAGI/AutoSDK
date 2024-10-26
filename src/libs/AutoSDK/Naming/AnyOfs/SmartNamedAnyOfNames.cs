using AutoSDK.Models;

namespace AutoSDK.Naming.AnyOfs;

public static class SmartNamedAnyOfNames
{
    public static string ComputePropertyName(IList<SchemaContext> children, string className, int i)
    {
        return ShouldUseSmartName(children, className)
            ? ComputeSmartName(
                children.ElementAt(i).TypeData,
                className)
            : $"Value{i + 1}";
    }
    
    public static bool ShouldUseSmartName(IList<SchemaContext> children, string className)
    {
        return children.All(x =>
            x.Schema.Reference != null &&
            !string.IsNullOrWhiteSpace(ComputeSmartName(x.TypeData, className)) &&
            x.TypeData.CSharpTypeWithoutNullability.StartsWith("global::System.", StringComparison.Ordinal) != true);
    }
    
    public static string ComputeSmartName(TypeData typeData, string className)
    {
        var typeName = typeData.ShortCSharpTypeWithoutNullability;
        var nameWords = SplitToWordsByUpperCharacters(typeName);
        var classNameWords = SplitToWordsByUpperCharacters(className);

        // Combine the unique strings from both collections
        return string.Concat(
            nameWords.Except(classNameWords));
    }
    
    public static string ComputeSmartNameForCombinedEnums(string[] names)
    {
        var words = names
            .SelectMany(SplitToWordsByUpperCharacters)
            .GroupBy(x => x)
            .Where(x => x.Count() == names.Length)
            .Select(x => x.Key)
            .ToArray();
        
        // Combine the repeated words from all names
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
}