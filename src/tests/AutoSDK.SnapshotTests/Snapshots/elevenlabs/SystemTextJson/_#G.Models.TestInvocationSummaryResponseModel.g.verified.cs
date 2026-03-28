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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the agent this test invocation belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The ID of the branch this test invocation was run on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Creation time of the test invocation in unix seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Number of test runs in this invocation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TestRunCount { get; set; }

        /// <summary>
        /// Number of test runs that passed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PassedCount { get; set; }

        /// <summary>
        /// Number of test runs that failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedCount { get; set; }

        /// <summary>
        /// Number of test runs that are pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingCount { get; set; }

        /// <summary>
        /// Title of the test invocation - either the single test name or count of tests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The access information of the test invocation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInvocationSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the test invocation
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
        /// <param name="agentId">
        /// The ID of the agent this test invocation belongs to
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch this test invocation was run on
        /// </param>
        /// <param name="accessInfo">
        /// The access information of the test invocation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
            this.AgentId = agentId;
            this.BranchId = branchId;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.TestRunCount = testRunCount;
            this.PassedCount = passedCount;
            this.FailedCount = failedCount;
            this.PendingCount = pendingCount;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
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