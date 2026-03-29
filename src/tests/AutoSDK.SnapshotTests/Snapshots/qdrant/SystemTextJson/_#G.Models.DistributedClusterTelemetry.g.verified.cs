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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_peers")]
        public int? NumberOfPeers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.DistributedPeerInfo> Peers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedClusterTelemetry" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="peers"></param>
        /// <param name="numberOfPeers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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