using H.Generators.Extensions;

namespace OpenApiGenerator.Models;

internal readonly record struct Model(
    string Name,
    string Namespace,
    ModelStyle Style,
    EquatableArray<Property> Properties);