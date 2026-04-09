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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_committed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int LastCommittedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_archived", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsArchived { get; set; } = default!;

        /// <summary>
        /// Default Value: writer_perms_required
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protection_status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BranchProtectionStatusJsonConverter))]
        public global::G.BranchProtectionStatus? ProtectionStatus { get; set; }

        /// <summary>
        /// Access information for the branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Percentage of traffic live on the branch<br/>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_live_percentage")]
        public double? CurrentLivePercentage { get; set; }

        /// <summary>
        /// Parent branch of the branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_branch")]
        public global::G.AgentBranchBasicInfo? ParentBranch { get; set; }

        /// <summary>
        /// Most recent versions on the branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("most_recent_versions")]
        public global::System.Collections.Generic.IList<global::G.AgentVersionMetadata>? MostRecentVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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