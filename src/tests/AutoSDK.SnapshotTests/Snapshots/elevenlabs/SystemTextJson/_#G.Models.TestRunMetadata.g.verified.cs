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
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ran_by_user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RanByUserEmail { get; set; }

        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestRunMetadataTestTypeJsonConverter))]
        public global::G.TestRunMetadataTestType? TestType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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