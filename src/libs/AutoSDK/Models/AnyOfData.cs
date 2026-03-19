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
        
        var children = context.Children
            .Where(x => x.Hint == (context.IsAnyOf
                ? Hint.AnyOf
                : context.IsOneOf
                    ? Hint.OneOf
                    : Hint.AllOf))
            .ToList();
        var className = context.Id.ToClassName();
        TypeData? discriminatorType = null;
        string? discriminatorPropertyName = null;

        if (context.Schema.Discriminator != null &&
            (context.Schema.Discriminator.Mapping?.Count ?? 0) != 0)
        {
            discriminatorType = context.Children.FirstOrDefault(x => x.Hint == Hint.Discriminator)?.TypeData;
            discriminatorPropertyName = (context.Schema.Discriminator.PropertyName ?? string.Empty).ToPropertyName()
                .ToCSharpName(context.Settings, context.Parent);
        }

        var count = context.IsAnyOf
            ? context.Schema.AnyOf?.Count ?? 0
            : context.IsOneOf
                ? context.Schema.OneOf?.Count ?? 0
                : context.Schema.AllOf?.Count ?? 0;
        var discriminatorPropName = context.Schema.Discriminator?.PropertyName ?? string.Empty;
        var properties = context.IsNamedAnyOfLike
            ? children.Select((x, i) =>
            {
                // Compute discriminator value from mapping, const, or single-enum
                var discriminatorValue = ComputeDiscriminatorValue(context, x, discriminatorPropName);

                // Fallback chain for property name:
                // 1. Discriminator const/enum value
                // 2. Schema title (if not same as enclosing type)
                // 3. Smart name (existing logic)
                // 4. Value{i+1} (inside SmartNamedAnyOfNames.ComputePropertyName fallback)
                var titleName = !string.IsNullOrWhiteSpace(x.Schema.Title)
                    ? x.Schema.Title!.ToClassName()
                    : null;
                var name = !string.IsNullOrWhiteSpace(discriminatorValue)
                    ? discriminatorValue
                    : titleName != null && !string.Equals(titleName, className, StringComparison.OrdinalIgnoreCase)
                        ? titleName
                        : SmartNamedAnyOfNames.ComputePropertyName(children, className, i);

                var resolvedSchema = x.Schema.ResolveIfRequired();
                var jsonPropertyNames = resolvedSchema.Properties != null
                    ? resolvedSchema.Properties.Keys.ToImmutableArray()
                    : ImmutableArray<string>.Empty;

                return PropertyData.Default with
                {
                    Type = x.TypeData,
                    Name = name,
                    Summary = x.Schema.GetSummary(),
                    DiscriminatorValue = discriminatorValue,
                    JsonPropertyNames = jsonPropertyNames.AsEquatableArray(),
                };
            }).ToImmutableArray().AsEquatableArray()
            : Enumerable
                .Range(1, count)
                .Select(i => PropertyData.Default with
                {
                    Name = $"Value{i}",
                    Type = TypeData.Default with
                    {
                        CSharpTypeRaw = $"T{i}",
                    },
                })
                .ToImmutableArray().AsEquatableArray();

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

        // 1. Try discriminator mapping (existing logic)
        var mappingValue = context.Schema.Discriminator?.Mapping?
            .FirstOrDefault(y =>
                y.Value.Reference?.Id?.Contains(child.Id) == true ||
                ((child.Schema.Properties?.ContainsKey(discriminatorPropName) ?? false) &&
                 (child.Schema.Properties![discriminatorPropName].Enum?.Count ?? 0) == 1 &&
                 (child.Schema.Properties[discriminatorPropName].Enum?.FirstOrDefault())
                     ?.GetString() == y.Key))
            .Key;
        if (!string.IsNullOrEmpty(mappingValue))
        {
            return mappingValue!.ToEnumValue(string.Empty, context.Settings).Name;
        }

        // 2. Try const value on the discriminator property
        if (child.Schema.Properties?.ContainsKey(discriminatorPropName) == true)
        {
            var discProp = child.Schema.Properties[discriminatorPropName];
            if (!string.IsNullOrEmpty(discProp.Const))
            {
                return discProp.Const!.ToEnumValue(string.Empty, context.Settings).Name;
            }

            // 3. Try single-enum value on the discriminator property
            if ((discProp.Enum?.Count ?? 0) == 1)
            {
                var enumValue = discProp.Enum?.FirstOrDefault()?.GetString();
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
        var names = properties.Select(x => x.Name).ToList();
        var duplicates = names
            .Select((name, i) => (name, i))
            .GroupBy(x => x.name, StringComparer.Ordinal)
            .Where(g => g.Count() > 1);

        foreach (var group in duplicates)
        {
            var suffix = 1;
            foreach (var (_, i) in group)
            {
                names[i] = $"{names[i]}{suffix++}";
            }
        }

        var hasChanges = false;
        for (var i = 0; i < properties.Length; i++)
        {
            if (properties[i].Name != names[i])
            {
                hasChanges = true;
                break;
            }
        }

        if (!hasChanges)
        {
            return properties;
        }

        return properties
            .Select((p, i) => p with { Name = names[i] })
            .ToImmutableArray()
            .AsEquatableArray();
    }
}