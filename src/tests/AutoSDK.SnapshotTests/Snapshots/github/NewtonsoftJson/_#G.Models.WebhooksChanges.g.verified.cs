//HintName: G.Models.WebhooksChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the comment.
    /// </summary>
    public sealed partial class WebhooksChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public global::G.WebhooksChangesBody? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksChanges" /> class.
        /// </summary>
        /// <param name="body"></param>
        public WebhooksChanges(
            global::G.WebhooksChangesBody? body)
        {
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksChanges" /> class.
        /// </summary>
        public WebhooksChanges()
        {
        }
    }
}