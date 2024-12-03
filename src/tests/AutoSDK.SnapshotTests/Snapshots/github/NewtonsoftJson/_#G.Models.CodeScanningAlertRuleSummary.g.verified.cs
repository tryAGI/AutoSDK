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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The severity of the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity")]
        public global::G.CodeScanningAlertRuleSummarySeverity? Severity { get; set; }

        /// <summary>
        /// The security severity of the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_severity_level")]
        public global::G.CodeScanningAlertRuleSummarySecuritySeverityLevel? SecuritySeverityLevel { get; set; }

        /// <summary>
        /// A short description of the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A description of the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_description")]
        public string? FullDescription { get; set; }

        /// <summary>
        /// A set of tags applicable for the rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Detailed documentation for the rule as GitHub Flavored Markdown.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("help")]
        public string? Help { get; set; }

        /// <summary>
        /// A link to the documentation for the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("help_uri")]
        public string? HelpUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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