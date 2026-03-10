//HintName: G.Models.AgentBranchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentBranchResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_committed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastCommittedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsArchived { get; set; }

        /// <summary>
        /// Default Value: writer_perms_required
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BranchProtectionStatusJsonConverter))]
        public global::G.BranchProtectionStatus? ProtectionStatus { get; set; }

        /// <summary>
        /// Access information for the branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Percentage of traffic live on the branch<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_live_percentage")]
        public double? CurrentLivePercentage { get; set; }

        /// <summary>
        /// Parent branch of the branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_branch")]
        public global::G.AgentBranchBasicInfo? ParentBranch { get; set; }

        /// <summary>
        /// Most recent versions on the branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_versions")]
        public global::System.Collections.Generic.IList<global::G.AgentVersionMetadata>? MostRecentVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBranchResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="agentId"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastCommittedAt"></param>
        /// <param name="isArchived"></param>
        /// <param name="protectionStatus">
        /// Default Value: writer_perms_required
        /// </param>
        /// <param name="accessInfo">
        /// Access information for the branch
        /// </param>
        /// <param name="currentLivePercentage">
        /// Percentage of traffic live on the branch<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="parentBranch">
        /// Parent branch of the branch
        /// </param>
        /// <param name="mostRecentVersions">
        /// Most recent versions on the branch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBranchResponse(
            string id,
            string name,
            string agentId,
            string description,
            int createdAt,
            int lastCommittedAt,
            bool isArchived,
            global::G.BranchProtectionStatus? protectionStatus,
            global::G.ResourceAccessInfo? accessInfo,
            double? currentLivePercentage,
            global::G.AgentBranchBasicInfo? parentBranch,
            global::System.Collections.Generic.IList<global::G.AgentVersionMetadata>? mostRecentVersions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
            this.LastCommittedAt = lastCommittedAt;
            this.IsArchived = isArchived;
            this.ProtectionStatus = protectionStatus;
            this.AccessInfo = accessInfo;
            this.CurrentLivePercentage = currentLivePercentage;
            this.ParentBranch = parentBranch;
            this.MostRecentVersions = mostRecentVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBranchResponse" /> class.
        /// </summary>
        public AgentBranchResponse()
        {
        }
    }
}