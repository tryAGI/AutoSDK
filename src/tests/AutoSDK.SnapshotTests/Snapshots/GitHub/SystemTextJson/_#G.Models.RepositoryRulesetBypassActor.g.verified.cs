//HintName: G.Models.RepositoryRulesetBypassActor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An actor that can bypass rules in a ruleset
    /// </summary>
    public sealed partial class RepositoryRulesetBypassActor
    {
        /// <summary>
        /// The ID of the actor that can bypass a ruleset. If `actor_type` is `OrganizationAdmin`, this should be `1`. If `actor_type` is `DeployKey`, this should be null. `OrganizationAdmin` is not applicable for personal repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_id")]
        public int? ActorId { get; set; }

        /// <summary>
        /// The type of actor that can bypass a ruleset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRulesetBypassActorActorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRulesetBypassActorActorType ActorType { get; set; }

        /// <summary>
        /// When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type. Also, `pull_request` is only applicable to branch rulesets.<br/>
        /// Default Value: always
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRulesetBypassActorBypassModeJsonConverter))]
        public global::G.RepositoryRulesetBypassActorBypassMode? BypassMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetBypassActor" /> class.
        /// </summary>
        /// <param name="actorId">
        /// The ID of the actor that can bypass a ruleset. If `actor_type` is `OrganizationAdmin`, this should be `1`. If `actor_type` is `DeployKey`, this should be null. `OrganizationAdmin` is not applicable for personal repositories.
        /// </param>
        /// <param name="actorType">
        /// The type of actor that can bypass a ruleset.
        /// </param>
        /// <param name="bypassMode">
        /// When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type. Also, `pull_request` is only applicable to branch rulesets.<br/>
        /// Default Value: always
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRulesetBypassActor(
            global::G.RepositoryRulesetBypassActorActorType actorType,
            int? actorId,
            global::G.RepositoryRulesetBypassActorBypassMode? bypassMode)
        {
            this.ActorType = actorType;
            this.ActorId = actorId;
            this.BypassMode = bypassMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetBypassActor" /> class.
        /// </summary>
        public RepositoryRulesetBypassActor()
        {
        }
    }
}