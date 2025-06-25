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
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookMetaDeletedHookConfigContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookMetaDeletedHookConfigContentType ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insecure_ssl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InsecureSsl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMetaDeletedHookConfig" /> class.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="insecureSsl"></param>
        /// <param name="secret"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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