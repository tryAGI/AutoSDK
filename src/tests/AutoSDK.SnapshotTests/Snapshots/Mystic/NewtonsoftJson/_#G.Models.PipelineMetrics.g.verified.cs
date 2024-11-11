//HintName: G.Models.PipelineMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PipelineId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PipelineName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pointers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Pointers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedRunCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_run_at")]
        public global::System.DateTime? LastRunAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_failed_at")]
        public global::System.DateTime? LastFailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_compute_time_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int AvgComputeTimeMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_compute_time_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalComputeTimeMs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineMetrics" /> class.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pipelineName"></param>
        /// <param name="pointers"></param>
        /// <param name="runCount"></param>
        /// <param name="failedRunCount"></param>
        /// <param name="lastRunAt"></param>
        /// <param name="lastFailedAt"></param>
        /// <param name="avgComputeTimeMs"></param>
        /// <param name="totalComputeTimeMs"></param>
        public PipelineMetrics(
            string pipelineId,
            string pipelineName,
            global::System.Collections.Generic.IList<string> pointers,
            int runCount,
            int failedRunCount,
            int avgComputeTimeMs,
            int totalComputeTimeMs,
            global::System.DateTime? lastRunAt,
            global::System.DateTime? lastFailedAt)
        {
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.PipelineName = pipelineName ?? throw new global::System.ArgumentNullException(nameof(pipelineName));
            this.Pointers = pointers ?? throw new global::System.ArgumentNullException(nameof(pointers));
            this.RunCount = runCount;
            this.FailedRunCount = failedRunCount;
            this.AvgComputeTimeMs = avgComputeTimeMs;
            this.TotalComputeTimeMs = totalComputeTimeMs;
            this.LastRunAt = lastRunAt;
            this.LastFailedAt = lastFailedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineMetrics" /> class.
        /// </summary>
        public PipelineMetrics()
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
        public static global::G.PipelineMetrics? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PipelineMetrics>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.PipelineMetrics?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.PipelineMetrics?>(serializer.Deserialize<global::G.PipelineMetrics>(jsonReader));
        }

    }
}