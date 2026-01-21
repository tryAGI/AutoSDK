//HintName: G.Models.RunRulesPagerdutyAlertSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunRulesPagerdutyAlertSchema
    {
        /// <summary>
        /// Default Value: pagerduty
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunRulesAlertType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("routing_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string RoutingKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Default Value: warning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity")]
        public global::G.PagerdutySeverity? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesPagerdutyAlertSchema" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: pagerduty
        /// </param>
        /// <param name="routingKey"></param>
        /// <param name="summary"></param>
        /// <param name="severity">
        /// Default Value: warning
        /// </param>
        public RunRulesPagerdutyAlertSchema(
            string routingKey,
            global::G.RunRulesAlertType? type,
            string? summary,
            global::G.PagerdutySeverity? severity)
        {
            this.RoutingKey = routingKey ?? throw new global::System.ArgumentNullException(nameof(routingKey));
            this.Type = type;
            this.Summary = summary;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesPagerdutyAlertSchema" /> class.
        /// </summary>
        public RunRulesPagerdutyAlertSchema()
        {
        }
    }
}