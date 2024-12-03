//HintName: G.Models.ReposGetAllDeploymentProtectionRulesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposGetAllDeploymentProtectionRulesResponse
    {
        /// <summary>
        /// The number of enabled custom deployment protection rules for this environment<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_deployment_protection_rules")]
        public global::System.Collections.Generic.IList<global::G.DeploymentProtectionRule>? CustomDeploymentProtectionRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposGetAllDeploymentProtectionRulesResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The number of enabled custom deployment protection rules for this environment<br/>
        /// Example: 10
        /// </param>
        /// <param name="customDeploymentProtectionRules"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposGetAllDeploymentProtectionRulesResponse(
            int? totalCount,
            global::System.Collections.Generic.IList<global::G.DeploymentProtectionRule>? customDeploymentProtectionRules)
        {
            this.TotalCount = totalCount;
            this.CustomDeploymentProtectionRules = customDeploymentProtectionRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposGetAllDeploymentProtectionRulesResponse" /> class.
        /// </summary>
        public ReposGetAllDeploymentProtectionRulesResponse()
        {
        }
    }
}