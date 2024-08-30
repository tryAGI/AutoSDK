using System.Collections.Immutable;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Helpers;
using OpenApiGenerator.Core.Serialization.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct AnyOfData(
    string SubType,
    int Count,
    JsonSerializerType JsonSerializerType,
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
        var useSmartNames = children.All(x => x.Schema.Reference != null);
        var className = context.Id.ToClassName();
        
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
            JsonSerializerType: context.Settings.JsonSerializerType,
            IsTrimming:
                context.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson &&
                (!string.IsNullOrWhiteSpace(context.Settings.JsonSerializerContext) ||
                 context.Settings.GenerateJsonSerializerContextTypes),
            Namespace: context.IsComponent
                ? context.Settings.Namespace
                : "System",
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
                }).ToImmutableArray()
                : ImmutableArray<PropertyData>.Empty,
            Settings: context.Settings);
    }
}