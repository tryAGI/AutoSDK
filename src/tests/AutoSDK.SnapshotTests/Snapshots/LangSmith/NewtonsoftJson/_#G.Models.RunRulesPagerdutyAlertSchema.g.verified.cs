//HintName: G.Models.RunRulesPagerdutyAlertSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        public global::System.AnyOf<global::G.RunRulesAlertType?, object>? Type { get; set; } = global::G.RunRulesAlertType.Pagerduty;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("routing_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string RoutingKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::System.AnyOf<string, object>? Summary { get; set; }

        /// <summary>
        /// Default Value: warning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity")]
        public global::System.AnyOf<global::G.PagerdutySeverity?, object>? Severity { get; set; } = global::G.PagerdutySeverity.Warning;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}