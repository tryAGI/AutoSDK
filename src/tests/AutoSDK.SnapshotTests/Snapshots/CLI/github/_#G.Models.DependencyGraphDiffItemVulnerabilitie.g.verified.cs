//HintName: G.Models.DependencyGraphDiffItemVulnerabilitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphDiffItemVulnerabilitie
    {
        /// <summary>
        /// Example: critical
        /// </summary>
        /// <example>critical</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Severity { get; set; }

        /// <summary>
        /// Example: GHSA-rf4j-j272-fj86
        /// </summary>
        /// <example>GHSA-rf4j-j272-fj86</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_ghsa_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdvisoryGhsaId { get; set; }

        /// <summary>
        /// Example: A summary of the advisory.
        /// </summary>
        /// <example>A summary of the advisory.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdvisorySummary { get; set; }

        /// <summary>
        /// Example: https://github.com/advisories/GHSA-rf4j-j272-fj86
        /// </summary>
        /// <example>https://github.com/advisories/GHSA-rf4j-j272-fj86</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdvisoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphDiffItemVulnerabilitie" /> class.
        /// </summary>
        /// <param name="severity">
        /// Example: critical
        /// </param>
        /// <param name="advisoryGhsaId">
        /// Example: GHSA-rf4j-j272-fj86
        /// </param>
        /// <param name="advisorySummary">
        /// Example: A summary of the advisory.
        /// </param>
        /// <param name="advisoryUrl">
        /// Example: https://github.com/advisories/GHSA-rf4j-j272-fj86
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependencyGraphDiffItemVulnerabilitie(
            string severity,
            string advisoryGhsaId,
            string advisorySummary,
            string advisoryUrl)
        {
            this.Severity = severity ?? throw new global::System.ArgumentNullException(nameof(severity));
            this.AdvisoryGhsaId = advisoryGhsaId ?? throw new global::System.ArgumentNullException(nameof(advisoryGhsaId));
            this.AdvisorySummary = advisorySummary ?? throw new global::System.ArgumentNullException(nameof(advisorySummary));
            this.AdvisoryUrl = advisoryUrl ?? throw new global::System.ArgumentNullException(nameof(advisoryUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphDiffItemVulnerabilitie" /> class.
        /// </summary>
        public DependencyGraphDiffItemVulnerabilitie()
        {
        }
    }
}