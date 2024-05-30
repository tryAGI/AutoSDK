//HintName: G.Models.Batch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Batch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `batch`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.BatchObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required BatchObject Object { get; set; }

        /// <summary>
        /// The OpenAI API endpoint used by the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public BatchErrors? Errors { get; set; }

        /// <summary>
        /// The ID of the input file for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFileId { get; set; }

        /// <summary>
        /// The time frame within which the batch should be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompletionWindow { get; set; }

        /// <summary>
        /// The current status of the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.BatchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required BatchStatus Status { get; set; }

        /// <summary>
        /// The ID of the file containing the outputs of successfully executed requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_file_id")]
        public string? OutputFileId { get; set; }

        /// <summary>
        /// The ID of the file containing the outputs of requests with errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_file_id")]
        public string? ErrorFileId { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress_at")]
        public int InProgressAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started finalizing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalizing_at")]
        public int FinalizingAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public int CompletedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public int FailedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public int ExpiredAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started cancelling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelling_at")]
        public int CancellingAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_at")]
        public int CancelledAt { get; set; }

        /// <summary>
        /// The request counts for different statuses within the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_counts")]
        public BatchRequestCounts? RequestCounts { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}