//HintName: G.Models.DependabotAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Dependabot alert.
    /// </summary>
    public sealed partial class DependabotAlert
    {
        /// <summary>
        /// The security alert number.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int Number { get; set; } = default!;

        /// <summary>
        /// The state of the Dependabot alert.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependabotAlertStateJsonConverter))]
        public global::G.DependabotAlertState State { get; set; } = default!;

        /// <summary>
        /// Details for the vulnerable dependency.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency")]
        public global::G.DependabotAlertDependency Dependency { get; set; } = default!;

        /// <summary>
        /// Details for the GitHub Security Advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_advisory")]
        public global::G.DependabotAlertSecurityAdvisory SecurityAdvisory { get; set; } = default!;

        /// <summary>
        /// Details pertaining to one vulnerable version range for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_vulnerability")]
        public global::G.DependabotAlertSecurityVulnerability SecurityVulnerability { get; set; } = default!;

        /// <summary>
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_at")]
        public global::System.DateTime? DismissedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependabotAlertDismissedReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependabotAlertDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// An optional comment associated with the alert's dismissal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DismissedComment { get; set; }

        /// <summary>
        /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed_at")]
        public global::System.DateTime? FixedAt { get; set; }

        /// <summary>
        /// The time that the alert was auto-dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_dismissed_at")]
        public global::System.DateTime? AutoDismissedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlert" /> class.
        /// </summary>
        /// <param name="number">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// The state of the Dependabot alert.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dependency">
        /// Details for the vulnerable dependency.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="securityAdvisory">
        /// Details for the GitHub Security Advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="securityVulnerability">
        /// Details pertaining to one vulnerable version range for the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dismissedAt">
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dismissedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="dismissedReason">
        /// The reason that the alert was dismissed.
        /// </param>
        /// <param name="dismissedComment">
        /// An optional comment associated with the alert's dismissal.
        /// </param>
        /// <param name="fixedAt">
        /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="autoDismissedAt">
        /// The time that the alert was auto-dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependabotAlert(
            global::G.NullableSimpleUser? dismissedBy,
            global::G.DependabotAlertDismissedReason? dismissedReason,
            string? dismissedComment,
            global::System.DateTime? dismissedAt,
            global::System.DateTime? fixedAt,
            global::System.DateTime? autoDismissedAt,
            int number = default!,
            global::G.DependabotAlertState state = default!,
            global::G.DependabotAlertDependency dependency = default!,
            global::G.DependabotAlertSecurityAdvisory securityAdvisory = default!,
            global::G.DependabotAlertSecurityVulnerability securityVulnerability = default!,
            string url = default!,
            string htmlUrl = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.DismissedBy = dismissedBy ?? throw new global::System.ArgumentNullException(nameof(dismissedBy));
            this.DismissedReason = dismissedReason;
            this.DismissedComment = dismissedComment ?? throw new global::System.ArgumentNullException(nameof(dismissedComment));
            this.Number = number;
            this.State = state;
            this.Dependency = dependency;
            this.SecurityAdvisory = securityAdvisory;
            this.SecurityVulnerability = securityVulnerability;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DismissedAt = dismissedAt;
            this.FixedAt = fixedAt;
            this.AutoDismissedAt = autoDismissedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlert" /> class.
        /// </summary>
        public DependabotAlert()
        {
        }
    }
}