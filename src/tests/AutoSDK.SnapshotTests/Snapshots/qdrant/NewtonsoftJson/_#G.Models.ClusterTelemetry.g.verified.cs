//HintName: G.Models.ClusterTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClusterTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ClusterStatusTelemetry? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.ClusterConfigTelemetry? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peers")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PeerInfo>? Peers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_metadata")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PeerMetadata>? PeerMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resharding_enabled")]
        public bool? ReshardingEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterTelemetry" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="status"></param>
        /// <param name="config"></param>
        /// <param name="peers"></param>
        /// <param name="peerMetadata"></param>
        /// <param name="metadata"></param>
        /// <param name="reshardingEnabled"></param>
        public ClusterTelemetry(
            bool enabled,
            global::G.ClusterStatusTelemetry? status,
            global::G.ClusterConfigTelemetry? config,
            global::System.Collections.Generic.Dictionary<string, global::G.PeerInfo>? peers,
            global::System.Collections.Generic.Dictionary<string, global::G.PeerMetadata>? peerMetadata,
            object? metadata,
            bool? reshardingEnabled)
        {
            this.Enabled = enabled;
            this.Status = status;
            this.Config = config;
            this.Peers = peers;
            this.PeerMetadata = peerMetadata;
            this.Metadata = metadata;
            this.ReshardingEnabled = reshardingEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterTelemetry" /> class.
        /// </summary>
        public ClusterTelemetry()
        {
        }
    }
}