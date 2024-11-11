//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for dismissing or closing the alert. Can be one of: `false positive`, `won't fix`, and `used in tests`.
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertReopenedByUserAlertDismissedReason
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlertDismissedReason" /> class.
        /// </summary>
        public WebhookCodeScanningAlertReopenedByUserAlertDismissedReason(
 )
        {
        }
    }
}