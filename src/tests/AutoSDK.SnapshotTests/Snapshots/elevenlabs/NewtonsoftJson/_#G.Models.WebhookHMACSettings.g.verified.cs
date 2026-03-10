//HintName: G.Models.WebhookHMACSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings for creating an HMAC-authenticated webhook
    /// </summary>
    public sealed partial class WebhookHMACSettings
    {
        /// <summary>
        /// The authentication type for this webhook
        /// </summary>
        /// <default>"hmac"</default>
        [global::Newtonsoft.Json.JsonProperty("auth_type")]
        public string AuthType { get; set; } = "hmac";

        /// <summary>
        /// The display name for this webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The HTTPS callback URL that will be called when this webhook is triggered
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebhookUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookHMACSettings" /> class.
        /// </summary>
        /// <param name="authType">
        /// The authentication type for this webhook
        /// </param>
        /// <param name="name">
        /// The display name for this webhook
        /// </param>
        /// <param name="webhookUrl">
        /// The HTTPS callback URL that will be called when this webhook is triggered
        /// </param>
        public WebhookHMACSettings(
            string name,
            string webhookUrl,
            string authType = "hmac")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.AuthType = authType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookHMACSettings" /> class.
        /// </summary>
        public WebhookHMACSettings()
        {
        }
    }
}