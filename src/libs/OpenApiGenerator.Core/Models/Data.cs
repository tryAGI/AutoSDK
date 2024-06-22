namespace OpenApiGenerator.Core.Models;

public readonly record struct Data(
    EquatableArray<ModelData> Models,
    EquatableArray<EndPoint> Methods,
    EquatableArray<AnyOfData> AnyOfs,
    EquatableArray<TypeData> Types,
    EndPoint Converters,
    IReadOnlyList<SchemaContext> Schemas);