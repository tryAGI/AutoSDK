//HintName: G.Models.CreateVectordbIndexesListRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbIndexesListRequest
    {
        /// <summary>
        /// The name of the database to which the collection belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DbName { get; set; } = default!;

        /// <summary>
        /// The name of an existing collection. Setting this to a non-existing collection leads to an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName")]
        public string? CollectionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbIndexesListRequest" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
        /// <param name="collectionName">
        /// The name of an existing collection. Setting this to a non-existing collection leads to an error.
        /// </param>
        public CreateVectordbIndexesListRequest(
            string dbName,
            string? collectionName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CollectionName = collectionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbIndexesListRequest" /> class.
        /// </summary>
        public CreateVectordbIndexesListRequest()
        {
        }
    }
}