//HintName: G.Models.WebhookProjectsV2StatusUpdateEditedChangesTargetDate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2StatusUpdateEditedChangesTargetDate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public global::System.DateTime? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public global::System.DateTime? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2StatusUpdateEditedChangesTargetDate" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public WebhookProjectsV2StatusUpdateEditedChangesTargetDate(
            global::System.DateTime? from,
            global::System.DateTime? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2StatusUpdateEditedChangesTargetDate" /> class.
        /// </summary>
        public WebhookProjectsV2StatusUpdateEditedChangesTargetDate()
        {
        }
    }
}