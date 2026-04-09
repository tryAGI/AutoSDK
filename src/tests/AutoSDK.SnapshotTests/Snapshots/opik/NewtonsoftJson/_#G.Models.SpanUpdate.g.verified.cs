//HintName: G.Models.SpanUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanUpdate
    {
        /// <summary>
        /// If null and project_id not specified, Default Project is assumed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// If null and project_name not specified, Default Project is assumed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TraceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_span_id")]
        public global::System.Guid? ParentSpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanUpdateTypeJsonConverter))]
        public global::G.SpanUpdateType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::G.JsonListString? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.JsonListString? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.JsonListString? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Tags to add
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_to_add")]
        public global::System.Collections.Generic.IList<string>? TagsToAdd { get; set; }

        /// <summary>
        /// Tags to remove
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_to_remove")]
        public global::System.Collections.Generic.IList<string>? TagsToRemove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::System.Collections.Generic.Dictionary<string, int>? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_info")]
        public global::G.ErrorInfo? ErrorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttft")]
        public double? Ttft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanUpdateSourceJsonConverter))]
        public global::G.SpanUpdateSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanUpdate" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="projectName">
        /// If null and project_id not specified, Default Project is assumed
        /// </param>
        /// <param name="projectId">
        /// If null and project_name not specified, Default Project is assumed
        /// </param>
        /// <param name="parentSpanId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="tags">
        /// Tags
        /// </param>
        /// <param name="tagsToAdd">
        /// Tags to add
        /// </param>
        /// <param name="tagsToRemove">
        /// Tags to remove
        /// </param>
        /// <param name="usage"></param>
        /// <param name="totalEstimatedCost"></param>
        /// <param name="errorInfo"></param>
        /// <param name="ttft"></param>
        /// <param name="source"></param>
        public SpanUpdate(
            global::System.Guid traceId,
            string? projectName,
            global::System.Guid? projectId,
            global::System.Guid? parentSpanId,
            string? name,
            global::G.SpanUpdateType? type,
            global::System.DateTime? endTime,
            global::G.JsonListString? input,
            global::G.JsonListString? output,
            global::G.JsonListString? metadata,
            string? model,
            string? provider,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Collections.Generic.IList<string>? tagsToRemove,
            global::System.Collections.Generic.Dictionary<string, int>? usage,
            double? totalEstimatedCost,
            global::G.ErrorInfo? errorInfo,
            double? ttft,
            global::G.SpanUpdateSource? source)
        {
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.TraceId = traceId;
            this.ParentSpanId = parentSpanId;
            this.Name = name;
            this.Type = type;
            this.EndTime = endTime;
            this.Input = input;
            this.Output = output;
            this.Metadata = metadata;
            this.Model = model;
            this.Provider = provider;
            this.Tags = tags;
            this.TagsToAdd = tagsToAdd;
            this.TagsToRemove = tagsToRemove;
            this.Usage = usage;
            this.TotalEstimatedCost = totalEstimatedCost;
            this.ErrorInfo = errorInfo;
            this.Ttft = ttft;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanUpdate" /> class.
        /// </summary>
        public SpanUpdate()
        {
        }
    }
}