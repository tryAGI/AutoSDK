//HintName: G.Models.OpenAIBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public object? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputFileId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_window", Required = global::Newtonsoft.Json.Required.Always)]
        public string CompletionWindow { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_file_id")]
        public string? OutputFileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_file_id")]
        public string? ErrorFileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_progress_at")]
        public int? InProgressAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_at")]
        public int? FailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finalizing_at")]
        public int? FinalizingAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExpiresAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expired_at")]
        public int? ExpiredAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_at")]
        public int? CancelledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelling_at")]
        public int? CancellingAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_counts")]
        public object? RequestCounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIBatch" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="endpoint"></param>
        /// <param name="errors"></param>
        /// <param name="inputFileId"></param>
        /// <param name="completionWindow"></param>
        /// <param name="status"></param>
        /// <param name="outputFileId"></param>
        /// <param name="errorFileId"></param>
        /// <param name="createdAt"></param>
        /// <param name="inProgressAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="failedAt"></param>
        /// <param name="finalizingAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="expiredAt"></param>
        /// <param name="cancelledAt"></param>
        /// <param name="cancellingAt"></param>
        /// <param name="requestCounts"></param>
        /// <param name="metadata"></param>
        public OpenAIBatch(
            string id,
            string @object,
            string endpoint,
            string inputFileId,
            string completionWindow,
            string status,
            int createdAt,
            int expiresAt,
            object? errors,
            string? outputFileId,
            string? errorFileId,
            int? inProgressAt,
            int? completedAt,
            int? failedAt,
            int? finalizingAt,
            int? expiredAt,
            int? cancelledAt,
            int? cancellingAt,
            object? requestCounts,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.CompletionWindow = completionWindow ?? throw new global::System.ArgumentNullException(nameof(completionWindow));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Errors = errors;
            this.OutputFileId = outputFileId;
            this.ErrorFileId = errorFileId;
            this.InProgressAt = inProgressAt;
            this.CompletedAt = completedAt;
            this.FailedAt = failedAt;
            this.FinalizingAt = finalizingAt;
            this.ExpiredAt = expiredAt;
            this.CancelledAt = cancelledAt;
            this.CancellingAt = cancellingAt;
            this.RequestCounts = requestCounts;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIBatch" /> class.
        /// </summary>
        public OpenAIBatch()
        {
        }
    }
}