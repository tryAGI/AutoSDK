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
        [global::System.Text.Json.Serialization.JsonPropertyName("required_deployment_environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequiredDeploymentEnvironments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredDeploymentsParameters" /> class.
        /// </summary>
        /// <param name="requiredDeploymentEnvironments">
        /// The environments that must be successfully deployed to before branches can be merged.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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