//HintName: G.Models.WebhookLabelEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the label if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookLabelEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public WebhookLabelEditedChangesColor? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public WebhookLabelEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public WebhookLabelEditedChangesName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}