using AutoSDK.Extensions;
using AutoSDK.Naming.AnyOfs;
using AutoSDK.Serialization.Json;
using System.Collections.Immutable;

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
            context.Schema.Discriminator.Mapping.Count != 0)
        {
            discriminatorType = context.Children.FirstOrDefault(x => x.Hint == Hint.Discriminator)?.TypeData;
            discriminatorPropertyName = context.Schema.Discriminator.PropertyName.ToPropertyName();
        }

        var count = context.IsAnyOf
            ? context.Schema.AnyOf.Count
            : context.IsOneOf
                ? context.Schema.OneOf.Count
                : context.Schema.AllOf.Count;
        var properties = context.IsNamedAnyOfLike
            ? children.Select((x, i) => PropertyData.Default with
            {
                Type = x.TypeData,
                Name = SmartNamedAnyOfNames.ComputePropertyName(children, className, i),
                Summary = x.Schema.GetSummary(),
                DiscriminatorValue = context.Schema.Discriminator?.Mapping?
                    .FirstOrDefault(y =>
                        y.Value.Contains(x.Id) ||
                        (x.Schema.Properties.ContainsKey(context.Schema.Discriminator.PropertyName) &&
                         x.Schema.Properties[context.Schema.Discriminator.PropertyName].Enum.Count == 1 &&
                         x.Schema.Properties[context.Schema.Discriminator.PropertyName].Enum.FirstOrDefault()
                             ?.GetString() == y.Key))
                    .Key?.ToEnumValue(string.Empty, context.Settings).Name ?? string.Empty,
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
        if (context.IsNamedAnyOfLike &&
            !properties.IsEmpty &&
            properties.All(x => !string.IsNullOrWhiteSpace(x.DiscriminatorValue)))
        {
            properties = properties
                .Select(x => x with
                {
                    Name = x.DiscriminatorValue,
                })
                .ToImmutableArray().AsEquatableArray();
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
}