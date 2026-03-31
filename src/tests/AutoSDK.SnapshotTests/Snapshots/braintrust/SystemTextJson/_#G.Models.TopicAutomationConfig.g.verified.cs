//HintName: G.Models.TopicAutomationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicAutomationConfig
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TopicAutomationConfigEventTypeJsonConverter))]
        public global::G.TopicAutomationConfigEventType EventType { get; set; }

        /// <summary>
        /// The sampling rate for topic automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SamplingRate { get; set; }

        /// <summary>
        /// Facet functions used by the topic automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facet_functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AllOf<global::G.SavedFunctionId?, global::G.AnyOf<global::G.TopicAutomationConfigFacetFunctionVariant2Function, global::G.TopicAutomationConfigFacetFunctionVariant2Global>?>> FacetFunctions { get; set; }

        /// <summary>
        /// Topic map functions with optional per-topic-map filters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_map_functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TopicMapFunctionAutomation> TopicMapFunctions { get; set; }

        /// <summary>
        /// Execution scope for topic automation. Defaults to span-level execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.SpanScope, global::G.TraceScope, global::G.GroupScope, object>))]
        public global::G.AnyOf<global::G.SpanScope, global::G.TraceScope, global::G.GroupScope, object>? Scope { get; set; }

        /// <summary>
        /// Optional data scope for topic automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TopicAutomationDataScopeJsonConverter))]
        public global::G.TopicAutomationDataScope? DataScope { get; set; }

        /// <summary>
        /// Optional BTQL filter applied before topic automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btql_filter")]
        public string? BtqlFilter { get; set; }

        /// <summary>
        /// Optional default time range for backfill operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_time_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.TopicAutomationConfigBackfillTimeRange, object>))]
        public global::G.AnyOf<string, global::G.TopicAutomationConfigBackfillTimeRange, object>? BackfillTimeRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicAutomationConfig" /> class.
        /// </summary>
        /// <param name="samplingRate">
        /// The sampling rate for topic automation
        /// </param>
        /// <param name="facetFunctions">
        /// Facet functions used by the topic automation
        /// </param>
        /// <param name="topicMapFunctions">
        /// Topic map functions with optional per-topic-map filters
        /// </param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
        /// <param name="scope">
        /// Execution scope for topic automation. Defaults to span-level execution.
        /// </param>
        /// <param name="dataScope">
        /// Optional data scope for topic automation.
        /// </param>
        /// <param name="btqlFilter">
        /// Optional BTQL filter applied before topic automation.
        /// </param>
        /// <param name="backfillTimeRange">
        /// Optional default time range for backfill operations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicAutomationConfig(
            double samplingRate,
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.SavedFunctionId?, global::G.AnyOf<global::G.TopicAutomationConfigFacetFunctionVariant2Function, global::G.TopicAutomationConfigFacetFunctionVariant2Global>?>> facetFunctions,
            global::System.Collections.Generic.IList<global::G.TopicMapFunctionAutomation> topicMapFunctions,
            global::G.TopicAutomationConfigEventType eventType,
            global::G.AnyOf<global::G.SpanScope, global::G.TraceScope, global::G.GroupScope, object>? scope,
            global::G.TopicAutomationDataScope? dataScope,
            string? btqlFilter,
            global::G.AnyOf<string, global::G.TopicAutomationConfigBackfillTimeRange, object>? backfillTimeRange)
        {
            this.EventType = eventType;
            this.SamplingRate = samplingRate;
            this.FacetFunctions = facetFunctions ?? throw new global::System.ArgumentNullException(nameof(facetFunctions));
            this.TopicMapFunctions = topicMapFunctions ?? throw new global::System.ArgumentNullException(nameof(topicMapFunctions));
            this.Scope = scope;
            this.DataScope = dataScope;
            this.BtqlFilter = btqlFilter;
            this.BackfillTimeRange = backfillTimeRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicAutomationConfig" /> class.
        /// </summary>
        public TopicAutomationConfig()
        {
        }
    }
}