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
        /// The unique identifier for the deployment protection rule.<br/>
        /// Example: 3515
        /// </summary>
        /// <example>3515</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The node ID for the deployment protection rule.<br/>
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </summary>
        /// <example>MDQ6R2F0ZTM1MTU=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Whether the deployment protection rule is enabled for the environment.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// A GitHub App that is providing a custom deployment protection rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomDeploymentRuleApp App { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentProtectionRule" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the deployment protection rule.<br/>
        /// Example: 3515
        /// </param>
        /// <param name="nodeId">
        /// The node ID for the deployment protection rule.<br/>
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </param>
        /// <param name="enabled">
        /// Whether the deployment protection rule is enabled for the environment.<br/>
        /// Example: true
        /// </param>
        /// <param name="app">
        /// A GitHub App that is providing a custom deployment protection rule.
        /// </param>
        public DeploymentProtectionRule(
            int id,
            string nodeId,
            bool enabled,
            global::G.CustomDeploymentRuleApp app)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Enabled = enabled;
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentProtectionRule" /> class.
        /// </summary>
        public DeploymentProtectionRule()
        {
        }
    }
}