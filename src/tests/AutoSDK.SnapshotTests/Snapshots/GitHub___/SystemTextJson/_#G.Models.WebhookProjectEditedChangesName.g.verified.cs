//HintName: G.Models.WebhookProjectEditedChangesName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectEditedChangesName
    {
        /// <summary>
        /// The changes to the project if the action was `edited`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectEditedChangesName" /> class.
        /// </summary>
        /// <param name="from">
        /// The changes to the project if the action was `edited`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookProjectEditedChangesName(
            string from)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectEditedChangesName" /> class.
        /// </summary>
        public WebhookProjectEditedChangesName()
        {
        }
    }
}