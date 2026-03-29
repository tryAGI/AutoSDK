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
        [global::System.Text.Json.Serialization.JsonPropertyName("alias_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AliasName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasDescription" /> class.
        /// </summary>
        /// <param name="aliasName"></param>
        /// <param name="collectionName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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