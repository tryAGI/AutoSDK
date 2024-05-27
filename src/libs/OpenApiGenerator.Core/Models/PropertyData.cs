using System.Text;
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
    JsonSerializerType JsonSerializerType,
    string? DefaultValue,
    bool IsDeprecated,
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
        IsDeprecated: false,
        JsonSerializerType: JsonSerializerType.SystemTextJson,
        Summary: string.Empty);

    public static PropertyData FromSchema(
        KeyValuePair<string, OpenApiSchema> schema,
        HashSet<string> requiredProperties,
        ParameterLocation? parameterLocation,
        ParameterStyle? parameterStyle,
        bool? parameterExplode,
        string operationId,
        Settings settings,
        params ModelData[] parents)
    {
        requiredProperties = requiredProperties ?? throw new ArgumentNullException(nameof(requiredProperties));
        parents = parents ?? throw new ArgumentNullException(nameof(parents));

        var name = schema.Key.ToPropertyName();
        name = name
            .ReplacePlusAndMinusOnStart()
            .UseWordSeparator('_', '+', '-', '/')
            .Replace(".", "_")
            .Replace(":", "_")
            .Replace("[", string.Empty)
            .Replace("]", string.Empty);

        if (parents.Length != 0)
        {
            name = name.FixPropertyName(parents.Last().ClassName);
        }

        name = SanitizeName(name);
        
        return new PropertyData(
            Id: schema.Key,
            Name: name,
            Type: TypeData.FromSchema(schema, settings, string.IsNullOrWhiteSpace(operationId)
                ? parents
                : parents.Concat([ModelData.FromKey(operationId, settings) with{ Schema = default }]).ToArray()),
            IsRequired: requiredProperties.Contains(schema.Key),
            ParameterLocation: parameterLocation,
            ParameterStyle: parameterStyle,
            ParameterExplode: parameterExplode,
            JsonSerializerType: settings.JsonSerializerType,
            IsDeprecated: schema.Value.Deprecated,
            DefaultValue: schema.Value.GetDefaultValue(type: TypeData.FromSchema(schema, settings with
            {
                JsonSerializerType = JsonSerializerType.NewtonsoftJson
            }, parents).CSharpType),
            Summary: schema.Value.GetSummary());
    }

    private static string SanitizeName(string name)
    {
        static bool InvalidFirstChar(char ch)
            => ch is not ('_' or >= 'A' and <= 'Z' or >= 'a' and <= 'z');

        static bool InvalidSubsequentChar(char ch)
            => ch is not (
                    '_'
                    or >= 'A' and <= 'Z'
                    or >= 'a' and <= 'z'
                    or >= '0' and <= '9'
                );

        if (InvalidFirstChar(name[0]))
        {
            name = $"_{name}";
        }

        if (!name.Skip(1).Any(InvalidSubsequentChar))
        {
            return name;
        }

        Span<char> buf = stackalloc char[name.Length];
        name.AsSpan().CopyTo(buf);
        
        for (var i = 1; i < buf.Length; i++)
        {
            if (InvalidSubsequentChar(buf[i]))
            {
                buf[i] = '_';
            }
        }

        // Span<char>.ToString implementation checks for char type, new string(&buf[0], buf.length)
        return buf.ToString();
    }

    public string ParameterName => Name
        .Replace(".", string.Empty)
        .ToParameterName()
        .ReplaceIfEquals("ref", "@ref")
        .ReplaceIfEquals("base", "@base")
        .ReplaceIfEquals("protected", "@protected");

    public string ArgumentName
    {
        get
        {
            if (Type.EnumValues.Length != 0 && JsonSerializerType == JsonSerializerType.NewtonsoftJson)
            {
                return ParameterName + "Value";
            }
            
            return ParameterName;
        }
    }
    
    public string ParameterDefaultValue => DefaultValue == null || string.IsNullOrWhiteSpace(DefaultValue)
        ? "default"
        : DefaultValue;
}