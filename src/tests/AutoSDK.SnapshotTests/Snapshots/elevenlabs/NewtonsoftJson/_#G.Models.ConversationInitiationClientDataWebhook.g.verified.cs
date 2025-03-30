//HintName: G.Models.ConversationInitiationClientDataWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationInitiationClientDataWebhook
    {
        /// <summary>
        /// The URL to send the webhook to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The headers to send with the webhook request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_headers", Required = global::Newtonsoft.Json.Required.Always)]
        public object RequestHeaders { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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