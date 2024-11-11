//HintName: G.Models.RepositoryRuleRequiredDeploymentsParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleRequiredDeploymentsParameters
    {
        /// <summary>
        /// The environments that must be successfully deployed to before branches can be merged.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_deployment_environments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RequiredDeploymentEnvironments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredDeploymentsParameters" /> class.
        /// </summary>
        /// <param name="requiredDeploymentEnvironments">
        /// The environments that must be successfully deployed to before branches can be merged.
        /// </param>
        public RepositoryRuleRequiredDeploymentsParameters(
            global::System.Collections.Generic.IList<string> requiredDeploymentEnvironments)
        {
            this.RequiredDeploymentEnvironments = requiredDeploymentEnvironments ?? throw new global::System.ArgumentNullException(nameof(requiredDeploymentEnvironments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredDeploymentsParameters" /> class.
        /// </summary>
        public RepositoryRuleRequiredDeploymentsParameters()
        {
        }
    }
}