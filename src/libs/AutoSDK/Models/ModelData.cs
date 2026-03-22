using AutoSDK.Extensions;
using AutoSDK.Helpers;
using System.Collections.Immutable;

namespace AutoSDK.Models;

public record struct ModelData(
    SchemaContext SchemaContext,
    string Id,
    ImmutableArray<Box> Parents,
    string Namespace,
    Settings Settings,
    ModelStyle Style,
    ImmutableArray<PropertyData> Properties,
    ImmutableArray<PropertyData> EnumValues,
    string Summary,
    string Description,
    bool IsDeprecated,
    string DeprecationMessage,
    string BaseClass,
    bool IsBaseClass,
    bool IsDerivedClass,
    string DiscriminatorPropertyName,
    EquatableArray<(string ClassName, string Discriminator)> DerivedTypes
)
{
    public static ModelData FromSchemaContext(
        SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        // Collect parents without LINQ — walk up the tree
        var parentCount = 0;
        var parent = context.Parent;
        while (parent != null)
        {
            if (parent.ClassData.HasValue)
            {
                parentCount++;
            }
            parent = parent.Parent;
        }

        var boxedParents = ImmutableArray<Box>.Empty;
        if (parentCount > 0)
        {
            var builder = ImmutableArray.CreateBuilder<Box>(parentCount);
            // Walk again — fill from end to start for correct order
            var parentArray = new ModelData[parentCount];
            var idx = parentCount - 1;
            parent = context.Parent;
            while (parent != null)
            {
                if (parent.ClassData.HasValue)
                {
                    parentArray[idx--] = parent.ClassData!.Value;
                }
                parent = parent.Parent;
            }
            foreach (var p in parentArray)
            {
                builder.Add(p.Box());
            }
            boxedParents = builder.MoveToImmutable();
        }

        // Build DerivedTypes without LINQ
        var mapping = context.Schema.Discriminator?.Mapping;
        EquatableArray<(string ClassName, string Discriminator)> derivedTypes = default;
        if (mapping is { Count: > 0 })
        {
            var dtBuilder = ImmutableArray.CreateBuilder<(string ClassName, string Discriminator)>(mapping.Count);
            foreach (var kvp in mapping.OrderBy(x => x.Key, StringComparer.Ordinal))
            {
                dtBuilder.Add((ClassName: kvp.Value.Reference?.Id ?? string.Empty, Discriminator: kvp.Key));
            }
            derivedTypes = dtBuilder.MoveToImmutable().AsEquatableArray();
        }

        return new ModelData(
            SchemaContext: context,
            Id: context.Id,
            Parents: boxedParents,
            Namespace: context.Settings.Namespace,
            Style: context.Schema.IsEnum() ? ModelStyle.Enumeration : context.Settings.ModelStyle,
            Settings: context.Settings,
            Properties: GetVisibleProperties(context),
            EnumValues: context.Schema.IsEnum()
                ? ToImmutablePropertyDataArray(context.ComputeEnum())
                : [],
            Summary: context.Schema.GetSummary(),
            Description: context.Schema.Description ?? string.Empty,
            IsDeprecated: context.Schema.IsDeprecated(),
            DeprecationMessage: context.Schema.GetDeprecationMessage(),
            BaseClass: context.IsDerivedClass
                ? context.BaseClassContext.Id
                : string.Empty,
            IsBaseClass: context.IsBaseClass,
            IsDerivedClass: context.IsDerivedClass,
            DiscriminatorPropertyName: context.Schema.Discriminator?.PropertyName ?? string.Empty,
            DerivedTypes: derivedTypes
            );
    }

    private static ImmutableArray<PropertyData> GetVisibleProperties(SchemaContext context)
    {
        var source = context.IsDerivedClass
            ? context.DerivedClassContext.Children
            : !context.Schema.IsEnum()
                ? context.Children
                : null;

        if (source == null || source.Count == 0)
        {
            return [];
        }

        var discriminatorPropertyName = context.IsBaseClass
            ? context.Schema.Discriminator?.PropertyName
            : null;
        var hasDiscriminator = !string.IsNullOrWhiteSpace(discriminatorPropertyName);

        var builder = ImmutableArray.CreateBuilder<PropertyData>(source.Count);
        for (var i = 0; i < source.Count; i++)
        {
            var child = source[i];
            if (child is not { IsProperty: true, PropertyData: not null })
            {
                continue;
            }
            foreach (var prop in child.ComputedProperties)
            {
                if (!hasDiscriminator || prop.Id != discriminatorPropertyName)
                {
                    builder.Add(prop);
                }
            }
        }

        return DeduplicatePropertyNamesCaseInsensitive(builder.ToImmutable());
    }

    /// <summary>
    /// Safety net: detects C# property names that collide case-insensitively
    /// (e.g. FileName vs Filename) and appends numeric suffixes to duplicates.
    /// </summary>
    private static ImmutableArray<PropertyData> DeduplicatePropertyNamesCaseInsensitive(
        ImmutableArray<PropertyData> properties)
    {
        if (properties.Length <= 1) return properties;

        // Count case-insensitive occurrences
        var nameCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        for (var i = 0; i < properties.Length; i++)
        {
            nameCounts.TryGetValue(properties[i].Name, out var c);
            nameCounts[properties[i].Name] = c + 1;
        }

        // Check if any names collide case-insensitively
        var hasCaseCollision = false;
        foreach (var kvp in nameCounts)
        {
            if (kvp.Value > 1)
            {
                hasCaseCollision = true;
                break;
            }
        }
        if (!hasCaseCollision) return properties;

        // Rename colliders: first occurrence keeps its name, subsequent get numeric suffixes
        var suffixCounters = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var builder = ImmutableArray.CreateBuilder<PropertyData>(properties.Length);
        for (var i = 0; i < properties.Length; i++)
        {
            var prop = properties[i];
            if (nameCounts[prop.Name] > 1)
            {
                suffixCounters.TryGetValue(prop.Name, out var suffix);
                suffix++;
                suffixCounters[prop.Name] = suffix;
                if (suffix == 1)
                {
                    // First occurrence keeps original name
                    builder.Add(prop);
                }
                else
                {
                    builder.Add(prop with { Name = $"{prop.Name}{suffix}" });
                }
            }
            else
            {
                builder.Add(prop);
            }
        }
        return builder.MoveToImmutable();
    }

    private static ImmutableArray<PropertyData> ToImmutablePropertyDataArray(Dictionary<string, PropertyData> dict)
    {
        if (dict.Count == 0) return [];

        var builder = ImmutableArray.CreateBuilder<PropertyData>(dict.Count);
        foreach (var kvp in dict.OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            builder.Add(kvp.Value);
        }
        return builder.MoveToImmutable();
    }

    public string ClassName => Id;// Settings.NamingConvention switch
    // {
    //     NamingConvention.ConcatNames => Parents.IsEmpty ? Name : $"{Parents.Last().ClassName}{Name}",
    //     
    //     _ => string.Empty,
    // };

    public string GlobalClassName => $"global::{Namespace}.{ClassName}";

    public string ExternalClassName => Settings.NamingConvention switch
    {
        NamingConvention.ConcatNames => ClassName,
        NamingConvention.InnerClasses => string.Join(".", Parents.Select(x => x.Unbox<ModelData>().ClassName).Concat([ClassName])),
        _ => string.Empty,
    };

    public string FileNameWithoutExtension => $"{Namespace}.Models.{ExternalClassName}";
}
