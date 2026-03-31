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
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetContentsResponseStatuseErrorTagJsonConverter))]
        public global::G.GetContentsResponseStatuseErrorTag? Tag { get; set; }

        /// <summary>
        /// The corresponding HTTP status code<br/>
        /// Example: 404
        /// </summary>
        /// <example>404</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpStatusCode")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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