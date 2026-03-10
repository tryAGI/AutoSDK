//HintName: G.Models.TestRunMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestRunMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkspaceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ran_by_user_email", Required = global::Newtonsoft.Json.Required.Always)]
        public string RanByUserEmail { get; set; } = default!;

        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_type")]
        public global::G.TestRunMetadataTestType? TestType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunMetadata" /> class.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="testName"></param>
        /// <param name="ranByUserEmail"></param>
        /// <param name="testType">
        /// Default Value: llm
        /// </param>
        public TestRunMetadata(
            string workspaceId,
            string testName,
            string ranByUserEmail,
            global::G.TestRunMetadataTestType? testType)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.TestName = testName ?? throw new global::System.ArgumentNullException(nameof(testName));
            this.RanByUserEmail = ranByUserEmail ?? throw new global::System.ArgumentNullException(nameof(ranByUserEmail));
            this.TestType = testType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunMetadata" /> class.
        /// </summary>
        public TestRunMetadata()
        {
        }
    }
}