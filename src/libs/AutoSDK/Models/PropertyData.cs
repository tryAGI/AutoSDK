using AutoSDK.Extensions;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Models;

public readonly record struct PropertyData(
    string Id,
    string Name,
    TypeData Type,
    bool IsRequired,
    bool IsReadOnly,
    bool IsWriteOnly,
    bool IsMultiPartFormDataFilename,
    Settings Settings,
    string? DefaultValue,
    bool IsDeprecated,
    string Summary,
    string ConverterType,
    string DiscriminatorValue)
{
    public static PropertyData Default => new(
        Id: string.Empty,
        Name: string.Empty,
        Type: TypeData.Default,
        IsRequired: false,
        IsReadOnly: false,
        IsWriteOnly: false,
        IsMultiPartFormDataFilename: false,
        DefaultValue: null,
        IsDeprecated: false,
        Settings: Settings.Default,
        Summary: string.Empty,
        ConverterType: string.Empty,
        DiscriminatorValue: string.Empty);

    public static PropertyData FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var propertyName = context.PropertyName ?? throw new InvalidOperationException("Property name or parameter name is required.");
        var type = context.TypeData;
        
        // OpenAPI doesn't allow metadata for references so sometimes allOf with single item is used to add metadata.
        if (context.HasAllOfTypeForMetadata())
        {
            type = type.SubTypes[0] with
            {
                CSharpTypeRaw = type.SubTypes[0].CSharpTypeRaw,
                CSharpTypeNullability = type.CSharpTypeNullability,
            };
        }

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
        
        var isRequired =
            requiredProperties.Contains(propertyName) &&
            context.Schema is { WriteOnly: false };
        // Special case for enums with a single value.
        if (isRequired && type is { IsEnum: true, EnumValues.Length: 1 })
        {
            isRequired = false;
        }
        
        return new PropertyData(
            Id: propertyName,
            Name: name,
            Type: type with
            {
                CSharpTypeNullability = type.CSharpTypeNullability || context.Schema is { WriteOnly: true },
            },
            IsRequired: isRequired && context.Schema is { ReadOnly: false },
            IsReadOnly: context.Schema.ReadOnly,
            IsWriteOnly: context.Schema.WriteOnly,
            IsMultiPartFormDataFilename: false,
            Settings: context.Settings,
            IsDeprecated: context.Schema.Deprecated,
            DefaultValue: context.Schema is { ReadOnly: true } && !type.CSharpTypeNullability
                ? "default!"
                : context.GetDefaultValue(),
            Summary: context.Schema.GetSummary(),
            ConverterType: type.ConverterType,
            DiscriminatorValue: string.Empty);
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
}