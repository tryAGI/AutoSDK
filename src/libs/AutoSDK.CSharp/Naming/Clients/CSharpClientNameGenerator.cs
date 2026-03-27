using System.Collections.ObjectModel;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Naming.Properties;
using Microsoft.OpenApi;

namespace AutoSDK.Naming.Clients;

public static class CSharpClientNameGenerator
{
    public static IReadOnlyDictionary<string, Tag> ResolveTags(
        CSharpSettings settings,
        IEnumerable<OpenApiTag> tags)
    {
        tags = tags ?? throw new ArgumentNullException(nameof(tags));

        var distinctTags = tags
            .Where(tag => tag.Name != null)
            .GroupBy(tag => tag.Name!, StringComparer.Ordinal)
            .Select(group => group
                .OrderBy(tag => tag.Description ?? string.Empty, StringComparer.Ordinal)
                .First())
            .ToArray();

        var resolvedTags = new Dictionary<string, Tag>(StringComparer.Ordinal);
        foreach (var group in distinctTags
                     .GroupBy(tag => GeneratePropertyName(settings, tag), StringComparer.OrdinalIgnoreCase))
        {
            var orderedTags = group
                .OrderBy(tag => tag.Name ?? string.Empty, StringComparer.Ordinal)
                .ThenBy(tag => tag.Description ?? string.Empty, StringComparer.Ordinal)
                .ToArray();

            var baseName = GeneratePropertyName(settings, orderedTags[0]);
            for (var i = 0; i < orderedTags.Length; i++)
            {
                var tag = orderedTags[i];
                var safeName = i == 0
                    ? baseName
                    : $"{baseName}{i + 1}";

                resolvedTags[tag.Name!] = CSharpTagFactory.FromTag(tag, settings, safeName);
            }
        }

        return new ReadOnlyDictionary<string, Tag>(resolvedTags);
    }

    public static string Generate(Tag tag)
    {
        return $"{tag.SafeName}Client";
    }

    public static string Generate(CSharpSettings settings, OpenApiTagReference tag)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        return $"{GeneratePropertyName(settings, tag)}Client";
    }

    public static string GeneratePropertyName(CSharpSettings settings, OpenApiTagReference tag)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        return GeneratePropertyName(settings, tag.Name);
    }

    public static string GeneratePropertyName(CSharpSettings settings, Tag tag)
    {
        return tag.SafeName;
    }

    public static string Generate(CSharpSettings settings, OpenApiTag tag)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        return $"{GeneratePropertyName(settings, tag)}Client";
    }

    public static string GeneratePropertyName(CSharpSettings settings, OpenApiTag tag)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        return GeneratePropertyName(settings, tag.Name);
    }

    public static string GeneratePropertyName(CSharpSettings settings, string? tagName)
    {
        var name = new string((tagName ?? string.Empty)
            .SkipWhile(c => !char.IsDigit(c) && !char.IsLetter(c))
            .ToArray());

        return CSharpPropertyNameGenerator.SanitizeName(name.ToClassName(), settings.ClsCompliantEnumPrefix);
    }
}
