using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Naming.Properties;

namespace AutoSDK.Models;

public record struct PropertyData(
    string Id,
    string Name,
    TypeData Type,
    bool IsRequired,
    bool IsReadOnly,
    bool IsWriteOnly,
    bool IsMultiPartFormDataFilename,
    Settings Settings,
    string? DefaultValue,
    string? Example,
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
        Example: null,
        IsDeprecated: false,
        Settings: Settings.Default,
        Summary: string.Empty,
        ConverterType: string.Empty,
        DiscriminatorValue: string.Empty);

    public static PropertyData FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var type = context.TypeData;

        // OpenAPI doesn't allow metadata for references so sometimes allOf with single item is used to add metadata.
        if (context.HasAllOfTypeForMetadata() &&
            !type.SubTypes.IsEmpty)
        {
            type = type.SubTypes[0].Unbox<TypeData>() with
            {
                CSharpTypeRaw = type.SubTypes[0].Unbox<TypeData>().CSharpTypeRaw,
                CSharpTypeNullability = type.CSharpTypeNullability,
            };
        }

        var requiredProperties = context.Parent != null
            ? new HashSet<string>(context.Parent.Schema.Required)
            : [];

        var propertyName = context.PropertyName ?? throw new InvalidOperationException("Property name or parameter name is required.");
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
            Name: CSharpPropertyNameGenerator.ComputePropertyName(context),
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
            Example: context.Schema.Example?.GetString() is { } example &&
                     !string.IsNullOrWhiteSpace(example)
                ? example.ClearForXml()
                : null,
            Summary: context.Schema.GetSummary(),
            ConverterType: type.ConverterType,
            DiscriminatorValue: string.Empty);
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