//HintName: G.Models.CrawlStatusResponseObjDataItemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrawlStatusResponseObjDataItemMetadata
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
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceURL")]
        public string? SourceURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("<any other metadata> ")]
        public string? x_any_other_metadata__ { get; set; }

        /// <summary>
        /// The status code of the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statusCode")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Timezone inferred by the scraping engine, when available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// The error message of the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlStatusResponseObjDataItemMetadata" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="language"></param>
        /// <param name="sourceURL"></param>
        /// <param name="x_any_other_metadata__"></param>
        /// <param name="statusCode">
        /// The status code of the page
        /// </param>
        /// <param name="timezone">
        /// Timezone inferred by the scraping engine, when available
        /// </param>
        /// <param name="error">
        /// The error message of the page
        /// </param>
        public CrawlStatusResponseObjDataItemMetadata(
            string? title,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? description,
            string? language,
            string? sourceURL,
            string? x_any_other_metadata__,
            int? statusCode,
            string? timezone,
            string? error)
        {
            this.Title = title;
            this.Description = description;
            this.Language = language;
            this.SourceURL = sourceURL;
            this.x_any_other_metadata__ = x_any_other_metadata__;
            this.StatusCode = statusCode;
            this.Timezone = timezone;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlStatusResponseObjDataItemMetadata" /> class.
        /// </summary>
        public CrawlStatusResponseObjDataItemMetadata()
        {
        }
    }
}