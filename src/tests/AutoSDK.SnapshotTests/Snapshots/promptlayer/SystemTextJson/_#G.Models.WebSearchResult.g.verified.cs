//HintName: G.Models.WebSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchResult
    {
        /// <summary>
        /// Default Value: web_search_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebSearchResultTypeJsonConverter))]
        public global::G.WebSearchResultType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_age")]
        public string? PageAge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: web_search_result
        /// </param>
        /// <param name="url"></param>
        /// <param name="title"></param>
        /// <param name="encryptedContent"></param>
        /// <param name="pageAge">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchResult(
            global::G.WebSearchResultType? type,
            string? url,
            string? title,
            string? encryptedContent,
            string? pageAge)
        {
            this.Type = type;
            this.Url = url;
            this.Title = title;
            this.EncryptedContent = encryptedContent;
            this.PageAge = pageAge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResult" /> class.
        /// </summary>
        public WebSearchResult()
        {
        }
    }
}