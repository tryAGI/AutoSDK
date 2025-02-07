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

        /// <summary>
        /// Initializes a new instance of the <see cref="PeerUpdate" /> class.
        /// </summary>
        /// <param name="id">
        /// The session ID of the peer.
        /// </param>
        /// <param name="name">
        /// Human readable name.
        /// </param>
        /// <param name="uri">
        /// The location where the peer is exposed to the internet.
        /// </param>
        /// <param name="schemaHash">
        /// The latest known hash of the peer's schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PeerUpdate(
            global::System.Guid? id,
            string? name,
            string? uri,
            string? schemaHash)
        {
            this.Id = id;
            this.Name = name;
            this.Uri = uri;
            this.SchemaHash = schemaHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeerUpdate" /> class.
        /// </summary>
        public PeerUpdate()
        {
        }
    }
}