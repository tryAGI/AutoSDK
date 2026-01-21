//HintName: G.Models.ConversationInitiationClientDataWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"request_headers":{"Content-Type":"application/json"},"url":"https://example.com/webhook"}
    /// </summary>
    public sealed partial class ConversationInitiationClientDataWebhook
    {
        /// <summary>
        /// The URL to send the webhook to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The headers to send with the webhook request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object RequestHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataWebhook" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to send the webhook to
        /// </param>
        /// <param name="requestHeaders">
        /// The headers to send with the webhook request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationInitiationClientDataWebhook(
            string url,
            object requestHeaders)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.RequestHeaders = requestHeaders ?? throw new global::System.ArgumentNullException(nameof(requestHeaders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataWebhook" /> class.
        /// </summary>
        public ConversationInitiationClientDataWebhook()
        {
        }
    }
}