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
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public WebhooksChangesBody? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}