using System.Collections.Immutable;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct AnyOfData(
    string SubType,
    int Count,
    JsonSerializerType JsonSerializerType,
    bool IsTrimming,
    string Namespace,
    string Name,
    string Summary,
    ImmutableArray<PropertyData> Properties
);