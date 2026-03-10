//HintName: G.Models.AgentVersionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentVersionMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seq_no_in_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SeqNoInBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_committed_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeCommittedSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentVersionParents Parents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionMetadata" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="branchId"></param>
        /// <param name="versionDescription"></param>
        /// <param name="seqNoInBranch"></param>
        /// <param name="timeCommittedSecs"></param>
        /// <param name="parents"></param>
        /// <param name="accessInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVersionMetadata(
            string id,
            string agentId,
            string branchId,
            string versionDescription,
            int seqNoInBranch,
            int timeCommittedSecs,
            global::G.AgentVersionParents parents,
            global::G.ResourceAccessInfo? accessInfo)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.VersionDescription = versionDescription ?? throw new global::System.ArgumentNullException(nameof(versionDescription));
            this.SeqNoInBranch = seqNoInBranch;
            this.TimeCommittedSecs = timeCommittedSecs;
            this.Parents = parents ?? throw new global::System.ArgumentNullException(nameof(parents));
            this.AccessInfo = accessInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionMetadata" /> class.
        /// </summary>
        public AgentVersionMetadata()
        {
        }
    }
}