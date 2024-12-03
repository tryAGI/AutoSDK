//HintName: G.Models.WebhookProjectCardMovedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectCardMovedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookProjectCardMovedChangesColumnId ColumnId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedChanges" /> class.
        /// </summary>
        /// <param name="columnId"></param>
        public WebhookProjectCardMovedChanges(
            global::G.WebhookProjectCardMovedChangesColumnId columnId)
        {
            this.ColumnId = columnId ?? throw new global::System.ArgumentNullException(nameof(columnId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedChanges" /> class.
        /// </summary>
        public WebhookProjectCardMovedChanges()
        {
        }
    }
}