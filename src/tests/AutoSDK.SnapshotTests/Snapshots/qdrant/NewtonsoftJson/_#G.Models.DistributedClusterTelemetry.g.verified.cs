//HintName: G.Models.DistributedClusterTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributedClusterTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number_of_peers")]
        public int? NumberOfPeers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.DistributedPeerInfo> Peers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedClusterTelemetry" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="peers"></param>
        /// <param name="numberOfPeers"></param>
        public DistributedClusterTelemetry(
            bool enabled,
            global::System.Collections.Generic.Dictionary<string, global::G.DistributedPeerInfo> peers,
            int? numberOfPeers)
        {
            this.Enabled = enabled;
            this.NumberOfPeers = numberOfPeers;
            this.Peers = peers ?? throw new global::System.ArgumentNullException(nameof(peers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedClusterTelemetry" /> class.
        /// </summary>
        public DistributedClusterTelemetry()
        {
        }
    }
}