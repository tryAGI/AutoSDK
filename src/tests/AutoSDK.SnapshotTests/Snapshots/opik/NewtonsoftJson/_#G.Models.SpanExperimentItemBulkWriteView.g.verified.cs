//HintName: G.Models.SpanExperimentItemBulkWriteView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanExperimentItemBulkWriteView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanExperimentItemBulkWriteViewTypeJsonConverter))]
        public global::G.SpanExperimentItemBulkWriteViewType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::G.JsonListStringExperimentItemBulkWriteView? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.JsonListStringExperimentItemBulkWriteView? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.JsonListStringExperimentItemBulkWriteView? Metadata { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::System.Collections.Generic.Dictionary<string, int>? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_info")]
        public global::G.ErrorInfoExperimentItemBulkWriteView? ErrorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_estimated_cost_version")]
        public string? TotalEstimatedCostVersion { get; set; }

        /// <summary>
        /// Time to first token in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttft")]
        public double? Ttft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanExperimentItemBulkWriteViewSourceJsonConverter))]
        public global::G.SpanExperimentItemBulkWriteViewSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanExperimentItemBulkWriteView" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="id"></param>
        /// <param name="parentSpanId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="tags"></param>
        /// <param name="usage"></param>
        /// <param name="errorInfo"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="totalEstimatedCost"></param>
        /// <param name="totalEstimatedCostVersion"></param>
        /// <param name="ttft">
        /// Time to first token in milliseconds
        /// </param>
        /// <param name="source"></param>
        public SpanExperimentItemBulkWriteView(
            global::System.DateTime startTime,
            global::System.Guid? id,
            global::System.Guid? parentSpanId,
            string? name,
            global::G.SpanExperimentItemBulkWriteViewType? type,
            global::System.DateTime? endTime,
            global::G.JsonListStringExperimentItemBulkWriteView? input,
            global::G.JsonListStringExperimentItemBulkWriteView? output,
            global::G.JsonListStringExperimentItemBulkWriteView? metadata,
            string? model,
            string? provider,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.Dictionary<string, int>? usage,
            global::G.ErrorInfoExperimentItemBulkWriteView? errorInfo,
            global::System.DateTime? lastUpdatedAt,
            double? totalEstimatedCost,
            string? totalEstimatedCostVersion,
            double? ttft,
            global::G.SpanExperimentItemBulkWriteViewSource? source)
        {
            this.Id = id;
            this.ParentSpanId = parentSpanId;
            this.Name = name;
            this.Type = type;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Input = input;
            this.Output = output;
            this.Metadata = metadata;
            this.Model = model;
            this.Provider = provider;
            this.Tags = tags;
            this.Usage = usage;
            this.ErrorInfo = errorInfo;
            this.LastUpdatedAt = lastUpdatedAt;
            this.TotalEstimatedCost = totalEstimatedCost;
            this.TotalEstimatedCostVersion = totalEstimatedCostVersion;
            this.Ttft = ttft;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanExperimentItemBulkWriteView" /> class.
        /// </summary>
        public SpanExperimentItemBulkWriteView()
        {
        }
    }
}