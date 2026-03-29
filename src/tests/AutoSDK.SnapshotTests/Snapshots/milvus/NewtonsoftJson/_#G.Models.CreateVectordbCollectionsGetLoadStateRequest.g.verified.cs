//HintName: G.Models.CreateVectordbCollectionsGetLoadStateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsGetLoadStateRequest
    {
        /// <summary>
        /// The name of a database to which the collection belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of a collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// A list of partition names. If any partition names are specified, releasing any of these partitions results in the return of a NotLoad state.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partitionNames")]
        public string? PartitionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsGetLoadStateRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of a collection.
        /// </param>
        /// <param name="dbName">
        /// The name of a database to which the collection belongs.
        /// </param>
        /// <param name="partitionNames">
        /// A list of partition names. If any partition names are specified, releasing any of these partitions results in the return of a NotLoad state.
        /// </param>
        public CreateVectordbCollectionsGetLoadStateRequest(
            string collectionName,
            string? dbName,
            string? partitionNames)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.PartitionNames = partitionNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsGetLoadStateRequest" /> class.
        /// </summary>
        public CreateVectordbCollectionsGetLoadStateRequest()
        {
        }
    }
}