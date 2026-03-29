//HintName: G.Models.HasReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HasReq
    {
        /// <summary>
        /// The name of the database in which to check the existence of a collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DbName { get; set; } = default!;

        /// <summary>
        /// The name of an existing collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HasReq" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of the database in which to check the existence of a collection.
        /// </param>
        /// <param name="collectionName">
        /// The name of an existing collection.
        /// </param>
        public HasReq(
            string dbName,
            string collectionName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HasReq" /> class.
        /// </summary>
        public HasReq()
        {
        }
    }
}