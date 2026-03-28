//HintName: G.Models.GetTestSuiteInvocationResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTestSuiteInvocationResponseModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UnitTestRunResponseModel> TestRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestSuiteInvocationResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="testRuns"></param>
        /// <param name="agentId"></param>
        /// <param name="branchId"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTestSuiteInvocationResponseModel(
            string id,
            global::System.Collections.Generic.IList<global::G.UnitTestRunResponseModel> testRuns,
            string? agentId,
            string? branchId,
            int? createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId;
            this.BranchId = branchId;
            this.CreatedAt = createdAt;
            this.TestRuns = testRuns ?? throw new global::System.ArgumentNullException(nameof(testRuns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestSuiteInvocationResponseModel" /> class.
        /// </summary>
        public GetTestSuiteInvocationResponseModel()
        {
        }
    }
}