//HintName: G.Models.WebhookCodeScanningAlertCreatedAlertRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertCreatedAlertRule
    {
        /// <summary>
        /// A short description of the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_description")]
        public string? FullDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("help")]
        public string? Help { get; set; }

        /// <summary>
        /// A link to the documentation for the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("help_uri")]
        public string? HelpUri { get; set; }

        /// <summary>
        /// A unique identifier for the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The severity of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCodeScanningAlertCreatedAlertRuleSeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCodeScanningAlertCreatedAlertRuleSeverity? Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertCreatedAlertRule" /> class.
        /// </summary>
        /// <param name="description">
        /// A short description of the rule used to detect the alert.
        /// </param>
        /// <param name="fullDescription"></param>
        /// <param name="help"></param>
        /// <param name="helpUri">
        /// A link to the documentation for the rule used to detect the alert.
        /// </param>
        /// <param name="id">
        /// A unique identifier for the rule used to detect the alert.
        /// </param>
        /// <param name="name"></param>
        /// <param name="severity">
        /// The severity of the alert.
        /// </param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCodeScanningAlertCreatedAlertRule(
            string description,
            string id,
            global::G.WebhookCodeScanningAlertCreatedAlertRuleSeverity? severity,
            string? fullDescription,
            string? help,
            string? helpUri,
            string? name,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Severity = severity;
            this.FullDescription = fullDescription;
            this.Help = help;
            this.HelpUri = helpUri;
            this.Name = name;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertCreatedAlertRule" /> class.
        /// </summary>
        public WebhookCodeScanningAlertCreatedAlertRule()
        {
        }
    }
}