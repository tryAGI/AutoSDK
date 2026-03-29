//HintName: G.Models.WebSearchResponseSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchResponseSource
    {
        /// <summary>
        /// URL of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Raw content from the source URL. Not included if `include_raw_content` is `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_content")]
        public string? RawContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResponseSource" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the search result.
        /// </param>
        /// <param name="rawContent">
        /// Raw content from the source URL. Not included if `include_raw_content` is `false`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchResponseSource(
            string? url,
            string? rawContent)
        {
            this.Url = url;
            this.RawContent = rawContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResponseSource" /> class.
        /// </summary>
        public WebSearchResponseSource()
        {
        }
    }
}