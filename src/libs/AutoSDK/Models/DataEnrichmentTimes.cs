namespace AutoSDK.Models;

public record struct DataEnrichmentTimes(
    TimeSpan CollectSchemas,
    TimeSpan Operations,
    TimeSpan EndPoints,
    TimeSpan Authorizations,
    TimeSpan Converters,
    TimeSpan TagsAndClients,
    TimeSpan JsonTypesAndOutputs,
    long AllocCollectSchemas = 0,
    long AllocOperations = 0,
    long AllocEndPoints = 0,
    long AllocAuthorizations = 0,
    long AllocConverters = 0,
    long AllocTagsAndClients = 0,
    long AllocJsonTypesAndOutputs = 0,
    TimeSpan PolymorphicArrays = default,
    TimeSpan SchemaModels = default,
    long AllocPolymorphicArrays = 0,
    long AllocSchemaModels = 0);
