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
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_deployment_protection_rules")]
        public global::System.Collections.Generic.IList<global::G.DeploymentProtectionRule>? CustomDeploymentProtectionRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}