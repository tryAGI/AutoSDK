//HintName: G.Models.VectorStoreExpirationAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expiration policy for a vector store.
    /// </summary>
    public sealed partial class VectorStoreExpirationAfter
    {
        /// <summary>
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Anchor { get; set; }

        /// <summary>
        /// The number of days after the anchor time that the vector store will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}