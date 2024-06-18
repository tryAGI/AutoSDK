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
    string Summary,
    string ConverterType)
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
        Summary: string.Empty,
        ConverterType: string.Empty);

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
        
        name = HandleWordSeparators(name);

        if (parents.Length != 0)
        {
            name = name.FixPropertyName(parents.Last().ClassName);
        }

        name = SanitizeName(name, true);
        
        var type = TypeData.FromSchema(schema, settings, string.IsNullOrWhiteSpace(operationId)
            ? parents
            : parents.Concat([ModelData.FromKey(operationId, settings) with { Schema = default }]).ToArray());
        
        return new PropertyData(
            Id: schema.Key,
            Name: name,
            Type: type,
            IsRequired: requiredProperties.Contains(schema.Key),
            ParameterLocation: parameterLocation,
            ParameterStyle: parameterStyle,
            ParameterExplode: parameterExplode,
            JsonSerializerType: settings.JsonSerializerType,
            IsDeprecated: schema.Value.Deprecated,
            DefaultValue: schema.GetDefaultValue(settings, parents),
            Summary: schema.Value.GetSummary(),
            ConverterType: type.ConverterType);
    }

    internal static string SanitizeName(string? name, bool skipHandlingWordSeparators = false)
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
        
        if (name is null || name.Length == 0)
        {
            return "";
        }

        if (!skipHandlingWordSeparators)
        {
            name = HandleWordSeparators(name);
        }

        if (name.Length == 0)
        {
            return "_";
        }
        
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

    private static string HandleWordSeparators(string name)
    {
        return name
            .ReplacePlusAndMinusOnStart()
            .UseWordSeparator('_', '+', '-', '/', '(', '[', ']', ')');
    }

    public string ParameterName => Name
        .Replace(".", string.Empty)
        .ToParameterName()
        
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/
        .ReplaceIfEquals("abstract", "@abstract")
        .ReplaceIfEquals("as", "@as")
        .ReplaceIfEquals("base", "@base")
        .ReplaceIfEquals("bool", "@bool")
        .ReplaceIfEquals("break", "@break")
        .ReplaceIfEquals("byte", "@byte")
        .ReplaceIfEquals("case", "@case")
        .ReplaceIfEquals("catch", "@catch")
        .ReplaceIfEquals("char", "@char")
        .ReplaceIfEquals("checked", "@checked")
        .ReplaceIfEquals("class", "@class")
        .ReplaceIfEquals("const", "@const")
        .ReplaceIfEquals("continue", "@continue")
        .ReplaceIfEquals("decimal", "@decimal")
        .ReplaceIfEquals("default", "@default")
        .ReplaceIfEquals("delegate", "@delegate")
        .ReplaceIfEquals("do", "@do")
        .ReplaceIfEquals("double", "@double")
        .ReplaceIfEquals("else", "@else")
        .ReplaceIfEquals("enum", "@enum")
        .ReplaceIfEquals("event", "@event")
        .ReplaceIfEquals("explicit", "@explicit")
        .ReplaceIfEquals("extern", "@extern")
        .ReplaceIfEquals("false", "@false")
        .ReplaceIfEquals("finally", "@finally")
        .ReplaceIfEquals("fixed", "@fixed")
        .ReplaceIfEquals("float", "@float")
        .ReplaceIfEquals("for", "@for")
        .ReplaceIfEquals("foreach", "@foreach")
        .ReplaceIfEquals("goto", "@goto")
        .ReplaceIfEquals("if", "@if")
        .ReplaceIfEquals("implicit", "@implicit")
        .ReplaceIfEquals("in", "@in")
        .ReplaceIfEquals("int", "@int")
        .ReplaceIfEquals("interface", "@interface")
        .ReplaceIfEquals("internal", "@internal")
        .ReplaceIfEquals("is", "@is")
        .ReplaceIfEquals("lock", "@lock")
        .ReplaceIfEquals("long", "@long")
        .ReplaceIfEquals("namespace", "@namespace")
        .ReplaceIfEquals("new", "@new")
        .ReplaceIfEquals("null", "@null")
        .ReplaceIfEquals("object", "@object")
        .ReplaceIfEquals("operator", "@operator")
        .ReplaceIfEquals("out", "@out")
        .ReplaceIfEquals("override", "@override")
        .ReplaceIfEquals("params", "@params")
        .ReplaceIfEquals("private", "@private")
        .ReplaceIfEquals("protected", "@protected")
        .ReplaceIfEquals("public", "@public")
        .ReplaceIfEquals("readonly", "@readonly")
        .ReplaceIfEquals("ref", "@ref")
        .ReplaceIfEquals("return", "@return")
        .ReplaceIfEquals("sbyte", "@sbyte")
        .ReplaceIfEquals("sealed", "@sealed")
        .ReplaceIfEquals("short", "@short")
        .ReplaceIfEquals("sizeof", "@sizeof")
        .ReplaceIfEquals("stackalloc", "@stackalloc")
        .ReplaceIfEquals("static", "@static")
        .ReplaceIfEquals("string", "@string")
        .ReplaceIfEquals("struct", "@struct")
        .ReplaceIfEquals("switch", "@switch")
        .ReplaceIfEquals("this", "@this")
        .ReplaceIfEquals("throw", "@throw")
        .ReplaceIfEquals("true", "@true")
        .ReplaceIfEquals("try", "@try")
        .ReplaceIfEquals("typeof", "@typeof")
        .ReplaceIfEquals("uint", "@uint")
        .ReplaceIfEquals("ulong", "@ulong")
        .ReplaceIfEquals("unchecked", "@unchecked")
        .ReplaceIfEquals("unsafe", "@unsafe")
        .ReplaceIfEquals("ushort", "@ushort")
        .ReplaceIfEquals("using", "@using")
        .ReplaceIfEquals("virtual", "@virtual")
        .ReplaceIfEquals("void", "@void")
        .ReplaceIfEquals("volatile", "@volatile")
        .ReplaceIfEquals("while", "@while");

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
    
    public string ParameterDefaultValue =>
        DefaultValue == null || string.IsNullOrWhiteSpace(DefaultValue) || Type.IsAnyOf
        ? "default"
        : DefaultValue;
}