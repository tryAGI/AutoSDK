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
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PeerMetadata" /> class.
        /// </summary>
        /// <param name="version">
        /// Peer Qdrant version
        /// </param>
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