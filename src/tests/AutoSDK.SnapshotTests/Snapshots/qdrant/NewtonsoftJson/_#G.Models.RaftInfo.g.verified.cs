//HintName: G.Models.RaftInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary information about the current raft state
    /// </summary>
    public sealed partial class RaftInfo
    {
        /// <summary>
        /// Raft divides time into terms of arbitrary length, each beginning with an election. If a candidate wins the election, it remains the leader for the rest of the term. The term number increases monotonically. Each server stores the current term number which is also exchanged in every communication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("term", Required = global::Newtonsoft.Json.Required.Always)]
        public int Term { get; set; } = default!;

        /// <summary>
        /// The index of the latest committed (finalized) operation that this peer is aware of.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Commit { get; set; } = default!;

        /// <summary>
        /// Number of consensus operations pending to be applied on this peer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_operations", Required = global::Newtonsoft.Json.Required.Always)]
        public int PendingOperations { get; set; } = default!;

        /// <summary>
        /// Leader of the current term
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("leader")]
        public int? Leader { get; set; }

        /// <summary>
        /// Role of this peer in the current term
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.StateRole? Role { get; set; }

        /// <summary>
        /// Is this peer a voter or a learner
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_voter", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsVoter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RaftInfo" /> class.
        /// </summary>
        /// <param name="term">
        /// Raft divides time into terms of arbitrary length, each beginning with an election. If a candidate wins the election, it remains the leader for the rest of the term. The term number increases monotonically. Each server stores the current term number which is also exchanged in every communication.
        /// </param>
        /// <param name="commit">
        /// The index of the latest committed (finalized) operation that this peer is aware of.
        /// </param>
        /// <param name="pendingOperations">
        /// Number of consensus operations pending to be applied on this peer
        /// </param>
        /// <param name="isVoter">
        /// Is this peer a voter or a learner
        /// </param>
        /// <param name="leader">
        /// Leader of the current term
        /// </param>
        /// <param name="role">
        /// Role of this peer in the current term
        /// </param>
        public RaftInfo(
            int term,
            int commit,
            int pendingOperations,
            bool isVoter,
            int? leader,
            global::G.StateRole? role)
        {
            this.Term = term;
            this.Commit = commit;
            this.PendingOperations = pendingOperations;
            this.Leader = leader;
            this.Role = role;
            this.IsVoter = isVoter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RaftInfo" /> class.
        /// </summary>
        public RaftInfo()
        {
        }
    }
}