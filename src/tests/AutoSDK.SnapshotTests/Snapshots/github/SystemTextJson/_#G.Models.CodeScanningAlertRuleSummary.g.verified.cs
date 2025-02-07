//HintName: G.Models.CodeScanningAlertRuleSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningAlertRuleSummary
    {
        /// <summary>
        /// A unique identifier for the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The severity of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeScanningAlertRuleSummarySeverityJsonConverter))]
        public global::G.CodeScanningAlertRuleSummarySeverity? Severity { get; set; }

        /// <summary>
        /// The security severity of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_severity_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeScanningAlertRuleSummarySecuritySeverityLevelJsonConverter))]
        public global::G.CodeScanningAlertRuleSummarySecuritySeverityLevel? SecuritySeverityLevel { get; set; }

        /// <summary>
        /// A short description of the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A description of the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_description")]
        public string? FullDescription { get; set; }

        /// <summary>
        /// A set of tags applicable for the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Detailed documentation for the rule as GitHub Flavored Markdown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("help")]
        public string? Help { get; set; }

        /// <summary>
        /// A link to the documentation for the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("help_uri")]
        public string? HelpUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertRuleSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the rule used to detect the alert.
        /// </param>
        /// <param name="name">
        /// The name of the rule used to detect the alert.
        /// </param>
        /// <param name="severity">
        /// The severity of the alert.
        /// </param>
        /// <param name="securitySeverityLevel">
        /// The security severity of the alert.
        /// </param>
        /// <param name="description">
        /// A short description of the rule used to detect the alert.
        /// </param>
        /// <param name="fullDescription">
        /// A description of the rule used to detect the alert.
        /// </param>
        /// <param name="tags">
        /// A set of tags applicable for the rule.
        /// </param>
        /// <param name="help">
        /// Detailed documentation for the rule as GitHub Flavored Markdown.
        /// </param>
        /// <param name="helpUri">
        /// A link to the documentation for the rule used to detect the alert.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningAlertRuleSummary(
            string? id,
            string? name,
            global::G.CodeScanningAlertRuleSummarySeverity? severity,
            global::G.CodeScanningAlertRuleSummarySecuritySeverityLevel? securitySeverityLevel,
            string? description,
            string? fullDescription,
            global::System.Collections.Generic.IList<string>? tags,
            string? help,
            string? helpUri)
        {
            this.Id = id;
            this.Name = name;
            this.Severity = severity;
            this.SecuritySeverityLevel = securitySeverityLevel;
            this.Description = description;
            this.FullDescription = fullDescription;
            this.Tags = tags;
            this.Help = help;
            this.HelpUri = helpUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertRuleSummary" /> class.
        /// </summary>
        public CodeScanningAlertRuleSummary()
        {
        }
    }
}