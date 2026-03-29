//HintName: G.Models.PartialPropertiesTableToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialPropertiesTableToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_hash")]
        public global::G.PartialTextOperators? AuthHash { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::G.PartialTextOperators? Key { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::G.PartialTextOperators? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPropertiesTableToOperators" /> class.
        /// </summary>
        /// <param name="authHash">
        /// Make all properties in T optional
        /// </param>
        /// <param name="key">
        /// Make all properties in T optional
        /// </param>
        /// <param name="value">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialPropertiesTableToOperators(
            global::G.PartialTextOperators? authHash,
            global::G.PartialTextOperators? key,
            global::G.PartialTextOperators? value)
        {
            this.AuthHash = authHash;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPropertiesTableToOperators" /> class.
        /// </summary>
        public PartialPropertiesTableToOperators()
        {
        }
    }
}