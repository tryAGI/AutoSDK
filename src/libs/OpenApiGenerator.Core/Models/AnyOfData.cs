namespace OpenApiGenerator.Core.Models;

public readonly record struct AnyOfData(
    string SubType,
    int Count
);