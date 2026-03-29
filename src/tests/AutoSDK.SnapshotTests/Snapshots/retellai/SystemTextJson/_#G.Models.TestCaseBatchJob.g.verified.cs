//HintName: G.Models.TestCaseBatchJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestCaseBatchJob
    {
        /// <summary>
        /// Unique identifier for the test case batch job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_batch_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseBatchJobId { get; set; }

        /// <summary>
        /// Status of the batch job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestCaseBatchJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestCaseBatchJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseEngineJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseEngine ResponseEngine { get; set; }

        /// <summary>
        /// Number of test cases that passed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PassCount { get; set; }

        /// <summary>
        /// Number of test cases that failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailCount { get; set; }

        /// <summary>
        /// Number of test cases that encountered errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCount { get; set; }

        /// <summary>
        /// Total number of test cases in the batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Timestamp when the batch job was created (milliseconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreationTimestamp { get; set; }

        /// <summary>
        /// Timestamp when the batch job was last modified (milliseconds since epoch)
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
        /// Initializes a new instance of the <see cref="TestCaseBatchJob" /> class.
        /// </summary>
        /// <param name="testCaseBatchJobId">
        /// Unique identifier for the test case batch job
        /// </param>
        /// <param name="status">
        /// Status of the batch job
        /// </param>
        /// <param name="responseEngine"></param>
        /// <param name="passCount">
        /// Number of test cases that passed
        /// </param>
        /// <param name="failCount">
        /// Number of test cases that failed
        /// </param>
        /// <param name="errorCount">
        /// Number of test cases that encountered errors
        /// </param>
        /// <param name="totalCount">
        /// Total number of test cases in the batch
        /// </param>
        /// <param name="creationTimestamp">
        /// Timestamp when the batch job was created (milliseconds since epoch)
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// Timestamp when the batch job was last modified (milliseconds since epoch)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseBatchJob(
            string testCaseBatchJobId,
            global::G.TestCaseBatchJobStatus status,
            global::G.ResponseEngine responseEngine,
            int passCount,
            int failCount,
            int errorCount,
            int totalCount,
            long creationTimestamp,
            long userModifiedTimestamp)
        {
            this.TestCaseBatchJobId = testCaseBatchJobId ?? throw new global::System.ArgumentNullException(nameof(testCaseBatchJobId));
            this.Status = status;
            this.ResponseEngine = responseEngine;
            this.PassCount = passCount;
            this.FailCount = failCount;
            this.ErrorCount = errorCount;
            this.TotalCount = totalCount;
            this.CreationTimestamp = creationTimestamp;
            this.UserModifiedTimestamp = userModifiedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseBatchJob" /> class.
        /// </summary>
        public TestCaseBatchJob()
        {
        }
    }
}