//HintName: G.Models.PeerUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single peer in the network.
    /// </summary>
    public sealed partial class PeerUpdate
    {
        /// <summary>
        /// The session ID of the peer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Human readable name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The location where the peer is exposed to the internet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// The latest known hash of the peer's schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemaHash")]
        public string? SchemaHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}