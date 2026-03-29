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
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public global::G.CreateProjectAutomationConfigVariant1EventType EventType { get; set; }

        /// <summary>
        /// BTQL filter to identify rows for the automation rule
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("btql_filter", Required = global::Newtonsoft.Json.Required.Always)]
        public string BtqlFilter { get; set; } = default!;

        /// <summary>
        /// Perform the triggered action at most once in this interval of seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double IntervalSeconds { get; set; } = default!;

        /// <summary>
        /// The action to take when the automation rule is triggered
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.CreateProjectAutomationConfigVariant1ActionVariant1, global::G.CreateProjectAutomationConfigVariant1ActionVariant2> Action { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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