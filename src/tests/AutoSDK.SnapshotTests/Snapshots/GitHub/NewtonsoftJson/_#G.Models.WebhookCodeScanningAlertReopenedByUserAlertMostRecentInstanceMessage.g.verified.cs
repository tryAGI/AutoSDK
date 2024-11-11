//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceMessage" /> class.
        /// </summary>
        /// <param name="text"></param>
        public WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceMessage(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceMessage" /> class.
        /// </summary>
        public WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceMessage()
        {
        }
    }
}