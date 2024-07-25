//HintName: G.Models.TracerSession.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// TracerSession schema.
    /// </summary>
    public sealed partial class TracerSession
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.AnyOf<global::System.DateTime, object?>? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra")]
        public global::System.AnyOf<object?, object?>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::System.AnyOf<string?, object?>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_dataset_id")]
        public global::System.AnyOf<string?, object?>? DefaultDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_dataset_id")]
        public global::System.AnyOf<string?, object?>? ReferenceDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_tier")]
        public global::System.AnyOf<global::G.TraceTier?, object?>? TraceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_count")]
        public global::System.AnyOf<int, object?>? RunCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_p50")]
        public global::System.AnyOf<double, object?>? LatencyP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_p99")]
        public global::System.AnyOf<double, object?>? LatencyP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_token_p50")]
        public global::System.AnyOf<double, object?>? FirstTokenP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_token_p99")]
        public global::System.AnyOf<double, object?>? FirstTokenP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public global::System.AnyOf<int, object?>? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public global::System.AnyOf<int, object?>? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public global::System.AnyOf<int, object?>? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost")]
        public global::System.AnyOf<string?, object?>? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_cost")]
        public global::System.AnyOf<string?, object?>? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_cost")]
        public global::System.AnyOf<string?, object?>? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_run_start_time")]
        public global::System.AnyOf<global::System.DateTime, object?>? LastRunStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_run_start_time_live")]
        public global::System.AnyOf<global::System.DateTime, object?>? LastRunStartTimeLive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_stats")]
        public global::System.AnyOf<object?, object?>? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_feedback_stats")]
        public global::System.AnyOf<object?, object?>? SessionFeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_facets")]
        public global::System.AnyOf<global::System.Collections.Generic.IList<object?>?, object?>? RunFacets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_rate")]
        public global::System.AnyOf<double, object?>? ErrorRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("streaming_rate")]
        public global::System.AnyOf<double, object?>? StreamingRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_run_number")]
        public global::System.AnyOf<int, object?>? TestRunNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}