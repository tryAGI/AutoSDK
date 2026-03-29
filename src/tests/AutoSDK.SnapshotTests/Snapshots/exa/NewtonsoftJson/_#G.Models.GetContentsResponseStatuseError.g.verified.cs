//HintName: G.Models.GetContentsResponseStatuseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error details, only present when status is "error"
    /// </summary>
    public sealed partial class GetContentsResponseStatuseError
    {
        /// <summary>
        /// Specific error type<br/>
        /// Example: CRAWL_NOT_FOUND
        /// </summary>
        /// <example>CRAWL_NOT_FOUND</example>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public global::G.GetContentsResponseStatuseErrorTag? Tag { get; set; }

        /// <summary>
        /// The corresponding HTTP status code<br/>
        /// Example: 404
        /// </summary>
        /// <example>404</example>
        [global::Newtonsoft.Json.JsonProperty("httpStatusCode")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContentsResponseStatuseError" /> class.
        /// </summary>
        /// <param name="tag">
        /// Specific error type<br/>
        /// Example: CRAWL_NOT_FOUND
        /// </param>
        /// <param name="httpStatusCode">
        /// The corresponding HTTP status code<br/>
        /// Example: 404
        /// </param>
        public GetContentsResponseStatuseError(
            global::G.GetContentsResponseStatuseErrorTag? tag,
            int? httpStatusCode)
        {
            this.Tag = tag;
            this.HttpStatusCode = httpStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContentsResponseStatuseError" /> class.
        /// </summary>
        public GetContentsResponseStatuseError()
        {
        }
    }
}