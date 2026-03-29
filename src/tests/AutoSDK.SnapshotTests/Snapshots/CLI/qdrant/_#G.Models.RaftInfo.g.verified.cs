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
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Term { get; set; }

        /// <summary>
        /// The index of the latest committed (finalized) operation that this peer is aware of.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Commit { get; set; }

        /// <summary>
        /// Number of consensus operations pending to be applied on this peer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingOperations { get; set; }

        /// <summary>
        /// Leader of the current term
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leader")]
        public int? Leader { get; set; }

        /// <summary>
        /// Role of this peer in the current term
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::G.StateRole? Role { get; set; }

        /// <summary>
        /// Is this peer a voter or a learner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_voter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVoter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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