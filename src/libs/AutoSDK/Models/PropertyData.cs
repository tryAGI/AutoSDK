using System.Collections.Immutable;
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
    string Description,
    string ConverterType,
    string DiscriminatorValue,
    EquatableArray<string> JsonPropertyNames)
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
        Description: string.Empty,
        ConverterType: string.Empty,
        DiscriminatorValue: string.Empty,
        JsonPropertyNames: ImmutableArray<string>.Empty.AsEquatableArray());

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

        var propertyName = context.PropertyName ?? throw new InvalidOperationException("Property name or parameter name is required.");
        var parentRequired = context.Parent?.Schema.Required;
        var isRequired =
            parentRequired != null &&
            parentRequired.Contains(propertyName) &&
            context.Schema is { WriteOnly: false };
        // Special case for enums with a single value.
        if (isRequired && type is { IsEnum: true, EnumValues.Length: 1 })
        {
            isRequired = false;
        }
        // Special case for const properties — only one valid value with a default.
        if (isRequired && context.Schema.IsConst())
        {
            isRequired = false;
        }
        // Nullable properties already default to null in C#.
        // The JSON contract is preserved by [JsonRequired].
        if (isRequired && type.CSharpTypeNullability)
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
            IsDeprecated: context.Schema.IsDeprecated(),
            DefaultValue: context.Schema is { ReadOnly: true } && !type.CSharpTypeNullability
                ? "default!"
                : context.GetDefaultValue(),
            Example: context.Schema.Example?.GetString() is { } example &&
                     !string.IsNullOrWhiteSpace(example)
                ? example.ClearForXml()
                : null,
            Summary: context.Schema.GetSummary(),
            Description: context.Schema.Description ?? string.Empty,
            ConverterType: type.ConverterType,
            DiscriminatorValue: string.Empty,
            JsonPropertyNames: ImmutableArray<string>.Empty.AsEquatableArray());
    }

    public string ParameterName => Name
        .Replace(".", string.Empty)
        .ToParameterName()
        .EscapeCSharpKeyword();
}
