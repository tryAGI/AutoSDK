//HintName: G.Models.TestCaseJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestCaseJob
    {
        /// <summary>
        /// Unique identifier for the test case job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseJobId { get; set; }

        /// <summary>
        /// Status of the test case job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestCaseJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestCaseJobStatus Status { get; set; }

        /// <summary>
        /// ID of the test case definition used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_definition_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseDefinitionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_definition_snapshot")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestCaseDefinitionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestCaseDefinition TestCaseDefinitionSnapshot { get; set; }

        /// <summary>
        /// Snapshot of the transcript generated during test execution. Can be either ConversationFlowPlaygroundSnapshot or MultiStatePromptPlaygroundSnapshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_snapshot")]
        public object? TranscriptSnapshot { get; set; }

        /// <summary>
        /// Explanation of the test result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_explanation")]
        public string? ResultExplanation { get; set; }

        /// <summary>
        /// Timestamp when the test case job was created (milliseconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreationTimestamp { get; set; }

        /// <summary>
        /// Timestamp when the test case job was last modified (milliseconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserModifiedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseJob" /> class.
        /// </summary>
        /// <param name="testCaseJobId">
        /// Unique identifier for the test case job
        /// </param>
        /// <param name="status">
        /// Status of the test case job
        /// </param>
        /// <param name="testCaseDefinitionId">
        /// ID of the test case definition used
        /// </param>
        /// <param name="testCaseDefinitionSnapshot"></param>
        /// <param name="creationTimestamp">
        /// Timestamp when the test case job was created (milliseconds since epoch)
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// Timestamp when the test case job was last modified (milliseconds since epoch)
        /// </param>
        /// <param name="transcriptSnapshot">
        /// Snapshot of the transcript generated during test execution. Can be either ConversationFlowPlaygroundSnapshot or MultiStatePromptPlaygroundSnapshot
        /// </param>
        /// <param name="resultExplanation">
        /// Explanation of the test result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseJob(
            string testCaseJobId,
            global::G.TestCaseJobStatus status,
            string testCaseDefinitionId,
            global::G.TestCaseDefinition testCaseDefinitionSnapshot,
            long creationTimestamp,
            long userModifiedTimestamp,
            object? transcriptSnapshot,
            string? resultExplanation)
        {
            this.TestCaseJobId = testCaseJobId ?? throw new global::System.ArgumentNullException(nameof(testCaseJobId));
            this.Status = status;
            this.TestCaseDefinitionId = testCaseDefinitionId ?? throw new global::System.ArgumentNullException(nameof(testCaseDefinitionId));
            this.TestCaseDefinitionSnapshot = testCaseDefinitionSnapshot;
            this.TranscriptSnapshot = transcriptSnapshot;
            this.ResultExplanation = resultExplanation;
            this.CreationTimestamp = creationTimestamp;
            this.UserModifiedTimestamp = userModifiedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseJob" /> class.
        /// </summary>
        public TestCaseJob()
        {
        }
    }
}