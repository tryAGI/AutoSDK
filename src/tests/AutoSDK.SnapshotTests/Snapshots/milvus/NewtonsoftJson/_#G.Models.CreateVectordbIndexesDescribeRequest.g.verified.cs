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
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of an the collection to which the index belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// The name of the index to describe.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexName", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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