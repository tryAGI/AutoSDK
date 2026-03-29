//HintName: G.Models.WebsiteCrawlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsiteCrawlRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("websites", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebsiteCrawlRequestWebsite> Websites { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteCrawlRequest" /> class.
        /// </summary>
        /// <param name="websites"></param>
        public WebsiteCrawlRequest(
            global::System.Collections.Generic.IList<global::G.WebsiteCrawlRequestWebsite> websites)
        {
            this.Websites = websites ?? throw new global::System.ArgumentNullException(nameof(websites));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteCrawlRequest" /> class.
        /// </summary>
        public WebsiteCrawlRequest()
        {
        }
    }
}