//HintName: G.Models.WebhookProjectColumnEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectColumnEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.WebhookProjectColumnEditedChangesName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectColumnEditedChanges" /> class.
        /// </summary>
        /// <param name="name"></param>
        public WebhookProjectColumnEditedChanges(
            global::G.WebhookProjectColumnEditedChangesName? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectColumnEditedChanges" /> class.
        /// </summary>
        public WebhookProjectColumnEditedChanges()
        {
        }
    }
}