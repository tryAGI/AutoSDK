using H.Generators.Extensions;

namespace OpenApiGenerator.Models;

internal readonly record struct Model(
    EquatableArray<Property> Properties);