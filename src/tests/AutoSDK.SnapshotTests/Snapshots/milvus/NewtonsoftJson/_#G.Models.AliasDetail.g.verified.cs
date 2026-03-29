//HintName: G.Models.AliasDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AliasDetail
    {
        /// <summary>
        /// The name of the database to which the collection belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DbName { get; set; } = default!;

        /// <summary>
        /// the name of the collection to which an alias belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// The name of the alias.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliasName", Required = global::Newtonsoft.Json.Required.Always)]
        public string AliasName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasDetail" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
        /// <param name="collectionName">
        /// the name of the collection to which an alias belongs.
        /// </param>
        /// <param name="aliasName">
        /// The name of the alias.
        /// </param>
        public AliasDetail(
            string dbName,
            string collectionName,
            string aliasName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.AliasName = aliasName ?? throw new global::System.ArgumentNullException(nameof(aliasName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasDetail" /> class.
        /// </summary>
        public AliasDetail()
        {
        }
    }
}