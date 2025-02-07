//HintName: G.Models.WebhookPingFormEncoded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The webhooks ping payload encoded with URL encoding.
    /// </summary>
    public sealed partial class WebhookPingFormEncoded
    {
        /// <summary>
        /// A URL-encoded string of the ping JSON payload. The decoded payload is a JSON object.
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
        /// Initializes a new instance of the <see cref="WebhookPingFormEncoded" /> class.
        /// </summary>
        /// <param name="payload">
        /// A URL-encoded string of the ping JSON payload. The decoded payload is a JSON object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPingFormEncoded(
            string payload)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPingFormEncoded" /> class.
        /// </summary>
        public WebhookPingFormEncoded()
        {
        }
    }
}