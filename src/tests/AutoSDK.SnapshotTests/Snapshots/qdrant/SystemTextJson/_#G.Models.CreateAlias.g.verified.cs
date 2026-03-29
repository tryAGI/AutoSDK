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
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AliasName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAlias" /> class.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="aliasName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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