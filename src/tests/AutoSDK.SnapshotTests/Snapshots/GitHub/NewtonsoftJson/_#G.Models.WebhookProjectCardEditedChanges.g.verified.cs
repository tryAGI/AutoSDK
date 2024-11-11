//HintName: G.Models.WebhookProjectCardEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectCardEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookProjectCardEditedChangesNote Note { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardEditedChanges" /> class.
        /// </summary>
        /// <param name="note"></param>
        public WebhookProjectCardEditedChanges(
            global::G.WebhookProjectCardEditedChangesNote note)
        {
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardEditedChanges" /> class.
        /// </summary>
        public WebhookProjectCardEditedChanges()
        {
        }
    }
}