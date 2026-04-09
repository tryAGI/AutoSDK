using System.Collections.Generic;

namespace AutoSDK.Models;

public record struct Tag(
    string Name,
    string Description,
    string DisplayName,
    string Summary,
    string ParentName,
    string Kind,
    Settings GlobalSettings,
    string SafeName,
    string SingularizedName
)
{
    public static Tag Empty => new(
        Name: string.Empty,
        Description: string.Empty,
        DisplayName: string.Empty,
        Summary: string.Empty,
        ParentName: string.Empty,
        Kind: string.Empty,
        GlobalSettings: Settings.Default,
        SafeName: string.Empty,
        SingularizedName: string.Empty);

    public string DocumentationSummary
    {
        get
        {
            var parts = new List<string>();
            AddDistinctSentence(parts, DisplayName);
            AddDistinctSentence(parts, Summary);
            AddDistinctSentence(parts, Description);

            if (!string.IsNullOrWhiteSpace(ParentName))
            {
                parts.Add(EnsureSentence($"Parent tag: {ParentName.Trim()}"));
            }

            if (!string.IsNullOrWhiteSpace(Kind))
            {
                parts.Add(EnsureSentence($"Kind: {Kind.Trim()}"));
            }

            return string.Join(" ", parts);
        }
    }

    private static void AddDistinctSentence(List<string> parts, string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return;
        }

        var normalized = value!.Trim();
        foreach (var part in parts)
        {
            if (string.Equals(part.TrimEnd('.', '!', '?'), normalized.TrimEnd('.', '!', '?'), StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
        }

        parts.Add(EnsureSentence(normalized));
    }

    private static string EnsureSentence(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        var trimmed = value.Trim();
        var last = trimmed[trimmed.Length - 1];
        return last is '.' or '!' or '?'
            ? trimmed
            : trimmed + ".";
    }
}
