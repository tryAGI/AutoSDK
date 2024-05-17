using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct PropertyData(
    string Id,
    string Name,
    string Type,
    bool IsRequired,
    string? DefaultValue,
    string Summary)
{
    public static PropertyData Default => new(
        Id: string.Empty,
        Name: string.Empty,
        Type: string.Empty,
        IsRequired: false,
        DefaultValue: null,
        Summary: string.Empty);

    public static PropertyData FromSchema(
        KeyValuePair<string, OpenApiSchema> schema,
        HashSet<string> requiredProperties,
        Settings settings,
        params ModelData[] parents)
    {
        requiredProperties = requiredProperties ?? throw new ArgumentNullException(nameof(requiredProperties));

        return new PropertyData(
            Id: schema.Key,
            Name: schema.Key.ToPropertyName()
                .FixPropertyName(parents.Last().ClassName)
                .UseWordSeparator('_', '-', '/')
                .Replace("[", string.Empty)
                .Replace("]", string.Empty),
            Type: schema.GetCSharpType(settings, parents),
            IsRequired: requiredProperties.Contains(schema.Key),
            DefaultValue: schema.Value.GetDefaultValue(type: schema.GetCSharpType(settings with
            {
                JsonSerializerType = JsonSerializerType.NewtonsoftJson
            }, parents)),
            Summary: schema.Value.GetSummary());
    }
}