//HintName: G.Models.CreateVectordbIndexesCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbIndexesCreateRequest
    {
        /// <summary>
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        ///   The parameters that apply to the index-building process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexParams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.IndexParam> IndexParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbIndexesCreateRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="indexParams">
        ///   The parameters that apply to the index-building process.
        /// </param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbIndexesCreateRequest(
            string collectionName,
            global::System.Collections.Generic.IList<global::G.IndexParam> indexParams,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.IndexParams = indexParams ?? throw new global::System.ArgumentNullException(nameof(indexParams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbIndexesCreateRequest" /> class.
        /// </summary>
        public CreateVectordbIndexesCreateRequest()
        {
        }
    }
}