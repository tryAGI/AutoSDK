//HintName: G.Models.CreateCrawlResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCrawlResponseResult
    {
        /// <summary>
        /// The URL that was crawled.<br/>
        /// Example: https://docs.tavily.com
        /// </summary>
        /// <example>https://docs.tavily.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The full content extracted from the page. When `query` is provided, contains the top-ranked chunks joined by `[...]` separator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_content")]
        public string? RawContent { get; set; }

        /// <summary>
        /// The favicon URL for the result.<br/>
        /// Example: https://mintlify.s3-us-west-1.amazonaws.com/tavilyai/_generated/favicon/apple-touch-icon.png?v=3
        /// </summary>
        /// <example>https://mintlify.s3-us-west-1.amazonaws.com/tavilyai/_generated/favicon/apple-touch-icon.png?v=3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCrawlResponseResult" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL that was crawled.<br/>
        /// Example: https://docs.tavily.com
        /// </param>
        /// <param name="rawContent">
        /// The full content extracted from the page. When `query` is provided, contains the top-ranked chunks joined by `[...]` separator.
        /// </param>
        /// <param name="favicon">
        /// The favicon URL for the result.<br/>
        /// Example: https://mintlify.s3-us-west-1.amazonaws.com/tavilyai/_generated/favicon/apple-touch-icon.png?v=3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCrawlResponseResult(
            string? url,
            string? rawContent,
            string? favicon)
        {
            this.Url = url;
            this.RawContent = rawContent;
            this.Favicon = favicon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCrawlResponseResult" /> class.
        /// </summary>
        public CreateCrawlResponseResult()
        {
        }
    }
}