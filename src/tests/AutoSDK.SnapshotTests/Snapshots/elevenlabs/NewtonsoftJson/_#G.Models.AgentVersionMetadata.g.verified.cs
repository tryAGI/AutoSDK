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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionDescription { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seq_no_in_branch", Required = global::Newtonsoft.Json.Required.Always)]
        public int SeqNoInBranch { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_committed_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int TimeCommittedSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentVersionParents Parents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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