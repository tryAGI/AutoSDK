//HintName: G.Models.AliasDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"alias_name":"blogs-title","collection_name":"arivx-title"}
    /// </summary>
    public sealed partial class AliasDescription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AliasName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasDescription" /> class.
        /// </summary>
        /// <param name="aliasName"></param>
        /// <param name="collectionName"></param>
        public AliasDescription(
            string aliasName,
            string collectionName)
        {
            this.AliasName = aliasName ?? throw new global::System.ArgumentNullException(nameof(aliasName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasDescription" /> class.
        /// </summary>
        public AliasDescription()
        {
        }
    }
}