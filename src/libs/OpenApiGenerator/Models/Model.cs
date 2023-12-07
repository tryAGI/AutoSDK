using H.Generators.Extensions;

namespace OpenApiGenerator.Models;

internal readonly record struct Model(
    string Id,
    string Name,
    EquatableArray<string> Parents,
    string Namespace,
    ModelStyle Style,
    EquatableArray<Property> Properties,
    string Summary,
    EquatableArray<Model> AdditionalModels,
    EquatableArray<Model> Enumerations
    );