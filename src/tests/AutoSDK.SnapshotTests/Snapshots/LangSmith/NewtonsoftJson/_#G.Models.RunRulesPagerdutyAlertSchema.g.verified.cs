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
        /// Enum for severity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity")]
        public global::G.PagerdutySeverity? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}