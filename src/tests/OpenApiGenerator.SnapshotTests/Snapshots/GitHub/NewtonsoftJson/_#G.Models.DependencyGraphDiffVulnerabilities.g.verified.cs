//HintName: G.Models.DependencyGraphDiffVulnerabilities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphDiffVulnerabilities
    {
        /// <summary>
        /// Example: critical
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Severity { get; set; } = default!;

        /// <summary>
        /// Example: GHSA-rf4j-j272-fj86
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advisory_ghsa_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AdvisoryGhsaId { get; set; } = default!;

        /// <summary>
        /// Example: A summary of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advisory_summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string AdvisorySummary { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/advisories/GHSA-rf4j-j272-fj86
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advisory_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AdvisoryUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}