//HintName: G.Models.RepositoryRuleset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of rules to apply when specified conditions are met.
    /// </summary>
    public sealed partial class RepositoryRuleset
    {
        /// <summary>
        /// The ID of the ruleset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the ruleset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The target of the ruleset
        /// **Note**: The `push` target is in beta and is subject to change.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public RepositoryRulesetTarget? Target { get; set; }

        /// <summary>
        /// The type of the source of the ruleset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public RepositoryRulesetSourceType? SourceType { get; set; }

        /// <summary>
        /// The name of the source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public string Source { get; set; } = default!;

        /// <summary>
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforcement", Required = global::Newtonsoft.Json.Required.Always)]
        public RepositoryRulesetEnforcement Enforcement { get; set; } = default!;

        /// <summary>
        /// The actors that can bypass the rules in this ruleset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bypass_actors")]
        public global::System.Collections.Generic.IList<RepositoryRulesetBypassActor>? BypassActors { get; set; }

        /// <summary>
        /// The bypass type of the user making the API request for this ruleset. This field is only returned when
        /// querying the repository-level endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_can_bypass")]
        public RepositoryRulesetCurrentUserCanBypass? CurrentUserCanBypass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links")]
        public RepositoryRulesetLinks? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions")]
        public object? Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rules")]
        public global::System.Collections.Generic.IList<RepositoryRule>? Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}