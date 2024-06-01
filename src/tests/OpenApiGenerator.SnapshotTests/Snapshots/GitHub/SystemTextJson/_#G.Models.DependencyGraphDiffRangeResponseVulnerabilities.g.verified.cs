//HintName: G.Models.DependencyGraphDiffRangeResponseVulnerabilities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphDiffRangeResponseVulnerabilities
    {
        /// <summary>
        /// <br/>Example: critical
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Severity { get; set; }

        /// <summary>
        /// <br/>Example: GHSA-rf4j-j272-fj86
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_ghsa_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdvisoryGhsaId { get; set; }

        /// <summary>
        /// <br/>Example: A summary of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdvisorySummary { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/advisories/GHSA-rf4j-j272-fj86
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdvisoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}