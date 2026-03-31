//HintName: G.Models.CreateResponseVariant1TriggersChatEndWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook configuration for immediate execution<br/>
    /// Note: HTTP method is controlled by the system, not user-configurable
    /// </summary>
    public sealed partial class CreateResponseVariant1TriggersChatEndWebhook
    {
        /// <summary>
        /// Target URL for the webhook<br/>
        /// Example: https://example.com
        /// </summary>
        /// <example>https://example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional headers to include
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Authentication configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::G.CreateResponseVariant1TriggersChatEndWebhookAuth? Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant1TriggersChatEndWebhook" /> class.
        /// </summary>
        /// <param name="url">
        /// Target URL for the webhook<br/>
        /// Example: https://example.com
        /// </param>
        /// <param name="headers">
        /// Additional headers to include
        /// </param>
        /// <param name="auth">
        /// Authentication configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseVariant1TriggersChatEndWebhook(
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::G.CreateResponseVariant1TriggersChatEndWebhookAuth? auth)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant1TriggersChatEndWebhook" /> class.
        /// </summary>
        public CreateResponseVariant1TriggersChatEndWebhook()
        {
        }
    }
}