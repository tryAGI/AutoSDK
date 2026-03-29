//HintName: G.Models.ScrapeOptionsActionScreenshot.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeOptionsActionScreenshot
    {
        /// <summary>
        /// Take a screenshot. The links will be in the response's `actions.screenshots` array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ScrapeOptionsActionScreenshotType Type { get; set; }

        /// <summary>
        /// Should the screenshot be full-page or viewport sized?<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fullPage")]
        public bool? FullPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionScreenshot" /> class.
        /// </summary>
        /// <param name="type">
        /// Take a screenshot. The links will be in the response's `actions.screenshots` array.
        /// </param>
        /// <param name="fullPage">
        /// Should the screenshot be full-page or viewport sized?<br/>
        /// Default Value: false
        /// </param>
        public ScrapeOptionsActionScreenshot(
            global::G.ScrapeOptionsActionScreenshotType type,
            bool? fullPage)
        {
            this.Type = type;
            this.FullPage = fullPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionScreenshot" /> class.
        /// </summary>
        public ScrapeOptionsActionScreenshot()
        {
        }
    }
}