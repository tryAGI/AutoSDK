//HintName: G.Models.EventPayloadPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventPayloadPage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_name")]
        public string? PageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventPayloadPage" /> class.
        /// </summary>
        /// <param name="pageName"></param>
        /// <param name="title"></param>
        /// <param name="summary"></param>
        /// <param name="action"></param>
        /// <param name="sha"></param>
        /// <param name="htmlUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EventPayloadPage(
            string? pageName,
            string? title,
            string? summary,
            string? action,
            string? sha,
            string? htmlUrl)
        {
            this.PageName = pageName;
            this.Title = title;
            this.Summary = summary;
            this.Action = action;
            this.Sha = sha;
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventPayloadPage" /> class.
        /// </summary>
        public EventPayloadPage()
        {
        }
    }
}