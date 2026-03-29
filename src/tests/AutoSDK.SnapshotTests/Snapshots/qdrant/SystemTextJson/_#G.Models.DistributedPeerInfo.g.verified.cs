//HintName: G.Models.DistributedPeerInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributedPeerInfo
    {
        /// <summary>
        /// URI of the peer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Whether this peer responded for this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responsive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Responsive { get; set; }

        /// <summary>
        /// If responsive, these details should be available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::G.DistributedPeerDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedPeerInfo" /> class.
        /// </summary>
        /// <param name="uri">
        /// URI of the peer
        /// </param>
        /// <param name="responsive">
        /// Whether this peer responded for this request
        /// </param>
        /// <param name="details">
        /// If responsive, these details should be available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributedPeerInfo(
            string uri,
            bool responsive,
            global::G.DistributedPeerDetails? details)
        {
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Responsive = responsive;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedPeerInfo" /> class.
        /// </summary>
        public DistributedPeerInfo()
        {
        }
    }
}