namespace OpenApiGenerator.Models;

internal readonly record struct Property(
    string Id,
    string Name,
    string Type,
    bool IsRequired,
    string? DefaultValue,
    string Summary);