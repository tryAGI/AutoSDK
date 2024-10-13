//HintName: G.Models.BodyParamsForRunSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query params for run endpoints.
    /// </summary>
    public sealed partial class BodyParamsForRunSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace")]
        public global::System.Guid? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_run")]
        public global::System.Guid? ParentRun { get; set; }

        /// <summary>
        /// Enum for run types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_type")]
        public global::G.RunTypeEnum? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Session { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_example")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceExample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_order")]
        public int? ExecutionOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public bool? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree_filter")]
        public string? TreeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_root")]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Enum for run data source types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_type")]
        public global::G.RunsFilterDataSourceTypeEnum? DataSourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; } = 100;

        /// <summary>
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, session_id, serialized, reference_example_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("select")]
        public global::System.Collections.Generic.IList<global::G.RunSelect>? Select { get; set; }

        /// <summary>
        /// Enum for run start date order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order")]
        public global::G.RunDateOrder? Order { get; set; }

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
        public static global::G.BodyParamsForRunSchema? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BodyParamsForRunSchema>(
                json,
                jsonSerializerOptions);
        }

    }
}