//HintName: G.Models.CreateVectordbCollectionsRenameRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsRenameRequest
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
        /// The name of the database to which the collection belongs after this operation.<br/>
        /// The value defaults to **default**. Setting this to a database rather than the one the collection belongs to before this operation moves this collection to the specified database.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newDbName")]
        public string? NewDbName { get; set; }

        /// <summary>
        /// The name of the target collection after this operation.<br/>
        /// Setting this to the value of **old_collection_name** results in a **MilvusException**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newCollectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewCollectionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsRenameRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="newCollectionName">
        /// The name of the target collection after this operation.<br/>
        /// Setting this to the value of **old_collection_name** results in a **MilvusException**.
        /// </param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        /// <param name="newDbName">
        /// The name of the database to which the collection belongs after this operation.<br/>
        /// The value defaults to **default**. Setting this to a database rather than the one the collection belongs to before this operation moves this collection to the specified database.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        public CreateVectordbCollectionsRenameRequest(
            string collectionName,
            string newCollectionName,
            string? dbName,
            string? newDbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.NewDbName = newDbName;
            this.NewCollectionName = newCollectionName ?? throw new global::System.ArgumentNullException(nameof(newCollectionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsRenameRequest" /> class.
        /// </summary>
        public CreateVectordbCollectionsRenameRequest()
        {
        }
    }
}