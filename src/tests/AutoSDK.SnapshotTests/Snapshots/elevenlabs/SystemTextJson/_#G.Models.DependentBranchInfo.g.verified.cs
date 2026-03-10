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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_main")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentBranchInfo" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentName"></param>
        /// <param name="branchId"></param>
        /// <param name="branchName"></param>
        /// <param name="isMain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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