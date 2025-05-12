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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::System.Guid? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run")]
        public global::System.Guid? ParentRun { get; set; }

        /// <summary>
        /// Enum for run types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunTypeEnumJsonConverter))]
        public global::G.RunTypeEnum? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Session { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_example")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceExample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_order")]
        public int? ExecutionOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public bool? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_filter")]
        public string? TreeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_root")]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Enum for run data source types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter))]
        public global::G.RunsFilterDataSourceTypeEnum? DataSourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_pagination")]
        public bool? SkipPagination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_filter")]
        public string? SearchFilter { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_experimental_search")]
        public bool? UseExperimentalSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, manifest, session_id, serialized, reference_example_id, reference_dataset_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade, thread_id]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("select")]
        public global::System.Collections.Generic.IList<global::G.RunSelect>? Select { get; set; }

        /// <summary>
        /// Enum for run start date order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunDateOrderJsonConverter))]
        public global::G.RunDateOrder? Order { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_prev_cursor")]
        public bool? SkipPrevCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyParamsForRunSchema" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trace"></param>
        /// <param name="parentRun"></param>
        /// <param name="runType">
        /// Enum for run types.
        /// </param>
        /// <param name="session"></param>
        /// <param name="referenceExample"></param>
        /// <param name="executionOrder"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="query"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="isRoot"></param>
        /// <param name="dataSourceType">
        /// Enum for run data source types.
        /// </param>
        /// <param name="skipPagination"></param>
        /// <param name="searchFilter"></param>
        /// <param name="useExperimentalSearch">
        /// Default Value: false
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="select">
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, manifest, session_id, serialized, reference_example_id, reference_dataset_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade, thread_id]
        /// </param>
        /// <param name="order">
        /// Enum for run start date order.
        /// </param>
        /// <param name="skipPrevCursor">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyParamsForRunSchema(
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            global::System.Guid? trace,
            global::System.Guid? parentRun,
            global::G.RunTypeEnum? runType,
            global::System.Collections.Generic.IList<global::System.Guid>? session,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceExample,
            int? executionOrder,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            bool? error,
            string? query,
            string? filter,
            string? traceFilter,
            string? treeFilter,
            bool? isRoot,
            global::G.RunsFilterDataSourceTypeEnum? dataSourceType,
            bool? skipPagination,
            string? searchFilter,
            bool? useExperimentalSearch,
            string? cursor,
            int? limit,
            global::System.Collections.Generic.IList<global::G.RunSelect>? select,
            global::G.RunDateOrder? order,
            bool? skipPrevCursor)
        {
            this.Id = id;
            this.Trace = trace;
            this.ParentRun = parentRun;
            this.RunType = runType;
            this.Session = session;
            this.ReferenceExample = referenceExample;
            this.ExecutionOrder = executionOrder;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Error = error;
            this.Query = query;
            this.Filter = filter;
            this.TraceFilter = traceFilter;
            this.TreeFilter = treeFilter;
            this.IsRoot = isRoot;
            this.DataSourceType = dataSourceType;
            this.SkipPagination = skipPagination;
            this.SearchFilter = searchFilter;
            this.UseExperimentalSearch = useExperimentalSearch;
            this.Cursor = cursor;
            this.Limit = limit;
            this.Select = select;
            this.Order = order;
            this.SkipPrevCursor = skipPrevCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyParamsForRunSchema" /> class.
        /// </summary>
        public BodyParamsForRunSchema()
        {
        }
    }
}