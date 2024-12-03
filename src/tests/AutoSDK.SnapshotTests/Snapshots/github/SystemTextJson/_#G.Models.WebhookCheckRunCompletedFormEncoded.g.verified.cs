//HintName: G.Models.WebhookCheckRunCompletedFormEncoded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The check_run.completed webhook encoded with URL encoding
    /// </summary>
    public sealed partial class WebhookCheckRunCompletedFormEncoded
    {
        /// <summary>
        /// A URL-encoded string of the check_run.completed JSON payload. The decoded payload is a JSON object.
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
        /// Initializes a new instance of the <see cref="WebhookCheckRunCompletedFormEncoded" /> class.
        /// </summary>
        /// <param name="payload">
        /// A URL-encoded string of the check_run.completed JSON payload. The decoded payload is a JSON object.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookCheckRunCompletedFormEncoded(
            string payload)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckRunCompletedFormEncoded" /> class.
        /// </summary>
        public WebhookCheckRunCompletedFormEncoded()
        {
        }
    }
}