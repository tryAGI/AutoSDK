using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.OpenApi.Models;

namespace OpenApiGenerator.Models;

public readonly record struct Model(
    KeyValuePair<string, OpenApiSchema> Schema,
    string Id,
    bool AddTypeName,
    EquatableArray<Model> Parents,
    string Namespace,
    NamingConvention NamingConvention,
    ModelStyle Style,
    EquatableArray<Property> Properties,
    string Summary,
    EquatableArray<Model> AdditionalModels,
    EquatableArray<Model> Enumerations
)
{
    public static IList<Model> WithModelName(
        IList<OpenApiSchema> schemas,
        string key,
        Settings settings,
        bool addTypeName,
        params Model[] parents)
    {
        return schemas
            .Select(x => FromSchema(x.WithKey(key), settings, parents) with
            {
                AddTypeName = addTypeName
            })
            .ToArray();
    }
    
    public static Model FromKey(
        string key,
        Settings settings,
        params Model[] parents)
    {
        return new Model(
            Schema: default,
            Id: key,
            AddTypeName: false,
            Parents: parents.ToImmutableArray(),
            Namespace: settings.Namespace,
            NamingConvention: settings.NamingConvention,
            Style: settings.ModelStyle,
            Properties: ImmutableArray<Property>.Empty,
            Summary: string.Empty,
            AdditionalModels: ImmutableArray<Model>.Empty,
            Enumerations: ImmutableArray<Model>.Empty
        );
    }
    
    public static Model FromSchema(
        KeyValuePair<string, OpenApiSchema> schema,
        Settings settings,
        params Model[] parents)
    {
        var model = new Model(
            Schema: schema,
            Id: schema.Key,
            AddTypeName: false,
            Parents: parents.ToImmutableArray(),
            Namespace: settings.Namespace,
            NamingConvention: settings.NamingConvention,
            Style: settings.ModelStyle,
            Properties: ImmutableArray<Property>.Empty,
            Summary: schema.Value.GetSummary(),
            AdditionalModels: ImmutableArray<Model>.Empty,
            Enumerations: ImmutableArray<Model>.Empty
            );

        var requiredProperties = new HashSet<string>(schema.Value.Required);
        var innerParents = parents.Append(model).ToArray();
        
        return model with
        {
            Properties = schema.Value.Properties
                .Select(x => x.ToProperty(
                    requiredProperties: requiredProperties,
                    settings: settings,
                    parents: innerParents))
                .ToImmutableArray(),
            AdditionalModels = schema.Value.Properties
                .Select(x => FromSchema(x, settings, innerParents))
                .Concat(schema.Value.Properties.SelectMany(x => x.Value.Items != null && x.Value.Items.IsObjectWithoutReference()
                    ? new []{ FromSchema(x.Value.Items.WithKey(x.Key), settings, innerParents) }
                    : Array.Empty<Model>()))
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
        _ => throw new ArgumentOutOfRangeException()
    };
    
    public string ExternalClassName => NamingConvention switch
    {
        NamingConvention.InnerClasses => string.Join(".", Parents.Select(x => x.ClassName).Append(ClassName)),
        NamingConvention.ConcatNames => ClassName,
        _ => throw new ArgumentOutOfRangeException()
    };
    
    public string FileNameWithoutExtension => $"{Namespace}.Models.{ExternalClassName}";
}