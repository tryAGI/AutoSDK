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
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of an existing collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// A scalar filtering condition to filter matching entities.    The value defaults to an empty string, indicating that no condition applies. Setting both **id** and **filter** results in an error.<br/>
        /// You can set this parameter to an empty string to skip scalar filtering. To build a scalar filtering condition, refer to [Boolean Expression Rules](https://milvus.io/docs/boolean.md). 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filter { get; set; }

        /// <summary>
        /// The name of a partition in the current collection. <br/>
        /// If specified, the data is to be deleted from the specified partition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitionName")]
        public string? PartitionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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