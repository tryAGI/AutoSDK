namespace OpenApiGenerator.Core.Models;

public readonly record struct PropertyData(
    string Id,
    string Name,
    string Type,
    bool IsRequired,
    string? DefaultValue,
    string Summary)
{
    public static PropertyData Default => new(
        Id: string.Empty,
        Name: string.Empty,
        Type: string.Empty,
        IsRequired: false,
        DefaultValue: null,
        Summary: string.Empty);
}