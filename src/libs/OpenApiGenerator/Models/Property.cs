namespace OpenApiGenerator.Models;

public readonly record struct Property(
    string Id,
    string Name,
    string Type,
    bool IsRequired,
    string? DefaultValue,
    string Summary)
{
    public static Property Default => new(
        Id: string.Empty,
        Name: string.Empty,
        Type: string.Empty,
        IsRequired: false,
        DefaultValue: null,
        Summary: string.Empty);
}