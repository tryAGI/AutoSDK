//HintName: G.Models.WebhookGollumPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookGollumPage
    {
        /// <summary>
        /// The action that was performed on the page. Can be `created` or `edited`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookGollumPageAction Action { get; set; } = default!;

        /// <summary>
        /// Points to the HTML wiki page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The name of the page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PageName { get; set; } = default!;

        /// <summary>
        /// The latest commit SHA of the page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Summary { get; set; } = default!;

        /// <summary>
        /// The current page title.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGollumPage" /> class.
        /// </summary>
        /// <param name="action">
        /// The action that was performed on the page. Can be `created` or `edited`.
        /// </param>
        /// <param name="htmlUrl">
        /// Points to the HTML wiki page.
        /// </param>
        /// <param name="pageName">
        /// The name of the page.
        /// </param>
        /// <param name="sha">
        /// The latest commit SHA of the page.
        /// </param>
        /// <param name="summary"></param>
        /// <param name="title">
        /// The current page title.
        /// </param>
        public WebhookGollumPage(
            global::G.WebhookGollumPageAction action,
            string htmlUrl,
            string pageName,
            string sha,
            string? summary,
            string title)
        {
            this.Action = action;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.PageName = pageName ?? throw new global::System.ArgumentNullException(nameof(pageName));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGollumPage" /> class.
        /// </summary>
        public WebhookGollumPage()
        {
        }
    }
}