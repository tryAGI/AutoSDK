//HintName: G.Models.RepositoryRuleset.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The target of the ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRulesetTargetJsonConverter))]
        public global::G.RepositoryRulesetTarget? Target { get; set; }

        /// <summary>
        /// The type of the source of the ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRulesetSourceTypeJsonConverter))]
        public global::G.RepositoryRulesetSourceType? SourceType { get; set; }

        /// <summary>
        /// The name of the source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleEnforcementJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleEnforcement Enforcement { get; set; }

        /// <summary>
        /// The actors that can bypass the rules in this ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass_actors")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRulesetBypassActor>? BypassActors { get; set; }

        /// <summary>
        /// The bypass type of the user making the API request for this ruleset. This field is only returned when<br/>
        /// querying the repository-level endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_can_bypass")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRulesetCurrentUserCanBypassJsonConverter))]
        public global::G.RepositoryRulesetCurrentUserCanBypass? CurrentUserCanBypass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        public global::G.RepositoryRulesetLinks? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.RepositoryRulesetConditions, global::G.OrgRulesetConditions?>))]
        public global::G.AnyOf<global::G.RepositoryRulesetConditions, global::G.OrgRulesetConditions?>? Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRule>? Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleset" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the ruleset
        /// </param>
        /// <param name="name">
        /// The name of the ruleset
        /// </param>
        /// <param name="target">
        /// The target of the ruleset
        /// </param>
        /// <param name="sourceType">
        /// The type of the source of the ruleset
        /// </param>
        /// <param name="source">
        /// The name of the source
        /// </param>
        /// <param name="enforcement">
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </param>
        /// <param name="bypassActors">
        /// The actors that can bypass the rules in this ruleset
        /// </param>
        /// <param name="currentUserCanBypass">
        /// The bypass type of the user making the API request for this ruleset. This field is only returned when<br/>
        /// querying the repository-level endpoint.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="links"></param>
        /// <param name="conditions"></param>
        /// <param name="rules"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleset(
            int id,
            string name,
            string source,
            global::G.RepositoryRuleEnforcement enforcement,
            global::G.RepositoryRulesetTarget? target,
            global::G.RepositoryRulesetSourceType? sourceType,
            global::System.Collections.Generic.IList<global::G.RepositoryRulesetBypassActor>? bypassActors,
            global::G.RepositoryRulesetCurrentUserCanBypass? currentUserCanBypass,
            string? nodeId,
            global::G.RepositoryRulesetLinks? links,
            global::G.AnyOf<global::G.RepositoryRulesetConditions, global::G.OrgRulesetConditions?>? conditions,
            global::System.Collections.Generic.IList<global::G.RepositoryRule>? rules,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Enforcement = enforcement;
            this.Target = target;
            this.SourceType = sourceType;
            this.BypassActors = bypassActors;
            this.CurrentUserCanBypass = currentUserCanBypass;
            this.NodeId = nodeId;
            this.Links = links;
            this.Conditions = conditions;
            this.Rules = rules;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleset" /> class.
        /// </summary>
        public RepositoryRuleset()
        {
        }
    }
}