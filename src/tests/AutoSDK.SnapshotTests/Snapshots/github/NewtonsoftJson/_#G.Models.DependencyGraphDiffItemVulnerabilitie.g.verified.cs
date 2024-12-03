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
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Severity { get; set; } = default!;

        /// <summary>
        /// Example: GHSA-rf4j-j272-fj86
        /// </summary>
        /// <example>GHSA-rf4j-j272-fj86</example>
        [global::Newtonsoft.Json.JsonProperty("advisory_ghsa_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AdvisoryGhsaId { get; set; } = default!;

        /// <summary>
        /// Example: A summary of the advisory.
        /// </summary>
        /// <example>A summary of the advisory.</example>
        [global::Newtonsoft.Json.JsonProperty("advisory_summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string AdvisorySummary { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/advisories/GHSA-rf4j-j272-fj86
        /// </summary>
        /// <example>https://github.com/advisories/GHSA-rf4j-j272-fj86</example>
        [global::Newtonsoft.Json.JsonProperty("advisory_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AdvisoryUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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