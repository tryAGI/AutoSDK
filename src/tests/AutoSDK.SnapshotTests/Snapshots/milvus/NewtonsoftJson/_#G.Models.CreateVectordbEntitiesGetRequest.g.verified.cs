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
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the collection to which this operation applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// A specific entity ID or a list of entity IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<int?, string, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>> Id { get; set; } = default!;

        /// <summary>
        /// An array of fields to return along with the search results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputFields")]
        public global::System.Collections.Generic.IList<string>? OutputFields { get; set; }

        /// <summary>
        /// The name of the partitions to which this operation applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partitionNames")]
        public global::System.Collections.Generic.IList<string>? PartitionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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