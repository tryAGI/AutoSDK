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
        [global::Newtonsoft.Json.JsonProperty("anchor", Required = global::Newtonsoft.Json.Required.Always)]
        public VectorStoreExpirationAfterAnchor Anchor { get; set; } = default!;

        /// <summary>
        /// The number of days after the anchor time that the vector store will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("days", Required = global::Newtonsoft.Json.Required.Always)]
        public int Days { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}