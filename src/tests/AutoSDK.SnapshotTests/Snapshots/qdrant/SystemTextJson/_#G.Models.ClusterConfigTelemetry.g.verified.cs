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
        [global::System.Text.Json.Serialization.JsonPropertyName("grpc_timeout_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GrpcTimeoutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p2p")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.P2pConfigTelemetry P2p { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConsensusConfigTelemetry Consensus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigTelemetry" /> class.
        /// </summary>
        /// <param name="grpcTimeoutMs"></param>
        /// <param name="p2p"></param>
        /// <param name="consensus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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