using System.Collections.Immutable;
using Microsoft.OpenApi;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Naming.Properties;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Models;

public record struct MethodParameter(
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
    string Description,
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
        Description: string.Empty,
        ConverterType: string.Empty,
        Properties: []);

    public static MethodParameter FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var parameter = context.Parameter ?? throw new InvalidOperationException("Parameter or parameter data is required.");
        var parameterName = context.ParameterName ?? throw new InvalidOperationException("Property name or parameter name is required.");
        var type = context.TypeData;
        if (parameter.In == ParameterLocation.Query &&
            (context.IsClass || context.ResolvedReference?.IsClass == true))
        {
            var props = (context.ResolvedReference?.ClassData ?? context.ClassData)?.Properties;
            if (props is { Length: > 0 })
            {
                for (var i = 0; i < props.Value.Length; i++)
                {
                    if (props.Value[i].Id == parameterName)
                    {
                        type = props.Value[i].Type;
                        break;
                    }
                }
            }
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
            IsDeprecated: context.Schema.IsDeprecated(),
            DefaultValue: context.GetDefaultValue(),
            Summary: context.Schema.GetSummary(),
            Description:
                context.Parameter?.Description ??
                context.Schema.Description ??
                string.Empty,
            ConverterType: type.ConverterType,
            Properties: context.ClassData?.Properties ?? []);
    }

    internal static string HandleWordSeparators(string name)
    {
        return name
            .ReplacePlusAndMinusOnStart()
            .UseWordSeparator(StringExtensions.PropertySeparators);
    }

    public string ParameterName => Name
        .Replace(".", string.Empty)
        .ToParameterName()
        .EscapeCSharpKeyword();

    public string ArgumentName
    {
        get
        {
            if (Type.EnumValues.Length != 0 && !Type.IsAnyOfLike && Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
            {
                return ParameterName + "Value";
            }
            
            return ParameterName;
        }
    }
    
    /// <summary>
    /// Whether this parameter has a real schema default/const value
    /// that can be used as a C# default parameter value.
    /// </summary>
    public bool HasSchemaDefault =>
        !string.IsNullOrWhiteSpace(DefaultValue) && !Type.IsAnyOfLike;

    public string ParameterDefaultValue =>
        DefaultValue == null || string.IsNullOrWhiteSpace(DefaultValue) || Type.IsAnyOfLike
        ? "default"
        : DefaultValue;

    public bool ProducesDeprecationWarning =>
        Type.IsAnyOfLike &&
        Type.SubTypes.Any(static x => x.Unbox<TypeData>().IsDeprecated);

    public string DisableDeprecationWarningIfRequired =>
        ProducesDeprecationWarning
            ? "#pragma warning disable CS0618 // Type or member is obsolete"
            : " ";
}
