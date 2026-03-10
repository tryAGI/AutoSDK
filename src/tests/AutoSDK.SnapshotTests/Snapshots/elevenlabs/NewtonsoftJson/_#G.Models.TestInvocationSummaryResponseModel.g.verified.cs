//HintName: G.Models.TestInvocationSummaryResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestInvocationSummaryResponseModel
    {
        /// <summary>
        /// The ID of the test invocation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the agent this test invocation belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The ID of the branch this test invocation was run on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Creation time of the test invocation in unix seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnixSecs { get; set; } = default!;

        /// <summary>
        /// Number of test runs in this invocation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TestRunCount { get; set; } = default!;

        /// <summary>
        /// Number of test runs that passed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PassedCount { get; set; } = default!;

        /// <summary>
        /// Number of test runs that failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedCount { get; set; } = default!;

        /// <summary>
        /// Number of test runs that are pending
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PendingCount { get; set; } = default!;

        /// <summary>
        /// Title of the test invocation - either the single test name or count of tests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The access information of the test invocation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInvocationSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the test invocation
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent this test invocation belongs to
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch this test invocation was run on
        /// </param>
        /// <param name="createdAtUnixSecs">
        /// Creation time of the test invocation in unix seconds
        /// </param>
        /// <param name="testRunCount">
        /// Number of test runs in this invocation
        /// </param>
        /// <param name="passedCount">
        /// Number of test runs that passed
        /// </param>
        /// <param name="failedCount">
        /// Number of test runs that failed
        /// </param>
        /// <param name="pendingCount">
        /// Number of test runs that are pending
        /// </param>
        /// <param name="title">
        /// Title of the test invocation - either the single test name or count of tests
        /// </param>
        /// <param name="accessInfo">
        /// The access information of the test invocation
        /// </param>
        public TestInvocationSummaryResponseModel(
            string id,
            int createdAtUnixSecs,
            int testRunCount,
            int passedCount,
            int failedCount,
            int pendingCount,
            string title,
            string? agentId,
            string? branchId,
            global::G.ResourceAccessInfo? accessInfo)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.TestRunCount = testRunCount;
            this.PassedCount = passedCount;
            this.FailedCount = failedCount;
            this.PendingCount = pendingCount;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.AgentId = agentId;
            this.BranchId = branchId;
            this.AccessInfo = accessInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInvocationSummaryResponseModel" /> class.
        /// </summary>
        public TestInvocationSummaryResponseModel()
        {
        }
    }
}