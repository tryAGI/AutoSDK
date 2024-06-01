//HintName: G.Models.ReposCreateRepoRulesetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateRepoRulesetRequest
    {
        /// <summary>
        /// The name of the ruleset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The target of the ruleset
        /// **Note**: The `push` target is in beta and is subject to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposCreateRepoRulesetRequestTargetJsonConverter))]
        public ReposCreateRepoRulesetRequestTarget? Target { get; set; }

        /// <summary>
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposCreateRepoRulesetRequestEnforcementJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ReposCreateRepoRulesetRequestEnforcement Enforcement { get; set; }

        /// <summary>
        /// The actors that can bypass the rules in this ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass_actors")]
        public global::System.Collections.Generic.IList<RepositoryRulesetBypassActor>? BypassActors { get; set; }

        /// <summary>
        /// Parameters for a repository ruleset ref name condition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public RepositoryRulesetConditions? Conditions { get; set; }

        /// <summary>
        /// An array of rules within the ruleset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<RepositoryRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}