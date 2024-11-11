//HintName: G.Models.OrgsUpdateWebhookRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Key/value pairs to provide settings for this webhook.
    /// </summary>
    public sealed partial class OrgsUpdateWebhookRequestConfig
    {
        /// <summary>
        /// The URL to which the payloads will be delivered.<br/>
        /// Example: https://example.com/webhook
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The media type used to serialize the payloads. Supported values include `json` and `form`. The default is `form`.<br/>
        /// Example: "json"
        /// </summary>
        /// <example>"json"</example>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// If provided, the `secret` will be used as the `key` to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/webhooks/event-payloads/#delivery-headers).<br/>
        /// Example: "********"
        /// </summary>
        /// <example>"********"</example>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insecure_ssl")]
        public global::G.WebhookConfigInsecureSsl? InsecureSsl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdateWebhookRequestConfig" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to which the payloads will be delivered.<br/>
        /// Example: https://example.com/webhook
        /// </param>
        /// <param name="contentType">
        /// The media type used to serialize the payloads. Supported values include `json` and `form`. The default is `form`.<br/>
        /// Example: "json"
        /// </param>
        /// <param name="secret">
        /// If provided, the `secret` will be used as the `key` to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/webhooks/event-payloads/#delivery-headers).<br/>
        /// Example: "********"
        /// </param>
        /// <param name="insecureSsl"></param>
        public OrgsUpdateWebhookRequestConfig(
            string url,
            string? contentType,
            string? secret,
            global::G.WebhookConfigInsecureSsl? insecureSsl)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ContentType = contentType;
            this.Secret = secret;
            this.InsecureSsl = insecureSsl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdateWebhookRequestConfig" /> class.
        /// </summary>
        public OrgsUpdateWebhookRequestConfig()
        {
        }
    }
}