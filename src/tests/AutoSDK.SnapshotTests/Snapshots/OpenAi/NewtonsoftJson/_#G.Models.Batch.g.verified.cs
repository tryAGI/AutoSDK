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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `batch`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.BatchObject Object { get; set; }

        /// <summary>
        /// The OpenAI API endpoint used by the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::G.BatchErrors? Errors { get; set; }

        /// <summary>
        /// The ID of the input file for the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputFileId { get; set; } = default!;

        /// <summary>
        /// The time frame within which the batch should be processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_window", Required = global::Newtonsoft.Json.Required.Always)]
        public string CompletionWindow { get; set; } = default!;

        /// <summary>
        /// The current status of the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BatchStatus Status { get; set; } = default!;

        /// <summary>
        /// The ID of the file containing the outputs of successfully executed requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_file_id")]
        public string? OutputFileId { get; set; }

        /// <summary>
        /// The ID of the file containing the outputs of requests with errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_file_id")]
        public string? ErrorFileId { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started processing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_progress_at")]
        public global::System.DateTimeOffset? InProgressAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started finalizing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finalizing_at")]
        public global::System.DateTimeOffset? FinalizingAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_at")]
        public global::System.DateTimeOffset? FailedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expired_at")]
        public global::System.DateTimeOffset? ExpiredAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started cancelling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelling_at")]
        public global::System.DateTimeOffset? CancellingAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was cancelled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_at")]
        public global::System.DateTimeOffset? CancelledAt { get; set; }

        /// <summary>
        /// The request counts for different statuses within the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_counts")]
        public global::G.BatchRequestCounts? RequestCounts { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Batch? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Batch>(
                json,
                jsonSerializerOptions);
        }

    }
}