//HintName: G.Models.AliasCollection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AliasCollection
    {
        /// <summary>
        /// The name of the database to which the collection belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the target collection to reassign an alias to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// The alias of the collection. 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliasName", Required = global::Newtonsoft.Json.Required.Always)]
        public string AliasName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasCollection" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the target collection to reassign an alias to.
        /// </param>
        /// <param name="aliasName">
        /// The alias of the collection. 
        /// </param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
        public AliasCollection(
            string collectionName,
            string aliasName,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.AliasName = aliasName ?? throw new global::System.ArgumentNullException(nameof(aliasName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasCollection" /> class.
        /// </summary>
        public AliasCollection()
        {
        }
    }
}