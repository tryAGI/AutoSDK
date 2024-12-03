//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The code scanning alert involved in the event.
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertReopenedByUserAlert
    {
        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ.`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? DismissedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? DismissedBy { get; set; }

        /// <summary>
        /// The reason for dismissing or closing the alert. Can be one of: `false positive`, `won't fix`, and `used in tests`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? DismissedReason { get; set; }

        /// <summary>
        /// The GitHub URL of the alert resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_instance")]
        public global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance? MostRecentInstance { get; set; }

        /// <summary>
        /// The code scanning alert number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCodeScanningAlertReopenedByUserAlertRule Rule { get; set; }

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCodeScanningAlertReopenedByUserAlertStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCodeScanningAlertReopenedByUserAlertState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCodeScanningAlertReopenedByUserAlertTool Tool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlert" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ.`
        /// </param>
        /// <param name="dismissedAt">
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="dismissedBy"></param>
        /// <param name="dismissedReason">
        /// The reason for dismissing or closing the alert. Can be one of: `false positive`, `won't fix`, and `used in tests`.
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL of the alert resource.
        /// </param>
        /// <param name="mostRecentInstance"></param>
        /// <param name="number">
        /// The code scanning alert number.
        /// </param>
        /// <param name="rule"></param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
        /// <param name="tool"></param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookCodeScanningAlertReopenedByUserAlert(
            global::System.DateTime createdAt,
            object? dismissedAt,
            object? dismissedBy,
            object? dismissedReason,
            string htmlUrl,
            int number,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertRule rule,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertState state,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertTool tool,
            string url,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance? mostRecentInstance)
        {
            this.CreatedAt = createdAt;
            this.DismissedAt = dismissedAt ?? throw new global::System.ArgumentNullException(nameof(dismissedAt));
            this.DismissedBy = dismissedBy ?? throw new global::System.ArgumentNullException(nameof(dismissedBy));
            this.DismissedReason = dismissedReason ?? throw new global::System.ArgumentNullException(nameof(dismissedReason));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Number = number;
            this.Rule = rule ?? throw new global::System.ArgumentNullException(nameof(rule));
            this.State = state;
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.MostRecentInstance = mostRecentInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlert" /> class.
        /// </summary>
        public WebhookCodeScanningAlertReopenedByUserAlert()
        {
        }
    }
}