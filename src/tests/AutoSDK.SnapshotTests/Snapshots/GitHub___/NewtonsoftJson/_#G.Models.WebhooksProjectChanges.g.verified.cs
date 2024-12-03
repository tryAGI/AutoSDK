//HintName: G.Models.WebhooksProjectChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksProjectChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived_at")]
        public global::G.WebhooksProjectChangesArchivedAt? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksProjectChanges" /> class.
        /// </summary>
        /// <param name="archivedAt"></param>
        public WebhooksProjectChanges(
            global::G.WebhooksProjectChangesArchivedAt? archivedAt)
        {
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksProjectChanges" /> class.
        /// </summary>
        public WebhooksProjectChanges()
        {
        }
    }
}