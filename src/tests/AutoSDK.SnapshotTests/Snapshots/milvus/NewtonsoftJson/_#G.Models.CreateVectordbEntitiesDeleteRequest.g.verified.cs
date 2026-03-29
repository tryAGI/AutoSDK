//HintName: G.Models.CreateVectordbEntitiesDeleteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbEntitiesDeleteRequest
    {
        /// <summary>
        /// The name of the target database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of an existing collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// A scalar filtering condition to filter matching entities.    The value defaults to an empty string, indicating that no condition applies. Setting both **id** and **filter** results in an error.<br/>
        /// You can set this parameter to an empty string to skip scalar filtering. To build a scalar filtering condition, refer to [Boolean Expression Rules](https://milvus.io/docs/boolean.md). 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filter { get; set; } = default!;

        /// <summary>
        /// The name of a partition in the current collection. <br/>
        /// If specified, the data is to be deleted from the specified partition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partitionName")]
        public string? PartitionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesDeleteRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of an existing collection.
        /// </param>
        /// <param name="filter">
        /// A scalar filtering condition to filter matching entities.    The value defaults to an empty string, indicating that no condition applies. Setting both **id** and **filter** results in an error.<br/>
        /// You can set this parameter to an empty string to skip scalar filtering. To build a scalar filtering condition, refer to [Boolean Expression Rules](https://milvus.io/docs/boolean.md). 
        /// </param>
        /// <param name="dbName">
        /// The name of the target database.
        /// </param>
        /// <param name="partitionName">
        /// The name of a partition in the current collection. <br/>
        /// If specified, the data is to be deleted from the specified partition.
        /// </param>
        public CreateVectordbEntitiesDeleteRequest(
            string collectionName,
            string filter,
            string? dbName,
            string? partitionName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.PartitionName = partitionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesDeleteRequest" /> class.
        /// </summary>
        public CreateVectordbEntitiesDeleteRequest()
        {
        }
    }
}