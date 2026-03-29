//HintName: G.Models.ClusterConfigTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClusterConfigTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grpc_timeout_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int GrpcTimeoutMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p2p", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.P2pConfigTelemetry P2p { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consensus", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConsensusConfigTelemetry Consensus { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigTelemetry" /> class.
        /// </summary>
        /// <param name="grpcTimeoutMs"></param>
        /// <param name="p2p"></param>
        /// <param name="consensus"></param>
        public ClusterConfigTelemetry(
            int grpcTimeoutMs,
            global::G.P2pConfigTelemetry p2p,
            global::G.ConsensusConfigTelemetry consensus)
        {
            this.GrpcTimeoutMs = grpcTimeoutMs;
            this.P2p = p2p ?? throw new global::System.ArgumentNullException(nameof(p2p));
            this.Consensus = consensus ?? throw new global::System.ArgumentNullException(nameof(consensus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigTelemetry" /> class.
        /// </summary>
        public ClusterConfigTelemetry()
        {
        }
    }
}