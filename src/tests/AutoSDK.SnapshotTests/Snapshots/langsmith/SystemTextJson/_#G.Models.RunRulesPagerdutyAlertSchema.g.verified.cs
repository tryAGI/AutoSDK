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
        /// Enum for alert types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunRulesAlertTypeJsonConverter))]
        public global::G.RunRulesAlertType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoutingKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Enum for severity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PagerdutySeverityJsonConverter))]
        public global::G.PagerdutySeverity? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesPagerdutyAlertSchema" /> class.
        /// </summary>
        /// <param name="type">
        /// Enum for alert types.
        /// </param>
        /// <param name="routingKey"></param>
        /// <param name="summary"></param>
        /// <param name="severity">
        /// Enum for severity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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