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
        [global::Newtonsoft.Json.JsonProperty("test_case_batch_job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestCaseBatchJobId { get; set; } = default!;

        /// <summary>
        /// Status of the batch job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TestCaseBatchJobStatusJsonConverter))]
        public global::G.TestCaseBatchJobStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_engine", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseEngine ResponseEngine { get; set; } = default!;

        /// <summary>
        /// Number of test cases that passed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pass_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PassCount { get; set; } = default!;

        /// <summary>
        /// Number of test cases that failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fail_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailCount { get; set; } = default!;

        /// <summary>
        /// Number of test cases that encountered errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ErrorCount { get; set; } = default!;

        /// <summary>
        /// Total number of test cases in the batch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// Timestamp when the batch job was created (milliseconds since epoch)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public long CreationTimestamp { get; set; } = default!;

        /// <summary>
        /// Timestamp when the batch job was last modified (milliseconds since epoch)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_modified_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public long UserModifiedTimestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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