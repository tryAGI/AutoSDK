using System.Collections.Immutable;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

/// <summary>
/// Detects schemas shaped as <c>type: array, items: oneOf[{type: string, enum: [...]}, {type: object, properties: {type: {const: "X"}, ...}}, ...]</c>
/// and emits a typed polymorphic-format hierarchy (abstract base + bare-string subclasses + typed object subclasses)
/// when <see cref="CSharpSettings.GeneratePolymorphicArrayHelpers"/> is enabled.
/// </summary>
public static partial class Sources
{
    /// <summary>A single bare-string variant of a polymorphic-format hierarchy (e.g. <c>"markdown"</c>).</summary>
    internal sealed class StringFormatVariant
    {
        public StringFormatVariant(string discriminatorValue, string className, string summary)
        {
            DiscriminatorValue = discriminatorValue;
            ClassName = className;
            Summary = summary;
        }

        public string DiscriminatorValue { get; }
        public string ClassName { get; }
        public string Summary { get; }
    }

    /// <summary>A single typed-object variant of a polymorphic-format hierarchy (e.g. <c>{ type: "json", schema, prompt }</c>).</summary>
    internal sealed class ObjectFormatVariant
    {
        public ObjectFormatVariant(
            string discriminatorValue,
            string className,
            ImmutableArray<FormatVariantProperty> properties,
            string summary)
        {
            DiscriminatorValue = discriminatorValue;
            ClassName = className;
            Properties = properties;
            Summary = summary;
        }

        public string DiscriminatorValue { get; }
        public string ClassName { get; }
        public ImmutableArray<FormatVariantProperty> Properties { get; }
        public string Summary { get; }
    }

    /// <summary>One property emitted on a typed object variant.</summary>
    internal sealed class FormatVariantProperty
    {
        public FormatVariantProperty(
            string jsonName,
            string csharpName,
            string csharpType,
            bool isRequired,
            string summary)
        {
            JsonName = jsonName;
            CSharpName = csharpName;
            CSharpType = csharpType;
            IsRequired = isRequired;
            Summary = summary;
        }

        public string JsonName { get; }
        public string CSharpName { get; }
        public string CSharpType { get; }
        public bool IsRequired { get; }
        public string Summary { get; }
    }

    /// <summary>A detected polymorphic-format hierarchy that can be emitted as a typed C# file.</summary>
    internal sealed class PolymorphicFormatMatch
    {
        public PolymorphicFormatMatch(
            string baseClassName,
            string fileNameWithoutExtension,
            string summary,
            ImmutableArray<StringFormatVariant> stringVariants,
            ImmutableArray<ObjectFormatVariant> objectVariants)
        {
            BaseClassName = baseClassName;
            FileNameWithoutExtension = fileNameWithoutExtension;
            Summary = summary;
            StringVariants = stringVariants;
            ObjectVariants = objectVariants;
        }

        public string BaseClassName { get; }
        public string FileNameWithoutExtension { get; }
        public string Summary { get; }
        public ImmutableArray<StringFormatVariant> StringVariants { get; }
        public ImmutableArray<ObjectFormatVariant> ObjectVariants { get; }
    }

    /// <summary>
    /// Walks <paramref name="schemas"/>, returns one <see cref="PolymorphicFormatMatch"/> per
    /// schema whose shape matches the polymorphic-array pattern. Pure / side-effect free.
    /// </summary>
    internal static IReadOnlyList<PolymorphicFormatMatch> DetectPolymorphicFormatMatches(
        IReadOnlyList<SchemaContext> schemas)
    {
        schemas = schemas ?? throw new ArgumentNullException(nameof(schemas));

        var matches = new List<PolymorphicFormatMatch>();
        var seenBaseNames = new HashSet<string>(StringComparer.Ordinal);

        foreach (var schemaContext in schemas)
        {
            if (TryDetectPolymorphicFormatMatch(schemaContext, seenBaseNames, out var match))
            {
                matches.Add(match!);
            }
        }

        return matches;
    }

    internal static bool TryGetPolymorphicFormatMatch(
        SchemaContext schemaContext,
        out PolymorphicFormatMatch? match)
    {
        return TryDetectPolymorphicFormatMatch(
            schemaContext,
            seenBaseNames: null,
            out match);
    }

    private static bool TryDetectPolymorphicFormatMatch(
        SchemaContext schemaContext,
        HashSet<string>? seenBaseNames,
        out PolymorphicFormatMatch? match)
    {
        match = null;

        // Match the items schema directly: it must be the items of an array AND carry the oneOf shape.
        if (schemaContext.Parent is null ||
            schemaContext.Hint != Hint.ArrayItem)
        {
            return false;
        }

        var itemsSchema = schemaContext.Schema.ResolveIfRequired();
        if (itemsSchema.OneOf is not { Count: > 0 } ||
            schemaContext.Children.Count == 0)
        {
            return false;
        }

        // Gather string-enum + object-with-type-const variants. The pattern only fires when we have
        // BOTH at least one bare-string variant AND at least one typed-object variant.
        var stringVariants = new List<StringFormatVariant>();
        var objectVariants = new List<ObjectFormatVariant>();
        foreach (var variant in schemaContext.Children)
        {
            if (variant.Hint != Hint.OneOf)
            {
                continue;
            }

            if (TryClassifyStringEnumVariant(variant, stringVariants))
            {
                continue;
            }

            if (TryClassifyObjectVariant(variant, objectVariants))
            {
                continue;
            }

            // Unknown variant shape -> bail out; this isn't the polymorphic-format pattern.
            return false;
        }

        if (stringVariants.Count == 0 || objectVariants.Count == 0)
        {
            return false;
        }

        var baseClassName = DerivePolymorphicFormatBaseName(schemaContext);
        if (string.IsNullOrWhiteSpace(baseClassName) ||
            (seenBaseNames != null && !seenBaseNames.Add(baseClassName)))
        {
            return false;
        }

        var summary = (itemsSchema.Description ?? schemaContext.Parent.Schema.Description ?? string.Empty)
            .Replace("\r", string.Empty)
            .Replace("\n", " ")
            .Trim();

        match = new PolymorphicFormatMatch(
            baseClassName: baseClassName,
            fileNameWithoutExtension: $"{schemaContext.Settings.Namespace}.Models.{baseClassName}",
            summary: summary,
            stringVariants: stringVariants.ToImmutableArray(),
            objectVariants: objectVariants.ToImmutableArray());

        return true;
    }

    private static bool TryClassifyStringEnumVariant(
        SchemaContext variantContext,
        List<StringFormatVariant> stringVariants)
    {
        var effectiveContext = variantContext.ResolvedReference ?? variantContext;
        var variant = effectiveContext.Schema.ResolveIfRequired();
        if (!variant.IsEnum() ||
            variant.Enum is not { Count: > 0 } enumValues)
        {
            return false;
        }

        foreach (var enumValue in enumValues)
        {
            var raw = enumValue?.GetString();
            if (string.IsNullOrWhiteSpace(raw))
            {
                continue;
            }

            stringVariants.Add(new StringFormatVariant(
                discriminatorValue: raw!,
                className: SanitizeVariantClassName(raw!) + "Format",
                summary: variant.Description?.Trim() ?? string.Empty));
        }

        return true;
    }

    private static bool TryClassifyObjectVariant(
        SchemaContext variantContext,
        List<ObjectFormatVariant> objectVariants)
    {
        var effectiveContext = variantContext.ResolvedReference ?? variantContext;
        var variant = effectiveContext.Schema.ResolveIfRequired();
        if (variant.Properties is not { Count: > 0 } properties ||
            !properties.TryGetValue("type", out var typeProperty))
        {
            return false;
        }

        var typeSchema = typeProperty.ResolveIfRequired();
        var discriminator = ExtractStringDiscriminator(typeSchema);
        if (string.IsNullOrWhiteSpace(discriminator))
        {
            return false;
        }

        var variantProperties = new List<FormatVariantProperty>();
        foreach (var propertyContext in effectiveContext.Children)
        {
            if (propertyContext.Hint != Hint.Property ||
                string.Equals(propertyContext.PropertyName, "type", StringComparison.Ordinal))
            {
                continue;
            }

            var resolvedProperty = propertyContext.Schema.ResolveIfRequired();
            variantProperties.Add(new FormatVariantProperty(
                jsonName: propertyContext.PropertyName ?? string.Empty,
                csharpName: propertyContext.PropertyData?.Name
                    ?? ToPropertyIdentifier(propertyContext.PropertyName ?? string.Empty),
                csharpType: !string.IsNullOrWhiteSpace(propertyContext.PropertyData?.Type.CSharpType)
                    ? propertyContext.PropertyData!.Value.Type.CSharpType
                    : !string.IsNullOrWhiteSpace(propertyContext.TypeData.CSharpType)
                        ? propertyContext.TypeData.CSharpType
                        : "object?",
                isRequired: propertyContext.PropertyData?.IsRequired
                    ?? (variant.Required?.Contains(propertyContext.PropertyName ?? string.Empty) == true),
                summary: resolvedProperty.GetSummary()));
        }

        objectVariants.Add(new ObjectFormatVariant(
            discriminatorValue: discriminator!,
            className: SanitizeVariantClassName(discriminator!) + "Format",
            properties: variantProperties.ToImmutableArray(),
            summary: variant.Description?.Trim() ?? string.Empty));

        return true;
    }

    private static string? ExtractStringDiscriminator(IOpenApiSchema typeSchema)
    {
        if (!string.IsNullOrWhiteSpace(typeSchema.Const))
        {
            return typeSchema.Const;
        }

        if (typeSchema.Enum is { Count: 1 } singleEnum &&
            singleEnum[0]?.GetString() is { Length: > 0 } value)
        {
            return value;
        }

        return null;
    }

    /// <summary>
    /// Derives a stable base-class name from the array-items context. Prefers a component name when
    /// available, falls back to the parent class + property name. Returns <c>string.Empty</c> when
    /// neither path yields a stable identifier (which causes the match to be skipped).
    /// </summary>
    private static string DerivePolymorphicFormatBaseName(SchemaContext itemsContext)
    {
        var parent = itemsContext.Parent;
        if (parent is null)
        {
            return string.Empty;
        }

        // Component-level array: <ComponentName>Item
        if (!string.IsNullOrWhiteSpace(parent.ComponentId))
        {
            return SanitizeVariantClassName(parent.ComponentId!) + "Item";
        }

        // Property-on-component: <ParentClassName><PropertyName>Item
        if (!string.IsNullOrWhiteSpace(parent.PropertyName))
        {
            var grandparent = parent.Parent;
            var ownerName = grandparent?.ComponentId ?? grandparent?.ClassName ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(ownerName))
            {
                return SanitizeVariantClassName(ownerName) +
                       SanitizeVariantClassName(parent.PropertyName!) + "Item";
            }
        }

        return string.Empty;
    }

    private static string SanitizeVariantClassName(string raw)
    {
        var cleaned = raw
            .Replace('.', '_')
            .Replace('-', '_')
            .Replace('/', '_')
            .Replace(' ', '_');
        return cleaned.ToPropertyName();
    }

    private static string ToPropertyIdentifier(string jsonName)
    {
        return SanitizeVariantClassName(jsonName);
    }
}
