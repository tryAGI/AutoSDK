//HintName: G.Models.RunStepObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a step in execution of a run.
    /// </summary>
    public sealed partial class RunStepObject
    {
        /// <summary>
        /// The identifier of the run step, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `thread.run.step`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.RunStepObjectObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run step was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The ID of the [assistant](/docs/api-reference/assistants) associated with the run step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssistantId { get; set; } = default!;

        /// <summary>
        /// The ID of the [thread](/docs/api-reference/threads) that was run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// The ID of the [run](/docs/api-reference/runs) that this run step is a part of.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunId { get; set; } = default!;

        /// <summary>
        /// The type of run step, which can be either `message_creation` or `tool_calls`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepObjectType Type { get; set; } = default!;

        /// <summary>
        /// The status of the run step, which can be either `in_progress`, `cancelled`, `failed`, `completed`, or `expired`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepObjectStatus Status { get; set; } = default!;

        /// <summary>
        /// The details of the run step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepObjectStepDetails StepDetails { get; set; } = default!;

        /// <summary>
        /// The last error associated with this run step. Will be `null` if there are no errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepObjectLastError? LastError { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run step expired. A step is considered expired if the parent run is expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expired_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? ExpiredAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run step was cancelled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? CancelledAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run step failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? FailedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run step completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? CompletedAt { get; set; } = default!;

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object? Metadata { get; set; } = default!;

        /// <summary>
        /// Usage statistics related to the run step. This value will be `null` while the run step's status is `in_progress`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepCompletionUsage? Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the run step, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `thread.run.step`.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the run step was created.
        /// </param>
        /// <param name="assistantId">
        /// The ID of the [assistant](/docs/api-reference/assistants) associated with the run step.
        /// </param>
        /// <param name="threadId">
        /// The ID of the [thread](/docs/api-reference/threads) that was run.
        /// </param>
        /// <param name="runId">
        /// The ID of the [run](/docs/api-reference/runs) that this run step is a part of.
        /// </param>
        /// <param name="type">
        /// The type of run step, which can be either `message_creation` or `tool_calls`.
        /// </param>
        /// <param name="status">
        /// The status of the run step, which can be either `in_progress`, `cancelled`, `failed`, `completed`, or `expired`.
        /// </param>
        /// <param name="stepDetails">
        /// The details of the run step.
        /// </param>
        /// <param name="lastError">
        /// The last error associated with this run step. Will be `null` if there are no errors.
        /// </param>
        /// <param name="expiredAt">
        /// The Unix timestamp (in seconds) for when the run step expired. A step is considered expired if the parent run is expired.
        /// </param>
        /// <param name="cancelledAt">
        /// The Unix timestamp (in seconds) for when the run step was cancelled.
        /// </param>
        /// <param name="failedAt">
        /// The Unix timestamp (in seconds) for when the run step failed.
        /// </param>
        /// <param name="completedAt">
        /// The Unix timestamp (in seconds) for when the run step completed.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </param>
        /// <param name="usage">
        /// Usage statistics related to the run step. This value will be `null` while the run step's status is `in_progress`.
        /// </param>
        public RunStepObject(
            string id,
            global::System.DateTimeOffset createdAt,
            string assistantId,
            string threadId,
            string runId,
            global::G.RunStepObjectType type,
            global::G.RunStepObjectStatus status,
            global::G.RunStepObjectStepDetails stepDetails,
            global::G.RunStepObjectLastError? lastError,
            global::System.DateTimeOffset? expiredAt,
            global::System.DateTimeOffset? cancelledAt,
            global::System.DateTimeOffset? failedAt,
            global::System.DateTimeOffset? completedAt,
            object? metadata,
            global::G.RunStepCompletionUsage? usage,
            global::G.RunStepObjectObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.AssistantId = assistantId ?? throw new global::System.ArgumentNullException(nameof(assistantId));
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.Type = type;
            this.Status = status;
            this.StepDetails = stepDetails;
            this.LastError = lastError ?? throw new global::System.ArgumentNullException(nameof(lastError));
            this.ExpiredAt = expiredAt;
            this.CancelledAt = cancelledAt;
            this.FailedAt = failedAt;
            this.CompletedAt = completedAt;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepObject" /> class.
        /// </summary>
        public RunStepObject()
        {
        }


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
        public static global::G.RunStepObject? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RunStepObject>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RunStepObject?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RunStepObject?>(serializer.Deserialize<global::G.RunStepObject>(jsonReader));
        }

    }
}