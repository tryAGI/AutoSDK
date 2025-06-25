//HintName: G.Models.WebhookIssuesEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the issue.
    /// </summary>
    public sealed partial class WebhookIssuesEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::G.WebhookIssuesEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public global::G.WebhookIssuesEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesEditedChanges" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesEditedChanges(
            global::G.WebhookIssuesEditedChangesBody? body,
            global::G.WebhookIssuesEditedChangesTitle? title)
        {
            this.Body = body;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesEditedChanges" /> class.
        /// </summary>
        public WebhookIssuesEditedChanges()
        {
        }
    }
}