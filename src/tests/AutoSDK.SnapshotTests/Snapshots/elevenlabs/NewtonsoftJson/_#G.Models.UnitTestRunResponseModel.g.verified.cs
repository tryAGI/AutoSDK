//HintName: G.Models.UnitTestRunResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnitTestRunResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestRunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_info")]
        public global::G.TestInfoVariant1? TestInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_invocation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestInvocationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_node_id")]
        public string? WorkflowNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TestRunStatusJsonConverter))]
        public global::G.TestRunStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_responses")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? AgentResponses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestId { get; set; } = default!;

        /// <summary>
        /// Default Value: Unknown Test
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_name")]
        public string? TestName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition_result")]
        public global::G.TestConditionResultCommonModel? ConditionResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at_unix")]
        public int? LastUpdatedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.TestRunMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestRunResponseModel" /> class.
        /// </summary>
        /// <param name="testRunId"></param>
        /// <param name="testInvocationId"></param>
        /// <param name="agentId"></param>
        /// <param name="status"></param>
        /// <param name="testId"></param>
        /// <param name="testInfo"></param>
        /// <param name="branchId"></param>
        /// <param name="workflowNodeId"></param>
        /// <param name="agentResponses"></param>
        /// <param name="testName">
        /// Default Value: Unknown Test
        /// </param>
        /// <param name="conditionResult"></param>
        /// <param name="lastUpdatedAtUnix"></param>
        /// <param name="metadata"></param>
        public UnitTestRunResponseModel(
            string testRunId,
            string testInvocationId,
            string agentId,
            global::G.TestRunStatus status,
            string testId,
            global::G.TestInfoVariant1? testInfo,
            string? branchId,
            string? workflowNodeId,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? agentResponses,
            string? testName,
            global::G.TestConditionResultCommonModel? conditionResult,
            int? lastUpdatedAtUnix,
            global::G.TestRunMetadata? metadata)
        {
            this.TestRunId = testRunId ?? throw new global::System.ArgumentNullException(nameof(testRunId));
            this.TestInfo = testInfo;
            this.TestInvocationId = testInvocationId ?? throw new global::System.ArgumentNullException(nameof(testInvocationId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BranchId = branchId;
            this.WorkflowNodeId = workflowNodeId;
            this.Status = status;
            this.AgentResponses = agentResponses;
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.TestName = testName;
            this.ConditionResult = conditionResult;
            this.LastUpdatedAtUnix = lastUpdatedAtUnix;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestRunResponseModel" /> class.
        /// </summary>
        public UnitTestRunResponseModel()
        {
        }
    }
}