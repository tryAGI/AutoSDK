//HintName: G.Models.WebhookProjectsV2StatusUpdateEditedChangesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2StatusUpdateEditedChangesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public global::G.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public global::G.WebhookProjectsV2StatusUpdateEditedChangesStatusTo? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2StatusUpdateEditedChangesStatus" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public WebhookProjectsV2StatusUpdateEditedChangesStatus(
            global::G.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom? from,
            global::G.WebhookProjectsV2StatusUpdateEditedChangesStatusTo? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2StatusUpdateEditedChangesStatus" /> class.
        /// </summary>
        public WebhookProjectsV2StatusUpdateEditedChangesStatus()
        {
        }
    }
}