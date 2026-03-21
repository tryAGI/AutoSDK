using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Naming.AnyOfs;
using AutoSDK.Naming.Properties;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Models;

public record struct AnyOfData(
    string SubType,
    int Count,
    TypeData? DiscriminatorType,
    string? DiscriminatorPropertyName,
    bool IsTrimming,
    string Namespace,
    string Name,
    string Summary,
    EquatableArray<PropertyData> Properties,
    Settings Settings
)
{
    public bool IsNamed => !string.IsNullOrWhiteSpace(Name);
    
    public static AnyOfData FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        var targetHint = context.IsAnyOf
            ? Hint.AnyOf
            : context.IsOneOf
                ? Hint.OneOf
                : Hint.AllOf;

        // Collect matching children without LINQ
        var children = new List<SchemaContext>();
        for (var i = 0; i < context.Children.Count; i++)
        {
            if (context.Children[i].Hint == targetHint)
            {
                children.Add(context.Children[i]);
            }
        }

        var className = context.Id.ToClassName();
        TypeData? discriminatorType = null;
        string? discriminatorPropertyName = null;

        if (context.Schema.Discriminator != null &&
            (context.Schema.Discriminator.Mapping?.Count ?? 0) != 0)
        {
            for (var i = 0; i < context.Children.Count; i++)
            {
                if (context.Children[i].Hint == Hint.Discriminator)
                {
                    discriminatorType = context.Children[i].TypeData;
                    break;
                }
            }
            discriminatorPropertyName = (context.Schema.Discriminator.PropertyName ?? string.Empty).ToPropertyName()
                .ToCSharpName(context.Settings, context.Parent);
        }

        var count = context.IsAnyOf
            ? context.Schema.AnyOf?.Count ?? 0
            : context.IsOneOf
                ? context.Schema.OneOf?.Count ?? 0
                : context.Schema.AllOf?.Count ?? 0;
        var discriminatorPropName = context.Schema.Discriminator?.PropertyName ?? string.Empty;
        EquatableArray<PropertyData> properties;
        if (context.IsNamedAnyOfLike)
        {
            var builder = ImmutableArray.CreateBuilder<PropertyData>(children.Count);
            for (var i = 0; i < children.Count; i++)
            {
                var x = children[i];
                // Compute discriminator value from mapping, const, or single-enum
                var discriminatorValue = ComputeDiscriminatorValue(context, x, discriminatorPropName);

                var titleName = !string.IsNullOrWhiteSpace(x.Schema.Title)
                    ? x.Schema.Title!.ToClassName()
                    : null;
                var name = !string.IsNullOrWhiteSpace(discriminatorValue)
                    ? discriminatorValue
                    : titleName != null && !string.Equals(titleName, className, StringComparison.OrdinalIgnoreCase)
                        ? titleName
                        : SmartNamedAnyOfNames.ComputePropertyName(children, className, i);

                var resolvedSchema = x.Schema.ResolveIfRequired();
                var jsonPropertyNames = ImmutableArray<string>.Empty;
                if (resolvedSchema.Properties is { Count: > 0 } props)
                {
                    var jpnBuilder = ImmutableArray.CreateBuilder<string>(props.Count);
                    foreach (var key in props.Keys)
                    {
                        jpnBuilder.Add(key);
                    }
                    jsonPropertyNames = jpnBuilder.MoveToImmutable();
                }

                builder.Add(PropertyData.Default with
                {
                    Type = x.TypeData,
                    Name = name,
                    Summary = x.Schema.GetSummary(),
                    DiscriminatorValue = discriminatorValue,
                    JsonPropertyNames = jsonPropertyNames.AsEquatableArray(),
                });
            }
            properties = builder.MoveToImmutable().AsEquatableArray();
        }
        else
        {
            var builder = ImmutableArray.CreateBuilder<PropertyData>(count);
            for (var i = 1; i <= count; i++)
            {
                builder.Add(PropertyData.Default with
                {
                    Name = $"Value{i}",
                    Type = TypeData.Default with
                    {
                        CSharpTypeRaw = $"T{i}",
                    },
                });
            }
            properties = builder.MoveToImmutable().AsEquatableArray();
        }

        // Deduplicate property names
        if (context.IsNamedAnyOfLike && !properties.IsEmpty)
        {
            properties = DeduplicatePropertyNames(properties);
        }
        
        return new AnyOfData(
            SubType: context.IsAnyOf
                ? "AnyOf"
                : context.IsOneOf
                    ? "OneOf"
                    : "AllOf",
            Count: count,
            DiscriminatorType: discriminatorType,
            DiscriminatorPropertyName: discriminatorPropertyName,
            IsTrimming:
                context.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson &&
                (!string.IsNullOrWhiteSpace(context.Settings.JsonSerializerContext) ||
                 context.Settings.GenerateJsonSerializerContextTypes),
            Namespace: context.Settings.Namespace,
            Name: context.IsNamedAnyOfLike
                ? context.Id
                : string.Empty,
            Summary: context.IsNamedAnyOfLike
                ? context.Schema.GetSummary()
                : string.Empty,
            Properties: properties,
            Settings: context.Settings);
    }

    /// <summary>
    /// Computes the discriminator value for a child schema.
    /// Checks: discriminator mapping → const value on discriminator property → single-enum value.
    /// </summary>
    private static string ComputeDiscriminatorValue(
        SchemaContext context,
        SchemaContext child,
        string discriminatorPropName)
    {
        if (string.IsNullOrEmpty(discriminatorPropName))
        {
            return string.Empty;
        }

        // 1. Try discriminator mapping
        var mapping = context.Schema.Discriminator?.Mapping;
        if (mapping != null)
        {
            // Pre-check child discriminator property for single-enum matching
            string? childEnumStr = null;
            if (child.Schema.Properties?.ContainsKey(discriminatorPropName) == true)
            {
                var childDiscProp = child.Schema.Properties[discriminatorPropName];
                if ((childDiscProp.Enum?.Count ?? 0) == 1)
                {
                    childEnumStr = childDiscProp.Enum![0]?.GetString();
                }
            }

            foreach (var kvp in mapping)
            {
                if (kvp.Value.Reference?.Id?.Contains(child.Id) == true ||
                    (childEnumStr != null && childEnumStr == kvp.Key))
                {
                    return kvp.Key.ToEnumValue(string.Empty, context.Settings).Name;
                }
            }
        }

        // 2. Try const value on the discriminator property
        if (child.Schema.Properties?.TryGetValue(discriminatorPropName, out var discProp2) == true)
        {
            if (!string.IsNullOrEmpty(discProp2.Const))
            {
                return discProp2.Const!.ToEnumValue(string.Empty, context.Settings).Name;
            }

            // 3. Try single-enum value on the discriminator property
            if ((discProp2.Enum?.Count ?? 0) == 1)
            {
                var enumValue = discProp2.Enum![0]?.GetString();
                if (!string.IsNullOrEmpty(enumValue))
                {
                    return enumValue!.ToEnumValue(string.Empty, context.Settings).Name;
                }
            }
        }

        return string.Empty;
    }

    /// <summary>
    /// Deduplicates property names by appending index suffixes where names collide.
    /// </summary>
    private static EquatableArray<PropertyData> DeduplicatePropertyNames(
        EquatableArray<PropertyData> properties)
    {
        // Build name list and detect duplicates in a single pass
        var names = new string[properties.Length];
        var nameCounts = new Dictionary<string, int>(StringComparer.Ordinal);
        for (var i = 0; i < properties.Length; i++)
        {
            names[i] = properties[i].Name;
            nameCounts.TryGetValue(names[i], out var c);
            nameCounts[names[i]] = c + 1;
        }

        // Only process if there are actual duplicates
        var hasDuplicates = false;
        foreach (var kvp in nameCounts)
        {
            if (kvp.Value > 1)
            {
                hasDuplicates = true;
                break;
            }
        }
        if (!hasDuplicates)
        {
            return properties;
        }

        // Append suffixes to duplicate names
        var suffixes = new Dictionary<string, int>(StringComparer.Ordinal);
        for (var i = 0; i < names.Length; i++)
        {
            if (nameCounts[names[i]] > 1)
            {
                suffixes.TryGetValue(names[i], out var suffix);
                suffix++;
                suffixes[names[i]] = suffix;
                names[i] = $"{names[i]}{suffix}";
            }
        }

        var builder = ImmutableArray.CreateBuilder<PropertyData>(properties.Length);
        for (var i = 0; i < properties.Length; i++)
        {
            builder.Add(properties[i].Name != names[i]
                ? properties[i] with { Name = names[i] }
                : properties[i]);
        }
        return builder.MoveToImmutable().AsEquatableArray();
    }
}