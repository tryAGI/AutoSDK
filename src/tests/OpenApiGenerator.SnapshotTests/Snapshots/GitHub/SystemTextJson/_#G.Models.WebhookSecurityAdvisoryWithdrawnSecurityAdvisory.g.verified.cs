//HintName: G.Models.WebhookSecurityAdvisoryWithdrawnSecurityAdvisory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details of the security advisory, including summary, description, and severity.
    /// </summary>
    public sealed partial class WebhookSecurityAdvisoryWithdrawnSecurityAdvisory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCvss Cvss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCwe> Cwes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ghsa_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GhsaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryIdentifier> Identifiers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryReference> References { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitie> Vulnerabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawn_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WithdrawnAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}