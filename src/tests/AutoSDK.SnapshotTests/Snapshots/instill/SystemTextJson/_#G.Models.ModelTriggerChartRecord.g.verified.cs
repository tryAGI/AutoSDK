//HintName: G.Models.ModelTriggerChartRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ModelTriggerChartRecord represents a timeline of model triggers. It<br/>
    /// contains a collection of (timestamp, count) pairs that represent the total<br/>
    /// model triggers in a given time bucket.
    /// </summary>
    public sealed partial class ModelTriggerChartRecord
    {
        /// <summary>
        /// This field will be present present when the information is grouped by model.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Time buckets.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeBuckets")]
        public global::System.Collections.Generic.IList<global::System.DateTime>? TimeBuckets { get; set; }

        /// <summary>
        /// Aggregated trigger count in each time bucket.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerCounts")]
        public global::System.Collections.Generic.IList<int>? TriggerCounts { get; set; }

        /// <summary>
        /// The ID of the namespace that requested the model triggers.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requesterId")]
        public string? RequesterId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTriggerChartRecord" /> class.
        /// </summary>
        /// <param name="modelId">
        /// This field will be present present when the information is grouped by model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="timeBuckets">
        /// Time buckets.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="triggerCounts">
        /// Aggregated trigger count in each time bucket.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="requesterId">
        /// The ID of the namespace that requested the model triggers.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelTriggerChartRecord(
            string? modelId,
            global::System.Collections.Generic.IList<global::System.DateTime>? timeBuckets,
            global::System.Collections.Generic.IList<int>? triggerCounts,
            string? requesterId)
        {
            this.ModelId = modelId;
            this.TimeBuckets = timeBuckets;
            this.TriggerCounts = triggerCounts;
            this.RequesterId = requesterId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTriggerChartRecord" /> class.
        /// </summary>
        public ModelTriggerChartRecord()
        {
        }
    }
}