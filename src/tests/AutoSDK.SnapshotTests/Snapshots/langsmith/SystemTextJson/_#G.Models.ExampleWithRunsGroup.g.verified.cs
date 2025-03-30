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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public string? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p50")]
        public double? LatencyP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p99")]
        public double? LatencyP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_stats")]
        public object? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object GroupKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.ExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>> Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        public string? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        public string? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_rate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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