//HintName: G.Models.CreateVectordbIndexesDescribeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbIndexesDescribeRequest
    {
        /// <summary>
        /// The name of the database to which the collection belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of an the collection to which the index belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// The name of the index to describe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbIndexesDescribeRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of an the collection to which the index belongs.
        /// </param>
        /// <param name="indexName">
        /// The name of the index to describe.
        /// </param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbIndexesDescribeRequest(
            string collectionName,
            string indexName,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbIndexesDescribeRequest" /> class.
        /// </summary>
        public CreateVectordbIndexesDescribeRequest()
        {
        }
    }
}