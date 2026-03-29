//HintName: G.Models.SearchAndScrapeResponseDataItemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchAndScrapeResponseDataItemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceURL")]
        public string? SourceURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statusCode")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeResponseDataItemMetadata" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="sourceURL"></param>
        /// <param name="statusCode"></param>
        /// <param name="error"></param>
        public SearchAndScrapeResponseDataItemMetadata(
            string? title,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? description,
            string? sourceURL,
            int? statusCode,
            string? error)
        {
            this.Title = title;
            this.Description = description;
            this.SourceURL = sourceURL;
            this.StatusCode = statusCode;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeResponseDataItemMetadata" /> class.
        /// </summary>
        public SearchAndScrapeResponseDataItemMetadata()
        {
        }
    }
}