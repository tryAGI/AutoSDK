//HintName: G.Models.PartialUserApiKeysTableToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialUserApiKeysTableToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hash")]
        public global::G.PartialTextOperators? ApiKeyHash { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_name")]
        public global::G.PartialTextOperators? ApiKeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialUserApiKeysTableToOperators" /> class.
        /// </summary>
        /// <param name="apiKeyHash">
        /// Make all properties in T optional
        /// </param>
        /// <param name="apiKeyName">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialUserApiKeysTableToOperators(
            global::G.PartialTextOperators? apiKeyHash,
            global::G.PartialTextOperators? apiKeyName)
        {
            this.ApiKeyHash = apiKeyHash;
            this.ApiKeyName = apiKeyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialUserApiKeysTableToOperators" /> class.
        /// </summary>
        public PartialUserApiKeysTableToOperators()
        {
        }
    }
}