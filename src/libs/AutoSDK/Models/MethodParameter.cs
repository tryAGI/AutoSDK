using System.Collections.Immutable;
using AutoSDK.Helpers;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public record struct MethodParameter(
    string Id,
    string Name,
    string ParameterName,
    string ArgumentName,
    string Value,
    string Delimiter,
    string Selector,
    TypeData Type,
    bool IsRequired,
    bool IsMultiPartFormDataFilename,
    ParameterLocation? Location,
    ParameterStyle? Style,
    bool Explode,
    EmitterSettings Settings,
    string? DefaultValue,
    bool IsDeprecated,
    string Summary,
    string Description,
    string? ContentType,
    string ConverterType,
    ImmutableArray<PropertyData> Properties,
    bool HasSchemaDefault,
    string ParameterDefaultValue,
    bool ProducesDeprecationWarning,
    string DisableDeprecationWarningIfRequired,
    bool IsIdempotencyHeader = false)
{
    public static MethodParameter Default => new(
        Id: string.Empty,
        Name: string.Empty,
        ParameterName: string.Empty,
        ArgumentName: string.Empty,
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
        Settings: EmitterSettings.Default,
        Summary: string.Empty,
        Description: string.Empty,
        ContentType: null,
        ConverterType: string.Empty,
        Properties: [],
        HasSchemaDefault: false,
        ParameterDefaultValue: "default",
        ProducesDeprecationWarning: false,
        DisableDeprecationWarningIfRequired: " ",
        IsIdempotencyHeader: false);
}
