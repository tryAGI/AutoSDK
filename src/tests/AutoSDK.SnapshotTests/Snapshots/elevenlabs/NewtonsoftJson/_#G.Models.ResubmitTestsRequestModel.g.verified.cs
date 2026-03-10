//HintName: G.Models.ResubmitTestsRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResubmitTestsRequestModel
    {
        /// <summary>
        /// List of test run IDs to resubmit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_run_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TestRunIds { get; set; } = default!;

        /// <summary>
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_config_override")]
        public global::G.AdhocAgentConfigOverrideForTestRequestModel? AgentConfigOverride { get; set; }

        /// <summary>
        /// Agent ID to resubmit tests for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// ID of the branch to run the tests on. If not provided, the tests will be run on the agent default configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResubmitTestsRequestModel" /> class.
        /// </summary>
        /// <param name="testRunIds">
        /// List of test run IDs to resubmit
        /// </param>
        /// <param name="agentConfigOverride">
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </param>
        /// <param name="agentId">
        /// Agent ID to resubmit tests for
        /// </param>
        /// <param name="branchId">
        /// ID of the branch to run the tests on. If not provided, the tests will be run on the agent default configuration.
        /// </param>
        public ResubmitTestsRequestModel(
            global::System.Collections.Generic.IList<string> testRunIds,
            string agentId,
            global::G.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride,
            string? branchId)
        {
            this.TestRunIds = testRunIds ?? throw new global::System.ArgumentNullException(nameof(testRunIds));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentConfigOverride = agentConfigOverride;
            this.BranchId = branchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResubmitTestsRequestModel" /> class.
        /// </summary>
        public ResubmitTestsRequestModel()
        {
        }
    }
}