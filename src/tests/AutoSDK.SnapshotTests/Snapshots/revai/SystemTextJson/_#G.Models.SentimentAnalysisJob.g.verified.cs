//HintName: G.Models.SentimentAnalysisJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rev.ai Sentiment Analysis Job
    /// </summary>
    public sealed partial class SentimentAnalysisJob
    {
        /// <summary>
        /// Job ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Current status of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SentimentAnalysisJobStatusJsonConverter))]
        public global::G.SentimentAnalysisJobStatus? Status { get; set; }

        /// <summary>
        /// Type of analysis performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Job creation timestamp in ISO-8601 UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_on")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Job completion timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_on")]
        public global::System.DateTime? CompletedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Number of words processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_count")]
        public int? WordCount { get; set; }

        /// <summary>
        /// Failure reason
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        public string? Failure { get; set; }

        /// <summary>
        /// Human-readable failure reason
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_detail")]
        public string? FailureDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisJob" /> class.
        /// </summary>
        /// <param name="id">
        /// Job ID
        /// </param>
        /// <param name="status">
        /// Current status of the job
        /// </param>
        /// <param name="type">
        /// Type of analysis performed
        /// </param>
        /// <param name="createdOn">
        /// Job creation timestamp in ISO-8601 UTC
        /// </param>
        /// <param name="completedOn">
        /// Job completion timestamp
        /// </param>
        /// <param name="language"></param>
        /// <param name="metadata"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="wordCount">
        /// Number of words processed
        /// </param>
        /// <param name="failure">
        /// Failure reason
        /// </param>
        /// <param name="failureDetail">
        /// Human-readable failure reason
        /// </param>
        /// <param name="deleteAfterSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentAnalysisJob(
            string? id,
            global::G.SentimentAnalysisJobStatus? status,
            string? type,
            global::System.DateTime? createdOn,
            global::System.DateTime? completedOn,
            string? language,
            string? metadata,
            string? callbackUrl,
            int? wordCount,
            string? failure,
            string? failureDetail,
            int? deleteAfterSeconds)
        {
            this.Id = id;
            this.Status = status;
            this.Type = type;
            this.CreatedOn = createdOn;
            this.CompletedOn = completedOn;
            this.Language = language;
            this.Metadata = metadata;
            this.CallbackUrl = callbackUrl;
            this.WordCount = wordCount;
            this.Failure = failure;
            this.FailureDetail = failureDetail;
            this.DeleteAfterSeconds = deleteAfterSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisJob" /> class.
        /// </summary>
        public SentimentAnalysisJob()
        {
        }
    }
}