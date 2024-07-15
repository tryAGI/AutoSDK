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
        [global::Newtonsoft.Json.JsonProperty("actor_id")]
        public int? ActorId { get; set; }

        /// <summary>
        /// The type of actor that can bypass a ruleset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRulesetBypassActorActorType ActorType { get; set; } = default!;

        /// <summary>
        /// When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bypass_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRulesetBypassActorBypassMode BypassMode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}