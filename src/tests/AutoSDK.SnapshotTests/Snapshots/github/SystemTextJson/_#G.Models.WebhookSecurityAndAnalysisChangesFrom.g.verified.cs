//HintName: G.Models.WebhookSecurityAndAnalysisChangesFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSecurityAndAnalysisChangesFrom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_and_analysis")]
        public global::G.SecurityAndAnalysis? SecurityAndAnalysis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAndAnalysisChangesFrom" /> class.
        /// </summary>
        /// <param name="securityAndAnalysis"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSecurityAndAnalysisChangesFrom(
            global::G.SecurityAndAnalysis? securityAndAnalysis)
        {
            this.SecurityAndAnalysis = securityAndAnalysis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAndAnalysisChangesFrom" /> class.
        /// </summary>
        public WebhookSecurityAndAnalysisChangesFrom()
        {
        }
    }
}