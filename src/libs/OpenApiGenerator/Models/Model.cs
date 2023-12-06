using H.Generators.Extensions;

namespace OpenApiGenerator.Models;

internal readonly record struct Model(
    ModelStyle Style,
    EquatableArray<Property> Properties);