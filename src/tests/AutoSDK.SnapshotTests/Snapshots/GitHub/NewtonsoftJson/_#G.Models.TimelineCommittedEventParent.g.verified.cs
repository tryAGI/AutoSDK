//HintName: G.Models.TimelineCommittedEventParent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimelineCommittedEventParent
    {
        /// <summary>
        /// SHA for the commit<br/>
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </summary>
        /// <example>7638417db6d59f3c431d3e1f261cc637155684cd</example>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEventParent" /> class.
        /// </summary>
        /// <param name="sha">
        /// SHA for the commit<br/>
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        public TimelineCommittedEventParent(
            string sha,
            string url,
            string htmlUrl)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEventParent" /> class.
        /// </summary>
        public TimelineCommittedEventParent()
        {
        }
    }
}