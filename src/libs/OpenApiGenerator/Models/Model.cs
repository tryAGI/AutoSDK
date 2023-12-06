using H.Generators.Extensions;

namespace OpenApiGenerator.Models;

internal readonly record struct Model(
    string Id,
    string Name,
    string? Parent,
    string Namespace,
    ModelStyle Style,
    EquatableArray<Property> Properties,
    string Summary,
    EquatableArray<Model> AdditionalModels
    );