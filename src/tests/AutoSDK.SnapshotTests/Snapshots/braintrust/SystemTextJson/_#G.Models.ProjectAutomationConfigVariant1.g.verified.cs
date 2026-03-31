//HintName: G.Models.ProjectAutomationConfigVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectAutomationConfigVariant1
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectAutomationConfigVariant1EventTypeJsonConverter))]
        public global::G.ProjectAutomationConfigVariant1EventType EventType { get; set; }

        /// <summary>
        /// BTQL filter to identify rows for the automation rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btql_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BtqlFilter { get; set; }

        /// <summary>
        /// Perform the triggered action at most once in this interval of seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IntervalSeconds { get; set; }

        /// <summary>
        /// The action to take when the automation rule is triggered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ProjectAutomationConfigVariant1ActionVariant1, global::G.ProjectAutomationConfigVariant1ActionVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.ProjectAutomationConfigVariant1ActionVariant1, global::G.ProjectAutomationConfigVariant1ActionVariant2> Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant1" /> class.
        /// </summary>
        /// <param name="btqlFilter">
        /// BTQL filter to identify rows for the automation rule
        /// </param>
        /// <param name="intervalSeconds">
        /// Perform the triggered action at most once in this interval of seconds
        /// </param>
        /// <param name="action">
        /// The action to take when the automation rule is triggered
        /// </param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectAutomationConfigVariant1(
            string btqlFilter,
            double intervalSeconds,
            global::G.OneOf<global::G.ProjectAutomationConfigVariant1ActionVariant1, global::G.ProjectAutomationConfigVariant1ActionVariant2> action,
            global::G.ProjectAutomationConfigVariant1EventType eventType)
        {
            this.EventType = eventType;
            this.BtqlFilter = btqlFilter ?? throw new global::System.ArgumentNullException(nameof(btqlFilter));
            this.IntervalSeconds = intervalSeconds;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant1" /> class.
        /// </summary>
        public ProjectAutomationConfigVariant1()
        {
        }
    }
}