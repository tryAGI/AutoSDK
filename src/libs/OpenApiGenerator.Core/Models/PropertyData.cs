using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct PropertyData(
    string Id,
    string Name,
    TypeData Type,
    bool IsRequired,
    bool IsMultiPartFormDataFilename,
    ParameterLocation? ParameterLocation,
    ParameterStyle? ParameterStyle,
    bool? ParameterExplode,
    Settings Settings,
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
        IsMultiPartFormDataFilename: false,
        ParameterLocation: null,
        ParameterStyle: null,
        ParameterExplode: null,
        DefaultValue: null,
        IsDeprecated: false,
        Settings: Settings.Default,
        Summary: string.Empty,
        ConverterType: string.Empty);

    public static PropertyData FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var propertyName = context.PropertyName ?? context.ParameterName ?? throw new InvalidOperationException("Property name or parameter name is required.");
        var type = context.TypeData ?? throw new InvalidOperationException("TypeData is required.");

        var name = propertyName.ToPropertyName();
        
        name = HandleWordSeparators(name);

        if (context.Parent != null)
        {
            name = name.FixPropertyName(context.Parent.Id);
        }

        name = SanitizeName(name, context.Settings.ClsCompliantEnumPrefix, true);
        
        var requiredProperties = context.Parent != null
            ? new HashSet<string>(context.Parent.Schema.Required)
            : [];
        
        var isRequired = context.Hint is Hint.Parameter
            ? context.Parameter?.Required == true || context.Parameter?.In == Microsoft.OpenApi.Models.ParameterLocation.Path
            : requiredProperties.Contains(propertyName);
        // Special case for enums with a single value.
        if (isRequired && type is { IsEnum: true, EnumValues.Length: 1 })
        {
            isRequired = false;
        }
        
        return new PropertyData(
            Id: propertyName,
            Name: name,
            Type: type,
            IsRequired: isRequired,
            IsMultiPartFormDataFilename: false,
            ParameterLocation: context.Parameter?.In,
            ParameterStyle: context.Parameter?.Style,
            ParameterExplode: context.Parameter?.Explode,
            Settings: context.Settings,
            IsDeprecated: context.Schema.Deprecated,
            DefaultValue: context.GetDefaultValue(),
            Summary: context.Schema.GetSummary(),
            ConverterType: type.ConverterType);
    }
    
    internal static string SanitizeName(string? name, string clsCompliantEnumPrefix, bool skipHandlingWordSeparators = false)
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
            return string.IsNullOrWhiteSpace(clsCompliantEnumPrefix)
                ? "_"
                : clsCompliantEnumPrefix;
        }
        
        if (InvalidFirstChar(name[0]))
        {
            name = (string.IsNullOrWhiteSpace(clsCompliantEnumPrefix)
                ? "_"
                : clsCompliantEnumPrefix) + name;
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

    internal static string HandleWordSeparators(string name)
    {
        return name
            .ReplacePlusAndMinusOnStart()
            .UseWordSeparator('_', '+', '-', '.', '/', '(', '[', ']', ')');
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
            if (Type.EnumValues.Length != 0 && Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
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