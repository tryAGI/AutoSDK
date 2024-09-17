//HintName: G.Models.ReposCreateDeploymentProtectionRuleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateDeploymentProtectionRuleRequest
    {
        /// <summary>
        /// The ID of the custom app that will be enabled on the environment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_id")]
        public int? IntegrationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}