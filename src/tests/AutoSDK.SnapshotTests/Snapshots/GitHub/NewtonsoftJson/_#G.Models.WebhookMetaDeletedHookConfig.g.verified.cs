//HintName: G.Models.WebhookMetaDeletedHookConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMetaDeletedHookConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookMetaDeletedHookConfigContentType ContentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insecure_ssl", Required = global::Newtonsoft.Json.Required.Always)]
        public string InsecureSsl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMetaDeletedHookConfig" /> class.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="insecureSsl"></param>
        /// <param name="secret"></param>
        /// <param name="url"></param>
        public WebhookMetaDeletedHookConfig(
            global::G.WebhookMetaDeletedHookConfigContentType contentType,
            string insecureSsl,
            string url,
            string? secret)
        {
            this.ContentType = contentType;
            this.InsecureSsl = insecureSsl ?? throw new global::System.ArgumentNullException(nameof(insecureSsl));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMetaDeletedHookConfig" /> class.
        /// </summary>
        public WebhookMetaDeletedHookConfig()
        {
        }
    }
}