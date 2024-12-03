//HintName: G.Models.WebhookProjectsV2ProjectEditedChangesDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ProjectEditedChangesDescription
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
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ProjectEditedChangesDescription" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public WebhookProjectsV2ProjectEditedChangesDescription(
            string? from,
            string? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ProjectEditedChangesDescription" /> class.
        /// </summary>
        public WebhookProjectsV2ProjectEditedChangesDescription()
        {
        }
    }
}