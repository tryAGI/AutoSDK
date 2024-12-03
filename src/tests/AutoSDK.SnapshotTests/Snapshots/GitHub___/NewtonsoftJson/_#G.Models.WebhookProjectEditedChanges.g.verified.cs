//HintName: G.Models.WebhookProjectEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the project if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookProjectEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public global::G.WebhookProjectEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.WebhookProjectEditedChangesName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectEditedChanges" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="name"></param>
        public WebhookProjectEditedChanges(
            global::G.WebhookProjectEditedChangesBody? body,
            global::G.WebhookProjectEditedChangesName? name)
        {
            this.Body = body;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectEditedChanges" /> class.
        /// </summary>
        public WebhookProjectEditedChanges()
        {
        }
    }
}