//HintName: G.Models.CreateVectordbEntitiesGetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbEntitiesGetRequest
    {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the collection to which this operation applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// A specific entity ID or a list of entity IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<int?, string, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<int?, string, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>> Id { get; set; }

        /// <summary>
        /// An array of fields to return along with the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFields")]
        public global::System.Collections.Generic.IList<string>? OutputFields { get; set; }

        /// <summary>
        /// The name of the partitions to which this operation applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitionNames")]
        public global::System.Collections.Generic.IList<string>? PartitionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesGetRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the collection to which this operation applies.
        /// </param>
        /// <param name="id">
        /// A specific entity ID or a list of entity IDs.
        /// </param>
        /// <param name="dbName">
        /// The name of the database.
        /// </param>
        /// <param name="outputFields">
        /// An array of fields to return along with the search results.
        /// </param>
        /// <param name="partitionNames">
        /// The name of the partitions to which this operation applies.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbEntitiesGetRequest(
            string collectionName,
            global::G.AnyOf<int?, string, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>> id,
            string? dbName,
            global::System.Collections.Generic.IList<string>? outputFields,
            global::System.Collections.Generic.IList<string>? partitionNames)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.Id = id;
            this.OutputFields = outputFields;
            this.PartitionNames = partitionNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesGetRequest" /> class.
        /// </summary>
        public CreateVectordbEntitiesGetRequest()
        {
        }
    }
}