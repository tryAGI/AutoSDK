//HintName: G.Models.ClusterStatusVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Description of enabled cluster
    /// </summary>
    public sealed partial class ClusterStatusVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClusterStatusVariant2StatusJsonConverter))]
        public global::G.ClusterStatusVariant2Status Status { get; set; }

        /// <summary>
        /// ID of this peer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PeerId { get; set; } = default!;

        /// <summary>
        /// Peers composition of the cluster with main information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.PeerInfo> Peers { get; set; } = default!;

        /// <summary>
        /// Summary information about the current raft state
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raft_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RaftInfo RaftInfo { get; set; } = default!;

        /// <summary>
        /// Information about current consensus thread status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consensus_thread_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConsensusThreadStatus ConsensusThreadStatus { get; set; } = default!;

        /// <summary>
        /// Consequent failures of message send operations in consensus by peer address. On the first success to send to that peer - entry is removed from this hashmap.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_send_failures", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.MessageSendErrors> MessageSendFailures { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusVariant2" /> class.
        /// </summary>
        /// <param name="peerId">
        /// ID of this peer
        /// </param>
        /// <param name="peers">
        /// Peers composition of the cluster with main information
        /// </param>
        /// <param name="raftInfo">
        /// Summary information about the current raft state
        /// </param>
        /// <param name="consensusThreadStatus">
        /// Information about current consensus thread status
        /// </param>
        /// <param name="messageSendFailures">
        /// Consequent failures of message send operations in consensus by peer address. On the first success to send to that peer - entry is removed from this hashmap.
        /// </param>
        /// <param name="status"></param>
        public ClusterStatusVariant2(
            int peerId,
            global::System.Collections.Generic.Dictionary<string, global::G.PeerInfo> peers,
            global::G.RaftInfo raftInfo,
            global::G.ConsensusThreadStatus consensusThreadStatus,
            global::System.Collections.Generic.Dictionary<string, global::G.MessageSendErrors> messageSendFailures,
            global::G.ClusterStatusVariant2Status status)
        {
            this.Status = status;
            this.PeerId = peerId;
            this.Peers = peers ?? throw new global::System.ArgumentNullException(nameof(peers));
            this.RaftInfo = raftInfo ?? throw new global::System.ArgumentNullException(nameof(raftInfo));
            this.ConsensusThreadStatus = consensusThreadStatus;
            this.MessageSendFailures = messageSendFailures ?? throw new global::System.ArgumentNullException(nameof(messageSendFailures));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusVariant2" /> class.
        /// </summary>
        public ClusterStatusVariant2()
        {
        }
    }
}