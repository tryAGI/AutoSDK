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
        /// The security alert number.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("number")]
        public int Number { get; set; } = default!;

        /// <summary>
        /// The state of the Dependabot alert.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.DependabotAlertWithRepositoryState State { get; set; } = default!;

        /// <summary>
        /// Details for the vulnerable dependency.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("dependency")]
        public global::G.DependabotAlertWithRepositoryDependency Dependency { get; set; } = default!;

        /// <summary>
        /// Details for the GitHub Security Advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("security_advisory")]
        public global::G.DependabotAlertSecurityAdvisory SecurityAdvisory { get; set; } = default!;

        /// <summary>
        /// Details pertaining to one vulnerable version range for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("security_vulnerability")]
        public global::G.DependabotAlertSecurityVulnerability SecurityVulnerability { get; set; } = default!;

        /// <summary>
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_at")]
        public global::System.DateTime? DismissedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? DismissedBy { get; set; } = default!;

        /// <summary>
        /// The reason that the alert was dismissed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependabotAlertWithRepositoryDismissedReason? DismissedReason { get; set; } = default!;

        /// <summary>
        /// An optional comment associated with the alert's dismissal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_comment", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DismissedComment { get; set; } = default!;

        /// <summary>
        /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fixed_at")]
        public global::System.DateTime? FixedAt { get; set; }

        /// <summary>
        /// The time that the alert was auto-dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_dismissed_at")]
        public global::System.DateTime? AutoDismissedAt { get; set; }

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleRepository Repository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertWithRepository" /> class.
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
        /// <param name="repository">
        /// A GitHub repository.
        /// </param>
        public DependabotAlertWithRepository(
            global::G.NullableSimpleUser? dismissedBy,
            global::G.DependabotAlertWithRepositoryDismissedReason? dismissedReason,
            string? dismissedComment,
            global::G.SimpleRepository repository,
            global::System.DateTime? dismissedAt,
            global::System.DateTime? fixedAt,
            global::System.DateTime? autoDismissedAt,
            int number = default!,
            global::G.DependabotAlertWithRepositoryState state = default!,
            global::G.DependabotAlertWithRepositoryDependency dependency = default!,
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
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
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
        /// Initializes a new instance of the <see cref="DependabotAlertWithRepository" /> class.
        /// </summary>
        public DependabotAlertWithRepository()
        {
        }
    }
}