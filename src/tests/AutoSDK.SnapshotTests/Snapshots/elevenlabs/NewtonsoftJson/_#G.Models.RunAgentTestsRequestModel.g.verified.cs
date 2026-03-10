//HintName: G.Models.RunAgentTestsRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunAgentTestsRequestModel
    {
        /// <summary>
        /// List of tests to run on the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SingleTestRunRequestModel> Tests { get; set; } = default!;

        /// <summary>
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_config_override")]
        public global::G.AdhocAgentConfigOverrideForTestRequestModel? AgentConfigOverride { get; set; }

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
        /// Initializes a new instance of the <see cref="RunAgentTestsRequestModel" /> class.
        /// </summary>
        /// <param name="tests">
        /// List of tests to run on the agent
        /// </param>
        /// <param name="agentConfigOverride">
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </param>
        /// <param name="branchId">
        /// ID of the branch to run the tests on. If not provided, the tests will be run on the agent default configuration.
        /// </param>
        public RunAgentTestsRequestModel(
            global::System.Collections.Generic.IList<global::G.SingleTestRunRequestModel> tests,
            global::G.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride,
            string? branchId)
        {
            this.Tests = tests ?? throw new global::System.ArgumentNullException(nameof(tests));
            this.AgentConfigOverride = agentConfigOverride;
            this.BranchId = branchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAgentTestsRequestModel" /> class.
        /// </summary>
        public RunAgentTestsRequestModel()
        {
        }
    }
}