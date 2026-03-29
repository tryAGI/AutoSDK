//HintName: G.Models.GetWebhookSubscriptionsEventTypesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWebhookSubscriptionsEventTypesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetWebhookSubscriptionsEventTypesResponseItem> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookSubscriptionsEventTypesResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        public GetWebhookSubscriptionsEventTypesResponse(
            global::System.Collections.Generic.IList<global::G.GetWebhookSubscriptionsEventTypesResponseItem> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookSubscriptionsEventTypesResponse" /> class.
        /// </summary>
        public GetWebhookSubscriptionsEventTypesResponse()
        {
        }
    }
}