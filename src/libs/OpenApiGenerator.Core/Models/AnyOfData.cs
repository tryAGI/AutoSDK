using System.Collections.Immutable;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct AnyOfData(
    string SubType,
    int Count,
    JsonSerializerType JsonSerializerType,
    bool IsTrimming,
    string Namespace,
    string Name,
    string Summary,
    ImmutableArray<PropertyData> Properties
)
{
    public static AnyOfData FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
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
                ? context.Children.Where(x => x.Hint == (context.IsAnyOf
                    ? Hint.AnyOf
                    : context.IsOneOf
                        ? Hint.OneOf
                        : Hint.AllOf)).ToList().ToAnyOfProperties(context.Id)
                : ImmutableArray<PropertyData>.Empty);
    }
}