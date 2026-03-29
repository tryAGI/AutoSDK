//HintName: G.Models.CreateVectordbPartitionsHasRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbPartitionsHasRequest
    {
        /// <summary>
        /// The name of an existing database. The value defaults to __default__.
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
        /// The name of the partition to test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartitionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbPartitionsHasRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of an existing collection.
        /// </param>
        /// <param name="partitionName">
        /// The name of the partition to test.
        /// </param>
        /// <param name="dbName">
        /// The name of an existing database. The value defaults to __default__.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbPartitionsHasRequest(
            string collectionName,
            string partitionName,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.PartitionName = partitionName ?? throw new global::System.ArgumentNullException(nameof(partitionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbPartitionsHasRequest" /> class.
        /// </summary>
        public CreateVectordbPartitionsHasRequest()
        {
        }
    }
}