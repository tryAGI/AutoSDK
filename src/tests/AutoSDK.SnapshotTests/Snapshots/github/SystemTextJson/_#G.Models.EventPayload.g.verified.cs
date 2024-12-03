//HintName: G.Models.EventPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        public global::G.Issue? Issue { get; set; }

        /// <summary>
        /// Comments provide a way for people to collaborate on an issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public global::G.IssueComment? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<global::G.EventPayloadPage>? Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventPayload" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="issue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="comment">
        /// Comments provide a way for people to collaborate on an issue.
        /// </param>
        /// <param name="pages"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EventPayload(
            string? action,
            global::G.Issue? issue,
            global::G.IssueComment? comment,
            global::System.Collections.Generic.IList<global::G.EventPayloadPage>? pages)
        {
            this.Action = action;
            this.Issue = issue;
            this.Comment = comment;
            this.Pages = pages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventPayload" /> class.
        /// </summary>
        public EventPayload()
        {
        }
    }
}