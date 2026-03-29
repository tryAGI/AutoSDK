//HintName: G.Models.CrawlErrorsResponseObjError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrawlErrorsResponseObjError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// ISO timestamp of failure
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Scraped URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlErrorsResponseObjError" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timestamp">
        /// ISO timestamp of failure
        /// </param>
        /// <param name="url">
        /// Scraped URL
        /// </param>
        /// <param name="error">
        /// Error message
        /// </param>
        public CrawlErrorsResponseObjError(
            string? id,
            string? timestamp,
            string? url,
            string? error)
        {
            this.Id = id;
            this.Timestamp = timestamp;
            this.Url = url;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlErrorsResponseObjError" /> class.
        /// </summary>
        public CrawlErrorsResponseObjError()
        {
        }
    }
}