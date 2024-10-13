//HintName: G.Models.PipelineTriggerTableRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PipelineTriggerTableRecord contains pipeline trigger metrics, aggregated by<br/>
    /// pipeline ID.
    /// </summary>
    public sealed partial class PipelineTriggerTableRecord
    {
        /// <summary>
        /// Pipeline ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// Pipeline UUID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineUid")]
        public string? PipelineUid { get; set; }

        /// <summary>
        /// Number of triggers with `STATUS_COMPLETED`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerCountCompleted")]
        public int? TriggerCountCompleted { get; set; }

        /// <summary>
        /// Number of triggers with `STATUS_ERRORED`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerCountErrored")]
        public int? TriggerCountErrored { get; set; }

        /// <summary>
        /// Version for the triggered pipeline if it is a release pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineReleaseId")]
        public string? PipelineReleaseId { get; set; }

        /// <summary>
        /// Release UUID for the triggered pipeline if it is a release pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineReleaseUid")]
        public string? PipelineReleaseUid { get; set; }

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
        public static global::G.PipelineTriggerTableRecord? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PipelineTriggerTableRecord>(
                json,
                jsonSerializerOptions);
        }

    }
}