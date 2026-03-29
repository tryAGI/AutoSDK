//HintName: G.Models.ClusterStatusTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClusterStatusTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number_of_peers", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumberOfPeers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("term", Required = global::Newtonsoft.Json.Required.Always)]
        public int Term { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Commit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_operations", Required = global::Newtonsoft.Json.Required.Always)]
        public int PendingOperations { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.StateRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_voter", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsVoter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_id")]
        public int? PeerId { get; set; }

        /// <summary>
        /// Information about current consensus thread status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consensus_thread_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConsensusThreadStatus ConsensusThreadStatus { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusTelemetry" /> class.
        /// </summary>
        /// <param name="numberOfPeers"></param>
        /// <param name="term"></param>
        /// <param name="commit"></param>
        /// <param name="pendingOperations"></param>
        /// <param name="isVoter"></param>
        /// <param name="consensusThreadStatus">
        /// Information about current consensus thread status
        /// </param>
        /// <param name="role"></param>
        /// <param name="peerId"></param>
        public ClusterStatusTelemetry(
            int numberOfPeers,
            int term,
            int commit,
            int pendingOperations,
            bool isVoter,
            global::G.ConsensusThreadStatus consensusThreadStatus,
            global::G.StateRole? role,
            int? peerId)
        {
            this.NumberOfPeers = numberOfPeers;
            this.Term = term;
            this.Commit = commit;
            this.PendingOperations = pendingOperations;
            this.Role = role;
            this.IsVoter = isVoter;
            this.PeerId = peerId;
            this.ConsensusThreadStatus = consensusThreadStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusTelemetry" /> class.
        /// </summary>
        public ClusterStatusTelemetry()
        {
        }
    }
}