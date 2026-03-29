//HintName: G.Models.PeerInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information of a peer in the cluster
    /// </summary>
    public sealed partial class PeerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PeerInfo" /> class.
        /// </summary>
        /// <param name="uri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PeerInfo(
            string uri)
        {
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeerInfo" /> class.
        /// </summary>
        public PeerInfo()
        {
        }
    }
}