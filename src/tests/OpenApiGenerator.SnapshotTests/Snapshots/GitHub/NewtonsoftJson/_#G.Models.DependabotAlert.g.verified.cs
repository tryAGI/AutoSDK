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
        /// The security alert number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// The state of the Dependabot alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependabotAlertState State { get; set; } = default!;

        /// <summary>
        /// Details for the vulnerable dependency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependabotAlertDependency Dependency { get; set; } = default!;

        /// <summary>
        /// Details for the GitHub Security Advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_advisory", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependabotAlertSecurityAdvisory? SecurityAdvisory { get; set; } = default!;

        /// <summary>
        /// Details pertaining to one vulnerable version range for the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_vulnerability", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependabotAlertSecurityVulnerability? SecurityVulnerability { get; set; } = default!;

        /// <summary>
        /// The REST API URL of the alert resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Url { get; set; } = default!;

        /// <summary>
        /// The GitHub URL of the alert resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? DismissedAt { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? DismissedBy { get; set; } = default!;

        /// <summary>
        /// The reason that the alert was dismissed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependabotAlertDismissedReason? DismissedReason { get; set; } = default!;

        /// <summary>
        /// An optional comment associated with the alert's dismissal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_comment", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DismissedComment { get; set; } = default!;

        /// <summary>
        /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fixed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? FixedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was auto-dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_dismissed_at")]
        public global::System.DateTime? AutoDismissedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}