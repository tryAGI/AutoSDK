//HintName: G.Models.DependabotAlertWithRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Dependabot alert.
    /// </summary>
    public sealed partial class DependabotAlertWithRepository
    {
        /// <summary>
        /// The security alert number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// The state of the Dependabot alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DependabotAlertWithRepositoryStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependabotAlertWithRepositoryState State { get; set; }

        /// <summary>
        /// Details for the vulnerable dependency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependabotAlertWithRepositoryDependency Dependency { get; set; }

        /// <summary>
        /// Details for the GitHub Security Advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_advisory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependabotAlertSecurityAdvisory SecurityAdvisory { get; set; }

        /// <summary>
        /// Details pertaining to one vulnerable version range for the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_vulnerability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependabotAlertSecurityVulnerability SecurityVulnerability { get; set; }

        /// <summary>
        /// The REST API URL of the alert resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The GitHub URL of the alert resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? DismissedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? DismissedBy { get; set; }

        /// <summary>
        /// The reason that the alert was dismissed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DependabotAlertWithRepositoryDismissedReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependabotAlertWithRepositoryDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// An optional comment associated with the alert's dismissal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DismissedComment { get; set; }

        /// <summary>
        /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? FixedAt { get; set; }

        /// <summary>
        /// The time that the alert was auto-dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_dismissed_at")]
        public global::System.DateTime? AutoDismissedAt { get; set; }

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleRepository Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}