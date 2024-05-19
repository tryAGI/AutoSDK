using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct PropertyData(
    string Id,
    string Name,
    TypeData Type,
    bool IsRequired,
    ParameterLocation? ParameterLocation,
    ParameterStyle? ParameterStyle,
    bool? ParameterExplode,
    string? DefaultValue,
    string Summary)
{
    public static PropertyData Default => new(
        Id: string.Empty,
        Name: string.Empty,
        Type: TypeData.Default,
        IsRequired: false,
        ParameterLocation: null,
        ParameterStyle: null,
        ParameterExplode: null,
        DefaultValue: null,
        Summary: string.Empty);

    public static PropertyData FromSchema(
        KeyValuePair<string, OpenApiSchema> schema,
        HashSet<string> requiredProperties,
        ParameterLocation? parameterLocation,
        ParameterStyle? parameterStyle,
        bool? parameterExplode,
        Settings settings,
        params ModelData[] parents)
    {
        requiredProperties = requiredProperties ?? throw new ArgumentNullException(nameof(requiredProperties));
        parents = parents ?? throw new ArgumentNullException(nameof(parents));

        var name = schema.Key.ToPropertyName();
        if (parents.Length != 0)
        {
            name = name.FixPropertyName(parents.Last().ClassName);
        }
        name = name
            .UseWordSeparator('_', '-', '/')
            .Replace("[", string.Empty)
            .Replace("]", string.Empty);
        
        return new PropertyData(
            Id: schema.Key,
            Name: name,
            Type: TypeData.FromSchema(schema, settings, parents),
            IsRequired: requiredProperties.Contains(schema.Key),
            ParameterLocation: parameterLocation,
            ParameterStyle: parameterStyle,
            ParameterExplode: parameterExplode,
            DefaultValue: schema.Value.GetDefaultValue(type: TypeData.FromSchema(schema, settings with
            {
                JsonSerializerType = JsonSerializerType.NewtonsoftJson
            }, parents).CSharpType),
            Summary: schema.Value.GetSummary());
    }
}