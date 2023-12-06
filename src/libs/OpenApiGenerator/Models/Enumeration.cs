using H.Generators.Extensions;

namespace OpenApiGenerator.Models;

internal readonly record struct Enumeration(
    EquatableArray<(string, string)> Values
    );