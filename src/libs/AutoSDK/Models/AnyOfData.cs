namespace AutoSDK.Models;

public record struct AnyOfData(
    string SubType,
    int Count,
    TypeData? DiscriminatorType,
    string? DiscriminatorPropertyName,
    bool IsTrimming,
    string Namespace,
    string Name,
    string Summary,
    EquatableArray<PropertyData> Properties,
    EmitterSettings Settings)
{
    public bool IsNamed => !string.IsNullOrWhiteSpace(Name);
}
