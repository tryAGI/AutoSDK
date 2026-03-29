//HintName: G.Models.TestWebhookConfigurationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook test configuration
    /// </summary>
    public sealed partial class TestWebhookConfigurationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public global::G.TestWebhookConfigurationRequestEventType EventType { get; set; }

        /// <summary>
        /// a valid url that starts with http or https with regex<br/>
        /// Example: https://example.com
        /// </summary>
        /// <example>https://example.com</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Authentication configuration for tools and webhooks (processed/stored)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth")]
        public global::G.TestWebhookConfigurationRequestAuth? Auth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestWebhookConfigurationRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// a valid url that starts with http or https with regex<br/>
        /// Example: https://example.com
        /// </param>
        /// <param name="eventType"></param>
        /// <param name="auth">
        /// Authentication configuration for tools and webhooks (processed/stored)
        /// </param>
        /// <param name="headers"></param>
        public TestWebhookConfigurationRequest(
            string url,
            global::G.TestWebhookConfigurationRequestEventType eventType,
            global::G.TestWebhookConfigurationRequestAuth? auth,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.EventType = eventType;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Auth = auth;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestWebhookConfigurationRequest" /> class.
        /// </summary>
        public TestWebhookConfigurationRequest()
        {
        }
    }
}