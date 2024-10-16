using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Models;

public readonly record struct AnyOfData(
    string SubType,
    int Count,
    TypeData? DiscriminatorType,
    string? DiscriminatorPropertyName,
    IDictionary<string, string>? DiscriminatorMapping,
    bool IsTrimming,
    string Namespace,
    string Name,
    string Summary,
    ImmutableArray<PropertyData> Properties,
    Settings Settings
)
{
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
        var useSmartNames = children.All(x =>
            x.Schema.Reference != null &&
            !string.IsNullOrWhiteSpace(SmartNamedAnyOfNames.ComputeSmartName(
                (x.TypeData ?? TypeData.Default).ShortCSharpTypeWithoutNullability,
                className)));
        TypeData? discriminatorType = null;
        string? discriminatorPropertyName = null;
        IDictionary<string, string>? discriminatorMapping = null;
        
        if (context.Schema.Discriminator != null)
        {
            discriminatorType = children.FirstOrDefault(x => x.Hint == Hint.Discriminator)?.TypeData;
            discriminatorPropertyName = context.Schema.Discriminator.PropertyName;
            discriminatorMapping = context.Schema.Discriminator.Mapping;
        }
        
        return new AnyOfData(
            SubType: context.IsAnyOf
                ? "AnyOf"
                : context.IsOneOf
                    ? "OneOf"
                    : "AllOf",
            Count: context.IsAnyOf
                ? context.Schema.AnyOf.Count
                : context.IsOneOf
                    ? context.Schema.OneOf.Count
                    : context.Schema.AllOf.Count,
            DiscriminatorType: discriminatorType,
            DiscriminatorPropertyName: discriminatorPropertyName,
            DiscriminatorMapping: discriminatorMapping,
            IsTrimming:
                context.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson &&
                (!string.IsNullOrWhiteSpace(context.Settings.JsonSerializerContext) ||
                 context.Settings.GenerateJsonSerializerContextTypes),
            Namespace: context.Settings.Namespace,
            Name: context.IsComponent
                ? context.Id
                : string.Empty,
            Summary: context.IsComponent
                ? context.Schema.GetSummary()
                : string.Empty,
            Properties: context.IsComponent
                ? children.Select((x, i) => PropertyData.Default with
                {
                    Type = x.TypeData ?? TypeData.Default,
                    Name = useSmartNames
                        ? SmartNamedAnyOfNames.ComputeSmartName(
                            (x.TypeData ?? TypeData.Default).ShortCSharpTypeWithoutNullability,
                            className)
                        : $"Value{i + 1}",
                    Summary = x.Schema.GetSummary(),
                }).ToImmutableArray()
                : ImmutableArray<PropertyData>.Empty,
            Settings: context.Settings);
    }
}