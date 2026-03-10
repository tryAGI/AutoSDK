//HintName: G.Models.DependentBranchInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependentBranchInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_main", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsMain { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentBranchInfo" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentName"></param>
        /// <param name="branchId"></param>
        /// <param name="branchName"></param>
        /// <param name="isMain"></param>
        public DependentBranchInfo(
            string agentId,
            string agentName,
            string branchId,
            string branchName,
            bool isMain)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.BranchName = branchName ?? throw new global::System.ArgumentNullException(nameof(branchName));
            this.IsMain = isMain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentBranchInfo" /> class.
        /// </summary>
        public DependentBranchInfo()
        {
        }
    }
}