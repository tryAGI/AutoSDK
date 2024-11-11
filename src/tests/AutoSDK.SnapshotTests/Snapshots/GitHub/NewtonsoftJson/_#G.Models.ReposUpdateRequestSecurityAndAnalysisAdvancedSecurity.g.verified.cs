//HintName: G.Models.ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use the `status` property to enable or disable GitHub Advanced Security for this repository. For more information, see "[About GitHub Advanced Security](/github/getting-started-with-github/learning-about-github/about-github-advanced-security)."
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity
    {
        /// <summary>
        /// Can be `enabled` or `disabled`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity" /> class.
        /// </summary>
        /// <param name="status">
        /// Can be `enabled` or `disabled`.
        /// </param>
        public ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity(
            string? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity" /> class.
        /// </summary>
        public ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity()
        {
        }
    }
}