//HintName: G.Models.WebhookSecretScanningAlertLocationCreatedFormEncoded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSecretScanningAlertLocationCreatedFormEncoded
    {
        /// <summary>
        /// A URL-encoded string of the secret_scanning_alert_location.created JSON payload. The decoded payload is a JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecretScanningAlertLocationCreatedFormEncoded" /> class.
        /// </summary>
        /// <param name="payload">
        /// A URL-encoded string of the secret_scanning_alert_location.created JSON payload. The decoded payload is a JSON object.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookSecretScanningAlertLocationCreatedFormEncoded(
            string payload)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecretScanningAlertLocationCreatedFormEncoded" /> class.
        /// </summary>
        public WebhookSecretScanningAlertLocationCreatedFormEncoded()
        {
        }
    }
}