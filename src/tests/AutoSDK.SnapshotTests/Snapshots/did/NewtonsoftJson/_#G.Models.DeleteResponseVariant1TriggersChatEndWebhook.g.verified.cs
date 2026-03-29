//HintName: G.Models.DeleteResponseVariant1TriggersChatEndWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook configuration for immediate execution<br/>
    /// Note: HTTP method is controlled by the system, not user-configurable
    /// </summary>
    public sealed partial class DeleteResponseVariant1TriggersChatEndWebhook
    {
        /// <summary>
        /// Target URL for the webhook<br/>
        /// Example: https://example.com
        /// </summary>
        /// <example>https://example.com</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional headers to include
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Authentication configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth")]
        public global::G.DeleteResponseVariant1TriggersChatEndWebhookAuth? Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1TriggersChatEndWebhook" /> class.
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
        public DeleteResponseVariant1TriggersChatEndWebhook(
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::G.DeleteResponseVariant1TriggersChatEndWebhookAuth? auth)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1TriggersChatEndWebhook" /> class.
        /// </summary>
        public DeleteResponseVariant1TriggersChatEndWebhook()
        {
        }
    }
}