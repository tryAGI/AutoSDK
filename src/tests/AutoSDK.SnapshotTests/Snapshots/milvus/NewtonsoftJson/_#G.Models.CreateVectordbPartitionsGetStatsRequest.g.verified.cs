//HintName: G.Models.CreateVectordbPartitionsGetStatsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbPartitionsGetStatsRequest
    {
        /// <summary>
        /// The name of an existing database. The value defaults to __default__.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of an existing collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// The name of the target partition of this operation. 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partitionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string PartitionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbPartitionsGetStatsRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of an existing collection.
        /// </param>
        /// <param name="partitionName">
        /// The name of the target partition of this operation. 
        /// </param>
        /// <param name="dbName">
        /// The name of an existing database. The value defaults to __default__.
        /// </param>
        public CreateVectordbPartitionsGetStatsRequest(
            string collectionName,
            string partitionName,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.PartitionName = partitionName ?? throw new global::System.ArgumentNullException(nameof(partitionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbPartitionsGetStatsRequest" /> class.
        /// </summary>
        public CreateVectordbPartitionsGetStatsRequest()
        {
        }
    }
}