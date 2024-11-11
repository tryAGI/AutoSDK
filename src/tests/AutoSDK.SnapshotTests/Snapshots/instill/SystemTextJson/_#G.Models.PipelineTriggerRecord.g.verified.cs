//HintName: G.Models.PipelineTriggerRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PipelineTriggerRecord represents a pipeline execution event.
    /// </summary>
    public sealed partial class PipelineTriggerRecord
    {
        /// <summary>
        /// The moment when the pipeline was triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerTime")]
        public global::System.DateTime? TriggerTime { get; set; }

        /// <summary>
        /// UUID of the trigger.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineTriggerId")]
        public string? PipelineTriggerId { get; set; }

        /// <summary>
        /// Pipeline ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// Pipeline UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineUid")]
        public string? PipelineUid { get; set; }

        /// <summary>
        /// Trigger mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModeJsonConverter))]
        public global::G.Mode? TriggerMode { get; set; }

        /// <summary>
        /// Total execution duration.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeTimeDuration")]
        public float? ComputeTimeDuration { get; set; }

        /// <summary>
        /// Final status.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StatusJsonConverter))]
        public global::G.Status? Status { get; set; }

        /// <summary>
        /// If a release of the pipeline was triggered, pipeline version.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineReleaseId")]
        public string? PipelineReleaseId { get; set; }

        /// <summary>
        /// If a release of the pipeline was triggered, release UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineReleaseUid")]
        public string? PipelineReleaseUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineTriggerRecord" /> class.
        /// </summary>
        /// <param name="triggerTime">
        /// The moment when the pipeline was triggered.
        /// </param>
        /// <param name="pipelineTriggerId">
        /// UUID of the trigger.
        /// </param>
        /// <param name="pipelineId">
        /// Pipeline ID.
        /// </param>
        /// <param name="pipelineUid">
        /// Pipeline UUID.
        /// </param>
        /// <param name="triggerMode">
        /// Trigger mode.
        /// </param>
        /// <param name="computeTimeDuration">
        /// Total execution duration.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Final status.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineReleaseId">
        /// If a release of the pipeline was triggered, pipeline version.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineReleaseUid">
        /// If a release of the pipeline was triggered, release UUID.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineTriggerRecord(
            global::System.DateTime? triggerTime,
            string? pipelineTriggerId,
            string? pipelineId,
            string? pipelineUid,
            global::G.Mode? triggerMode,
            float? computeTimeDuration,
            global::G.Status? status,
            string? pipelineReleaseId,
            string? pipelineReleaseUid)
        {
            this.TriggerTime = triggerTime;
            this.PipelineTriggerId = pipelineTriggerId;
            this.PipelineId = pipelineId;
            this.PipelineUid = pipelineUid;
            this.TriggerMode = triggerMode;
            this.ComputeTimeDuration = computeTimeDuration;
            this.Status = status;
            this.PipelineReleaseId = pipelineReleaseId;
            this.PipelineReleaseUid = pipelineReleaseUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineTriggerRecord" /> class.
        /// </summary>
        public PipelineTriggerRecord()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.PipelineTriggerRecord? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.PipelineTriggerRecord),
                jsonSerializerContext) as global::G.PipelineTriggerRecord;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PipelineTriggerRecord? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.PipelineTriggerRecord>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.PipelineTriggerRecord?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.PipelineTriggerRecord),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.PipelineTriggerRecord;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PipelineTriggerRecord?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.PipelineTriggerRecord?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}