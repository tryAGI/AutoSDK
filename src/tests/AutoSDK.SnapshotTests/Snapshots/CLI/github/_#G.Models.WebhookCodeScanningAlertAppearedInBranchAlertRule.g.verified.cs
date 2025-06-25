﻿//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAlertRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertAppearedInBranchAlertRule
    {
        /// <summary>
        /// A short description of the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// A unique identifier for the rule used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The severity of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertAppearedInBranchAlertRule" /> class.
        /// </summary>
        /// <param name="description">
        /// A short description of the rule used to detect the alert.
        /// </param>
        /// <param name="id">
        /// A unique identifier for the rule used to detect the alert.
        /// </param>
        /// <param name="severity">
        /// The severity of the alert.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCodeScanningAlertAppearedInBranchAlertRule(
            string description,
            string id,
            global::G.WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity? severity)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertAppearedInBranchAlertRule" /> class.
        /// </summary>
        public WebhookCodeScanningAlertAppearedInBranchAlertRule()
        {
        }
    }
}