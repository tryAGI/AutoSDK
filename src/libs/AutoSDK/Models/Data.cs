namespace AutoSDK.Models;

public record struct Data(
    EquatableArray<ModelData> Classes,
    EquatableArray<ModelData> Enums,
    EquatableArray<EndPoint> Methods,
    EquatableArray<Client> Clients,
    EquatableArray<AnyOfData> AnyOfs,
    EquatableArray<TypeData> Types,
    EquatableArray<Authorization> Authorizations,
    EquatableArray<Tag> Tags,
    Client Converters,
    IReadOnlyList<SchemaContext> Schemas,
    IReadOnlyList<SchemaContext> FilteredSchemas,
    Times Times);