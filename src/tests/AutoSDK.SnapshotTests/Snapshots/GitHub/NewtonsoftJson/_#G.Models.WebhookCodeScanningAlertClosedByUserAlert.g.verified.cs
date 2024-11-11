//HintName: G.Models.WebhookCodeScanningAlertClosedByUserAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The code scanning alert involved in the event.
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertClosedByUserAlert
    {
        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ.`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime DismissedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCodeScanningAlertClosedByUserAlertDismissedBy? DismissedBy { get; set; } = default!;

        /// <summary>
        /// The reason for dismissing or closing the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCodeScanningAlertClosedByUserAlertDismissedReason? DismissedReason { get; set; } = default!;

        /// <summary>
        /// The GitHub URL of the alert resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("most_recent_instance")]
        public global::G.WebhookCodeScanningAlertClosedByUserAlertMostRecentInstance? MostRecentInstance { get; set; }

        /// <summary>
        /// The code scanning alert number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCodeScanningAlertClosedByUserAlertRule Rule { get; set; } = default!;

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCodeScanningAlertClosedByUserAlertState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCodeScanningAlertClosedByUserAlertTool Tool { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertClosedByUserAlert" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ.`
        /// </param>
        /// <param name="dismissedAt">
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="dismissedBy"></param>
        /// <param name="dismissedReason">
        /// The reason for dismissing or closing the alert.
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
        public WebhookCodeScanningAlertClosedByUserAlert(
            global::System.DateTime createdAt,
            global::System.DateTime dismissedAt,
            global::G.WebhookCodeScanningAlertClosedByUserAlertDismissedBy? dismissedBy,
            global::G.WebhookCodeScanningAlertClosedByUserAlertDismissedReason? dismissedReason,
            string htmlUrl,
            int number,
            global::G.WebhookCodeScanningAlertClosedByUserAlertRule rule,
            global::G.WebhookCodeScanningAlertClosedByUserAlertState state,
            global::G.WebhookCodeScanningAlertClosedByUserAlertTool tool,
            string url,
            global::G.WebhookCodeScanningAlertClosedByUserAlertMostRecentInstance? mostRecentInstance)
        {
            this.CreatedAt = createdAt;
            this.DismissedAt = dismissedAt;
            this.DismissedBy = dismissedBy ?? throw new global::System.ArgumentNullException(nameof(dismissedBy));
            this.DismissedReason = dismissedReason;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Number = number;
            this.Rule = rule ?? throw new global::System.ArgumentNullException(nameof(rule));
            this.State = state;
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.MostRecentInstance = mostRecentInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertClosedByUserAlert" /> class.
        /// </summary>
        public WebhookCodeScanningAlertClosedByUserAlert()
        {
        }
    }
}