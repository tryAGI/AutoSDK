//HintName: G.Models.ExampleWithRunsGroup.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Group of examples with runs.
    /// </summary>
    public sealed partial class ExampleWithRunsGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost")]
        public string? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_p50")]
        public double? LatencyP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_p99")]
        public double? LatencyP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_stats")]
        public object? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_key", Required = global::Newtonsoft.Json.Required.Always)]
        public object GroupKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>> Examples { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_cost")]
        public string? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_cost")]
        public string? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_rate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleWithRunsGroup" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="count"></param>
        /// <param name="totalTokens"></param>
        /// <param name="totalCost"></param>
        /// <param name="minStartTime"></param>
        /// <param name="maxStartTime"></param>
        /// <param name="latencyP50"></param>
        /// <param name="latencyP99"></param>
        /// <param name="feedbackStats"></param>
        /// <param name="groupKey"></param>
        /// <param name="examples"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="errorRate"></param>
        public ExampleWithRunsGroup(
            string filter,
            object groupKey,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>> examples,
            int? count,
            int? totalTokens,
            string? totalCost,
            global::System.DateTime? minStartTime,
            global::System.DateTime? maxStartTime,
            double? latencyP50,
            double? latencyP99,
            object? feedbackStats,
            int? promptTokens,
            int? completionTokens,
            string? promptCost,
            string? completionCost,
            double? errorRate)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.GroupKey = groupKey ?? throw new global::System.ArgumentNullException(nameof(groupKey));
            this.Examples = examples;
            this.Count = count;
            this.TotalTokens = totalTokens;
            this.TotalCost = totalCost;
            this.MinStartTime = minStartTime;
            this.MaxStartTime = maxStartTime;
            this.LatencyP50 = latencyP50;
            this.LatencyP99 = latencyP99;
            this.FeedbackStats = feedbackStats;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
            this.ErrorRate = errorRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleWithRunsGroup" /> class.
        /// </summary>
        public ExampleWithRunsGroup()
        {
        }
    }
}