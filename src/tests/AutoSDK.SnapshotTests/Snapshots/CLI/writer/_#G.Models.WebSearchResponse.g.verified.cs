//HintName: G.Models.WebSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchResponse
    {
        /// <summary>
        /// The search query that was submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Generated answer based on the search results. Not included if `include_answer` is `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// The search results found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebSearchResponseSource> Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResponse" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query that was submitted.
        /// </param>
        /// <param name="sources">
        /// The search results found.
        /// </param>
        /// <param name="answer">
        /// Generated answer based on the search results. Not included if `include_answer` is `false`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchResponse(
            string query,
            global::System.Collections.Generic.IList<global::G.WebSearchResponseSource> sources,
            string? answer)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Answer = answer;
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResponse" /> class.
        /// </summary>
        public WebSearchResponse()
        {
        }
    }
}