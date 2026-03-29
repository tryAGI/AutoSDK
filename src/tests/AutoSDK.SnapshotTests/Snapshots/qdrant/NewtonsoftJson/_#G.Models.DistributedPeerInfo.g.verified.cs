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
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// Whether this peer responded for this request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responsive", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Responsive { get; set; } = default!;

        /// <summary>
        /// If responsive, these details should be available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.DistributedPeerDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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