//HintName: G.Models.WebhookStatusCommitParent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusCommitParent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitParent" /> class.
        /// </summary>
        /// <param name="htmlUrl"></param>
        /// <param name="sha"></param>
        /// <param name="url"></param>
        public WebhookStatusCommitParent(
            string htmlUrl,
            string sha,
            string url)
        {
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitParent" /> class.
        /// </summary>
        public WebhookStatusCommitParent()
        {
        }
    }
}