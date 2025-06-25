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
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_id")]
        public int? IntegrationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDeploymentProtectionRuleRequest" /> class.
        /// </summary>
        /// <param name="integrationId">
        /// The ID of the custom app that will be enabled on the environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposCreateDeploymentProtectionRuleRequest(
            int? integrationId)
        {
            this.IntegrationId = integrationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDeploymentProtectionRuleRequest" /> class.
        /// </summary>
        public ReposCreateDeploymentProtectionRuleRequest()
        {
        }
    }
}