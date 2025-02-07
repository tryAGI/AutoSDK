//HintName: G.Models.ReposListCustomDeploymentRuleIntegrationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposListCustomDeploymentRuleIntegrationsResponse
    {
        /// <summary>
        /// The total number of custom deployment protection rule integrations available for this environment.<br/>
        /// Example: 35
        /// </summary>
        /// <example>35</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_custom_deployment_protection_rule_integrations")]
        public global::System.Collections.Generic.IList<global::G.CustomDeploymentRuleApp>? AvailableCustomDeploymentProtectionRuleIntegrations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListCustomDeploymentRuleIntegrationsResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The total number of custom deployment protection rule integrations available for this environment.<br/>
        /// Example: 35
        /// </param>
        /// <param name="availableCustomDeploymentProtectionRuleIntegrations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposListCustomDeploymentRuleIntegrationsResponse(
            int? totalCount,
            global::System.Collections.Generic.IList<global::G.CustomDeploymentRuleApp>? availableCustomDeploymentProtectionRuleIntegrations)
        {
            this.TotalCount = totalCount;
            this.AvailableCustomDeploymentProtectionRuleIntegrations = availableCustomDeploymentProtectionRuleIntegrations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListCustomDeploymentRuleIntegrationsResponse" /> class.
        /// </summary>
        public ReposListCustomDeploymentRuleIntegrationsResponse()
        {
        }
    }
}