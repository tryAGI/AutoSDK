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
        [global::Newtonsoft.Json.JsonProperty("page_name")]
        public string? PageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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