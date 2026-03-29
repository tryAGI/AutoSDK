//HintName: G.Models.WebhookListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhooks")]
        public global::System.Collections.Generic.IList<global::G.WebhookResponse>? Webhooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextOffset")]
        public int? NextOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListResponse" /> class.
        /// </summary>
        /// <param name="webhooks"></param>
        /// <param name="nextOffset"></param>
        public WebhookListResponse(
            global::System.Collections.Generic.IList<global::G.WebhookResponse>? webhooks,
            int? nextOffset)
        {
            this.Webhooks = webhooks;
            this.NextOffset = nextOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListResponse" /> class.
        /// </summary>
        public WebhookListResponse()
        {
        }
    }
}