namespace AutoSDK.Models;

public readonly record struct Data(
    EquatableArray<ModelData> Classes,
    EquatableArray<ModelData> Enums,
    EquatableArray<EndPoint> Methods,
    EquatableArray<AnyOfData> AnyOfs,
    EquatableArray<TypeData> Types,
    EquatableArray<Authorization> Authorizations,
    EndPoint Converters,
    IReadOnlyList<SchemaContext> Schemas,
    IReadOnlyList<SchemaContext> FilteredSchemas,
    Times Times);