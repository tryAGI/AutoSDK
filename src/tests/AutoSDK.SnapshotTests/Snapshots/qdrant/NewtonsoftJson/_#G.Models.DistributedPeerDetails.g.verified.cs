//HintName: G.Models.DistributedPeerDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributedPeerDetails
    {
        /// <summary>
        /// Qdrant version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Consensus role for the peer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.StateRole? Role { get; set; }

        /// <summary>
        /// Whether it can participate in leader elections
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_voter", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsVoter { get; set; } = default!;

        /// <summary>
        /// Election term
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("term", Required = global::Newtonsoft.Json.Required.Always)]
        public int Term { get; set; } = default!;

        /// <summary>
        /// Latest accepted commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Commit { get; set; } = default!;

        /// <summary>
        /// Number of operations pending for being applied
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_pending_operations", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumPendingOperations { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="DistributedPeerDetails" /> class.
        /// </summary>
        /// <param name="version">
        /// Qdrant version
        /// </param>
        /// <param name="isVoter">
        /// Whether it can participate in leader elections
        /// </param>
        /// <param name="term">
        /// Election term
        /// </param>
        /// <param name="commit">
        /// Latest accepted commit
        /// </param>
        /// <param name="numPendingOperations">
        /// Number of operations pending for being applied
        /// </param>
        /// <param name="consensusThreadStatus">
        /// Information about current consensus thread status
        /// </param>
        /// <param name="role">
        /// Consensus role for the peer
        /// </param>
        public DistributedPeerDetails(
            string version,
            bool isVoter,
            int term,
            int commit,
            int numPendingOperations,
            global::G.ConsensusThreadStatus consensusThreadStatus,
            global::G.StateRole? role)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Role = role;
            this.IsVoter = isVoter;
            this.Term = term;
            this.Commit = commit;
            this.NumPendingOperations = numPendingOperations;
            this.ConsensusThreadStatus = consensusThreadStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedPeerDetails" /> class.
        /// </summary>
        public DistributedPeerDetails()
        {
        }
    }
}