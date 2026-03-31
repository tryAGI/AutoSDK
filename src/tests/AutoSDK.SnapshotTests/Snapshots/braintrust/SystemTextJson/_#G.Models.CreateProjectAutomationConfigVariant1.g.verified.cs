//HintName: G.Models.CreateProjectAutomationConfigVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectAutomationConfigVariant1
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeJsonConverter))]
        public global::G.CreateProjectAutomationConfigVariant1EventType EventType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateProjectAutomationConfigVariant1ActionVariant1, global::G.CreateProjectAutomationConfigVariant1ActionVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.CreateProjectAutomationConfigVariant1ActionVariant1, global::G.CreateProjectAutomationConfigVariant1ActionVariant2> Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant1" /> class.
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
        public CreateProjectAutomationConfigVariant1(
            string btqlFilter,
            double intervalSeconds,
            global::G.OneOf<global::G.CreateProjectAutomationConfigVariant1ActionVariant1, global::G.CreateProjectAutomationConfigVariant1ActionVariant2> action,
            global::G.CreateProjectAutomationConfigVariant1EventType eventType)
        {
            this.EventType = eventType;
            this.BtqlFilter = btqlFilter ?? throw new global::System.ArgumentNullException(nameof(btqlFilter));
            this.IntervalSeconds = intervalSeconds;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant1" /> class.
        /// </summary>
        public CreateProjectAutomationConfigVariant1()
        {
        }
    }
}