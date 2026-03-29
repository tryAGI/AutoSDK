//HintName: G.Models.GetActiveCrawlsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetActiveCrawlsResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crawls")]
        public global::System.Collections.Generic.IList<global::G.GetActiveCrawlsResponseCrawl>? Crawls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveCrawlsResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: true
        /// </param>
        /// <param name="crawls"></param>
        public GetActiveCrawlsResponse(
            bool success,
            global::System.Collections.Generic.IList<global::G.GetActiveCrawlsResponseCrawl>? crawls)
        {
            this.Success = success;
            this.Crawls = crawls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveCrawlsResponse" /> class.
        /// </summary>
        public GetActiveCrawlsResponse()
        {
        }
    }
}