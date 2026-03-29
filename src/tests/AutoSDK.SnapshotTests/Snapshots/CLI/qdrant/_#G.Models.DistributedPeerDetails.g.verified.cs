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
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Consensus role for the peer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::G.StateRole? Role { get; set; }

        /// <summary>
        /// Whether it can participate in leader elections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_voter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVoter { get; set; }

        /// <summary>
        /// Election term
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Term { get; set; }

        /// <summary>
        /// Latest accepted commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Commit { get; set; }

        /// <summary>
        /// Number of operations pending for being applied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_pending_operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumPendingOperations { get; set; }

        /// <summary>
        /// Information about current consensus thread status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus_thread_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConsensusThreadStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConsensusThreadStatus ConsensusThreadStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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