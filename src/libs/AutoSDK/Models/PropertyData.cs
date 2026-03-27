using System.Collections.Immutable;
namespace AutoSDK.Models;

public record struct PropertyData(
    string Id,
    string Name,
    string ParameterName,
    TypeData Type,
    bool IsRequired,
    bool IsReadOnly,
    bool IsWriteOnly,
    bool IsMultiPartFormDataFilename,
    EmitterSettings Settings,
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
        ParameterName: string.Empty,
        Type: TypeData.Default,
        IsRequired: false,
        IsReadOnly: false,
        IsWriteOnly: false,
        IsMultiPartFormDataFilename: false,
        DefaultValue: null,
        Example: null,
        IsDeprecated: false,
        Settings: EmitterSettings.Default,
        Summary: string.Empty,
        Description: string.Empty,
        ConverterType: string.Empty,
        DiscriminatorValue: string.Empty,
        JsonPropertyNames: ImmutableArray<string>.Empty.AsEquatableArray());
}
