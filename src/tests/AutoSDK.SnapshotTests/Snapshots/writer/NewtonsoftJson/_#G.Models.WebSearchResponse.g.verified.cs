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
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Generated answer based on the search results. Not included if `include_answer` is `false`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// The search results found.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebSearchResponseSource> Sources { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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