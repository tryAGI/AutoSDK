//HintName: G.Models.DeploymentProtectionRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deployment protection rule
    /// </summary>
    public sealed partial class DeploymentProtectionRule
    {
        /// <summary>
        /// The unique identifier for the deployment protection rule.
        /// <br/>Example: 3515
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The node ID for the deployment protection rule.
        /// <br/>Example: MDQ6R2F0ZTM1MTU=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Whether the deployment protection rule is enabled for the environment.
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// A GitHub App that is providing a custom deployment protection rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public CustomDeploymentRuleApp App { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}