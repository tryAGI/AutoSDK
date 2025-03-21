﻿//HintName: G.Models.WebhookCodeScanningAlertReopenedAlertRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertReopenedAlertRule
    {
        /// <summary>
        /// A short description of the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_description")]
        public string? FullDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("help")]
        public string? Help { get; set; }

        /// <summary>
        /// A link to the documentation for the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("help_uri")]
        public string? HelpUri { get; set; }

        /// <summary>
        /// A unique identifier for the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The severity of the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCodeScanningAlertReopenedAlertRuleSeverity? Severity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedAlertRule" /> class.
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
        public WebhookCodeScanningAlertReopenedAlertRule(
            string description,
            string id,
            global::G.WebhookCodeScanningAlertReopenedAlertRuleSeverity? severity,
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
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedAlertRule" /> class.
        /// </summary>
        public WebhookCodeScanningAlertReopenedAlertRule()
        {
        }
    }
}