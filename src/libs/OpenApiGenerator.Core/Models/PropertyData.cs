using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct PropertyData(
    string Id,
    string Name,
    string Type,
    bool IsRequired,
    ParameterLocation? ParameterLocation,
    string? DefaultValue,
    string Summary)
{
    public static PropertyData Default => new(
        Id: string.Empty,
        Name: string.Empty,
        Type: string.Empty,
        IsRequired: false,
        ParameterLocation: null,
        DefaultValue: null,
        Summary: string.Empty);

    public static PropertyData FromSchema(
        KeyValuePair<string, OpenApiSchema> schema,
        HashSet<string> requiredProperties,
        ParameterLocation? parameterLocation,
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
            Type: schema.GetCSharpType(settings, parents),
            IsRequired: requiredProperties.Contains(schema.Key),
            ParameterLocation: parameterLocation,
            DefaultValue: schema.Value.GetDefaultValue(type: schema.GetCSharpType(settings with
            {
                JsonSerializerType = JsonSerializerType.NewtonsoftJson
            }, parents)),
            Summary: schema.Value.GetSummary());
    }
}