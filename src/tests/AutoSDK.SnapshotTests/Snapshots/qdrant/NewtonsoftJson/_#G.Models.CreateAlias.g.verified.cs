//HintName: G.Models.CreateAlias.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create alternative name for a collection. Collection will be available under both names for search, retrieve,
    /// </summary>
    public sealed partial class CreateAlias
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AliasName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAlias" /> class.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="aliasName"></param>
        public CreateAlias(
            string collectionName,
            string aliasName)
        {
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.AliasName = aliasName ?? throw new global::System.ArgumentNullException(nameof(aliasName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAlias" /> class.
        /// </summary>
        public CreateAlias()
        {
        }
    }
}