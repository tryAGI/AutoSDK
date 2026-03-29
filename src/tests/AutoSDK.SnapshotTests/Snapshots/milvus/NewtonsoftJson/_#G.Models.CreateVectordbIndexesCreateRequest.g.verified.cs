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
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        ///   The parameters that apply to the index-building process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexParams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IndexParam> IndexParams { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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