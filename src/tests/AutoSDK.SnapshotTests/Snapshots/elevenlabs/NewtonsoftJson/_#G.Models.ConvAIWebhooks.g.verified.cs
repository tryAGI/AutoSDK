//HintName: G.Models.ConvAIWebhooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvAIWebhooks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_call_webhook_id")]
        public string? PostCallWebhookId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWebhooks" /> class.
        /// </summary>
        /// <param name="postCallWebhookId"></param>
        public ConvAIWebhooks(
            string? postCallWebhookId)
        {
            this.PostCallWebhookId = postCallWebhookId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWebhooks" /> class.
        /// </summary>
        public ConvAIWebhooks()
        {
        }
    }
}