//HintName: G.Models.PeerMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata describing extra properties for each peer
    /// </summary>
    public sealed partial class PeerMetadata
    {
        /// <summary>
        /// Peer Qdrant version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PeerMetadata" /> class.
        /// </summary>
        /// <param name="version">
        /// Peer Qdrant version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PeerMetadata(
            string version)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeerMetadata" /> class.
        /// </summary>
        public PeerMetadata()
        {
        }
    }
}