//HintName: G.Models.WebhookProjectsV2ItemReorderedChangesPreviousProjectsV2ItemNodeId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ItemReorderedChangesPreviousProjectsV2ItemNodeId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public string? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemReorderedChangesPreviousProjectsV2ItemNodeId" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public WebhookProjectsV2ItemReorderedChangesPreviousProjectsV2ItemNodeId(
            string? from,
            string? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemReorderedChangesPreviousProjectsV2ItemNodeId" /> class.
        /// </summary>
        public WebhookProjectsV2ItemReorderedChangesPreviousProjectsV2ItemNodeId()
        {
        }
    }
}