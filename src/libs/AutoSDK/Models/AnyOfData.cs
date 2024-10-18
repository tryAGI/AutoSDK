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
    //EquatableArray<(string, string)>? DiscriminatorMapping,
    bool IsTrimming,
    string Namespace,
    string Name,
    string Summary,
    EquatableArray<PropertyData> Properties,
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
        //IDictionary<string, string>? discriminatorMapping = null;
        
        if (context.Schema.Discriminator != null &&
            context.Schema.Discriminator.Mapping.Count != 0)
        {
            discriminatorType = context.Children.FirstOrDefault(x => x.Hint == Hint.Discriminator)?.TypeData;
            discriminatorPropertyName = context.Schema.Discriminator.PropertyName.ToPropertyName();
            
            // if (context.Schema.Discriminator.Mapping.Count == 0)
            // {
            //     if (children.All(x => 
            //         x.Children.FirstOrDefault(y => y.PropertyName == discriminatorPropertyName)?.GetDefaultValue() != null &&
            //         x.ClassName != null))
            //     {
            //         context.Schema.Discriminator.Mapping = children
            //             .ToDictionary(
            //                 x => x.GetDefaultValue()!,
            //                 x => x.ClassName);
            //     }
            // }
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
            //DiscriminatorMapping: discriminatorMapping?
            //    .Select(x => (x.Key, x.Value))
            //    .ToImmutableArray(),
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
            Properties: context.IsNamedAnyOfLike
                ? children.Select((x, i) => PropertyData.Default with
                {
                    Type = x.TypeData ?? TypeData.Default,
                    Name = useSmartNames && (x.TypeData ?? TypeData.Default).CSharpTypeWithoutNullability.StartsWith("global::System.", StringComparison.Ordinal) != true
                        ? SmartNamedAnyOfNames.ComputeSmartName(
                            (x.TypeData ?? TypeData.Default).ShortCSharpTypeWithoutNullability,
                            className)
                        : $"Value{i + 1}",
                    Summary = x.Schema.GetSummary(),
                    DiscriminatorValue = context.Schema.Discriminator?.Mapping?
                        .FirstOrDefault(y =>
                            y.Value.Contains(x.Id) ||
                            (x.Schema.Properties.ContainsKey(context.Schema.Discriminator.PropertyName) &&
                            x.Schema.Properties[context.Schema.Discriminator.PropertyName].Enum.FirstOrDefault()?.GetString() == y.Key))
                        .Key?.ToEnumValue(string.Empty, context.Settings).Name ?? string.Empty,
                }).ToImmutableArray()
                : ImmutableArray<PropertyData>.Empty,
            Settings: context.Settings);
    }
}