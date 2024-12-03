using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Naming.Properties;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Models;

public readonly record struct MethodParameter(
    string Id,
    string Name,
    string Value,
    string Delimiter,
    string Selector,
    TypeData Type,
    bool IsRequired,
    bool IsMultiPartFormDataFilename,
    ParameterLocation? Location,
    ParameterStyle? Style,
    bool Explode,
    Settings Settings,
    string? DefaultValue,
    bool IsDeprecated,
    string Summary,
    string ConverterType,
    ImmutableArray<PropertyData> Properties)
{
    public static MethodParameter Default => new(
        Id: string.Empty,
        Name: string.Empty,
        Value: string.Empty,
        Delimiter: string.Empty,
        Selector: string.Empty,
        Type: TypeData.Default,
        IsRequired: false,
        IsMultiPartFormDataFilename: false,
        Location: null,
        Style: null,
        Explode: false,
        DefaultValue: null,
        IsDeprecated: false,
        Settings: Settings.Default,
        Summary: string.Empty,
        ConverterType: string.Empty,
        Properties: []);

    public static MethodParameter FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var parameter = context.Parameter ?? throw new InvalidOperationException("Parameter or parameter data is required.");
        var parameterName = context.ParameterName ?? throw new InvalidOperationException("Property name or parameter name is required.");
        var type = context.TypeData;
        if (parameter.In == ParameterLocation.Query &&
            (context.IsClass || context.ResolvedReference?.IsClass == true) &&
            (context.ResolvedReference?.ClassData ?? context.ClassData)?.Properties.FirstOrDefault(x => x.Id == parameterName) is { } property &&
            property != default)
        {
            type = property.Type;
        }
        
        var name = parameterName.ToPropertyName();
        
        name = HandleWordSeparators(name);

        if (context.Parent != null)
        {
            name = name.FixPropertyName(context.Parent.Id);
        }

        name = CSharpPropertyNameGenerator.SanitizeName(name, context.Settings.ClsCompliantEnumPrefix, true);
        
        var isRequired =
            parameter.Required ||
            parameter.In == ParameterLocation.Path;
        // Special case for enums with a single value.
        // if (isRequired && type is { IsEnum: true, EnumValues.Length: 1 })
        // {
        //     isRequired = false;
        // }
        
        return new MethodParameter(
            Id: parameterName,
            Name: name,
            Value: string.Empty,
            Delimiter: string.Empty,
            Selector: string.Empty,
            Type: type,
            IsRequired: isRequired,
            IsMultiPartFormDataFilename: false,
            Location: parameter.In,
            Style: parameter.Style,
            Explode: parameter.Explode,
            Settings: context.Settings,
            IsDeprecated: context.Schema.Deprecated,
            DefaultValue: context.GetDefaultValue(),
            Summary: context.Schema.GetSummary(),
            ConverterType: type.ConverterType,
            Properties: context.ClassData?.Properties ?? []);
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
        DefaultValue == null || string.IsNullOrWhiteSpace(DefaultValue) || Type.IsAnyOfLike
        ? "default"
        : DefaultValue;
}