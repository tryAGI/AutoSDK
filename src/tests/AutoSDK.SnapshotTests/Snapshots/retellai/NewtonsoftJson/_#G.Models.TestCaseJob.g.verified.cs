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
        [global::Newtonsoft.Json.JsonProperty("test_case_job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestCaseJobId { get; set; } = default!;

        /// <summary>
        /// Status of the test case job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TestCaseJobStatusJsonConverter))]
        public global::G.TestCaseJobStatus Status { get; set; } = default!;

        /// <summary>
        /// ID of the test case definition used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_case_definition_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestCaseDefinitionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_case_definition_snapshot", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestCaseDefinition TestCaseDefinitionSnapshot { get; set; } = default!;

        /// <summary>
        /// Snapshot of the transcript generated during test execution. Can be either ConversationFlowPlaygroundSnapshot or MultiStatePromptPlaygroundSnapshot
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript_snapshot")]
        public object? TranscriptSnapshot { get; set; }

        /// <summary>
        /// Explanation of the test result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_explanation")]
        public string? ResultExplanation { get; set; }

        /// <summary>
        /// Timestamp when the test case job was created (milliseconds since epoch)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public long CreationTimestamp { get; set; } = default!;

        /// <summary>
        /// Timestamp when the test case job was last modified (milliseconds since epoch)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_modified_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public long UserModifiedTimestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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