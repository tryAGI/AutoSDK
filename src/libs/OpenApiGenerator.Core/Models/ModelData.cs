using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct ModelData(
    KeyValuePair<string, OpenApiSchema> Schema,
    string Id,
    bool AddTypeName,
    ImmutableArray<ModelData> Parents,
    string TargetFramework,
    string Namespace,
    NamingConvention NamingConvention,
    ModelStyle Style,
    JsonSerializerType JsonSerializerType,
    SdkFeatureUsage UseRequiredKeyword,
    ImmutableArray<PropertyData> Properties,
    string Summary,
    ImmutableArray<ModelData> AdditionalModels,
    ImmutableArray<ModelData> Enumerations
)
{
    public static IList<ModelData> WithModelName(
        IList<OpenApiSchema> schemas,
        string key,
        Settings settings,
        bool addTypeName,
        params ModelData[] parents)
    {
        return schemas
            .Select(x => FromSchema(x.WithKey(key), settings, parents) with
            {
                AddTypeName = addTypeName
            })
            .ToArray();
    }
    
    public static ModelData FromKey(
        string key,
        Settings settings,
        params ModelData[] parents)
    {
        return new ModelData(
            Schema: default,
            Id: key,
            AddTypeName: false,
            Parents: parents.ToImmutableArray(),
            TargetFramework: settings.TargetFramework,
            Namespace: settings.Namespace,
            NamingConvention: settings.NamingConvention,
            JsonSerializerType: settings.JsonSerializerType,
            UseRequiredKeyword: settings.UseRequiredKeyword,
            Style: settings.ModelStyle,
            Properties: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            AdditionalModels: ImmutableArray<ModelData>.Empty,
            Enumerations: ImmutableArray<ModelData>.Empty
        );
    }
    
    public static ModelData FromSchema(
        KeyValuePair<string, OpenApiSchema> schema,
        Settings settings,
        params ModelData[] parents)
    {
        var model = new ModelData(
            Schema: schema,
            Id: schema.Key,
            AddTypeName: false,
            Parents: parents.ToImmutableArray(),
            TargetFramework: settings.TargetFramework,
            Namespace: settings.Namespace,
            NamingConvention: settings.NamingConvention,
            JsonSerializerType: settings.JsonSerializerType,
            UseRequiredKeyword: settings.UseRequiredKeyword,
            Style: settings.ModelStyle,
            Properties: ImmutableArray<PropertyData>.Empty,
            Summary: schema.Value.GetSummary(),
            AdditionalModels: ImmutableArray<ModelData>.Empty,
            Enumerations: ImmutableArray<ModelData>.Empty
            );

        var requiredProperties = new HashSet<string>(schema.Value.Required);
        var innerParents = parents.Concat([model]).ToArray();
        
        return model with
        {
            Properties = schema.Value.Properties
                .Select(x => PropertyData.FromSchema(
                    schema: x,
                    requiredProperties: requiredProperties,
                    parameterLocation: null,
                    parameterStyle: null,
                    parameterExplode: null,
                    settings: settings,
                    parents: innerParents))
                .ToImmutableArray(),
            AdditionalModels = schema.Value.Properties
                .Select(x => FromSchema(x, settings, innerParents))
                .Concat(schema.Value.Properties.SelectMany(x => x.Value.Items != null && x.Value.Items.IsObjectWithoutReference()
                    ? new []{ FromSchema(x.Value.Items.WithKey(x.Key), settings, innerParents) }
                    : Array.Empty<ModelData>()))
                .Where(static x => x.Schema.Value.IsObjectWithoutReference())
                .Concat(schema.Value.Properties
                    .SelectMany(x => WithModelName(x.Value.AnyOf, x.Key, settings, addTypeName: true, innerParents))
                    .Where(static x => x.Schema.Value.IsObjectWithoutReference()))
                .Concat(schema.Value.Properties
                    .SelectMany(x => WithModelName(x.Value.AllOf, x.Key, settings, addTypeName: true, innerParents))
                    .Where(static x => x.Schema.Value.IsObjectWithoutReference()))
                .Concat(schema.Value.Properties
                    .SelectMany(x => WithModelName(x.Value.OneOf, x.Key, settings, addTypeName: true, innerParents))
                    .Where(static x => x.Schema.Value.IsObjectWithoutReference()))
                .ToImmutableArray(),
            Enumerations = schema.Value.Properties
                .Select(x => FromSchema(x, settings, innerParents))
                .Where(static x => x.Schema.Value.IsEnum())
                .Concat(schema.Value.Properties
                    .SelectMany(x => WithModelName(x.Value.AnyOf, x.Key, settings, addTypeName: false, innerParents))
                    .Where(static x => x.Schema.Value.IsEnum()))
                .Concat(schema.Value.Properties
                    .SelectMany(x => WithModelName(x.Value.AllOf, x.Key, settings, addTypeName: false, innerParents))
                    .Where(static x => x.Schema.Value.IsEnum()))
                .Concat(schema.Value.Properties
                    .SelectMany(x => WithModelName(x.Value.OneOf, x.Key, settings, addTypeName: false, innerParents))
                    .Where(static x => x.Schema.Value.IsEnum()))
                .Select(x => x with
                {
                    Style = ModelStyle.Enumeration,
                    Properties = x.Schema.Value.Enum
                        .Select(value => value.ToEnumValue())
                        .ToImmutableArray(),
                })
                .ToImmutableArray()
        };
    }
    
    public string Name => Id
        .ToPropertyName()
        .UseWordSeparator('_', '-') + 
        (!AddTypeName || Schema.Value == null || string.IsNullOrWhiteSpace(Schema.Value.Type)
            ? string.Empty
            : Schema.Value.Type.ToPropertyName())
    ;
    
    public string ClassName => NamingConvention switch
    {
        NamingConvention.InnerClasses => Parents.IsEmpty ? Name : $"_{Name}",
        NamingConvention.ConcatNames => Parents.IsEmpty ? Name : $"{Parents.Last().ClassName}{Name}",
        _ => string.Empty,
    };
    
    public string ExternalClassName => NamingConvention switch
    {
        NamingConvention.InnerClasses => string.Join(".", Parents.Select(x => x.ClassName).Concat([ClassName])),
        NamingConvention.ConcatNames => ClassName,
        _ => string.Empty,
    };
    
    public string FileNameWithoutExtension => $"{Namespace}.Models.{ExternalClassName}";

    public IEnumerable<ModelData> WithAdditionalModels()
    {
        return new[]
            {
                this with
                {
                    AdditionalModels = [],
                    Enumerations = [],
                }
            }
            .Concat(AdditionalModels.SelectMany(x => x.WithAdditionalModels()))
            .Concat(Enumerations.SelectMany(x => x.WithAdditionalModels()));
    }
}