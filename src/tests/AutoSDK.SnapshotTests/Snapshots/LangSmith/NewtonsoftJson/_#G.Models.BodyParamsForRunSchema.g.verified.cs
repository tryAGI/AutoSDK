//HintName: G.Models.BodyParamsForRunSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace")]
        public global::G.AnyOf<global::System.Guid?, object>? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_run")]
        public global::G.AnyOf<global::System.Guid?, object>? ParentRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_type")]
        public global::G.AnyOf<global::G.RunTypeEnum?, object>? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? Session { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_example")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ReferenceExample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_order")]
        public global::G.AnyOf<int?, object>? ExecutionOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::G.AnyOf<global::System.DateTime?, object>? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::G.AnyOf<global::System.DateTime?, object>? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.AnyOf<bool?, object>? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public global::G.AnyOf<string, object>? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.AnyOf<string, object>? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_filter")]
        public global::G.AnyOf<string, object>? TraceFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree_filter")]
        public global::G.AnyOf<string, object>? TreeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_root")]
        public global::G.AnyOf<bool?, object>? IsRoot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_type")]
        public global::G.AnyOf<global::G.RunsFilterDataSourceTypeEnum?, object>? DataSourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public global::G.AnyOf<string, object>? Cursor { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int Limit { get; set; } = 100;

        /// <summary>
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, session_id, serialized, reference_example_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, child_run_ids, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("select")]
        public global::System.Collections.Generic.IList<global::G.RunSelect>? Select { get; set; }

        /// <summary>
        /// Default Value: desc
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order")]
        public global::G.AllOf<global::G.RunDateOrder?>? Order { get; set; } = global::G.RunDateOrder.Desc;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}