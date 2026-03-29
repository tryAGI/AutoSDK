//HintName: G.Models.WebSearchServerToolOpenRouterParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchServerToolOpenRouterParameters
    {
        /// <summary>
        /// Maximum number of search results to return per search call. Defaults to 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public double? MaxResults { get; set; }

        /// <summary>
        /// Maximum total number of search results across all search calls in a single request. Once this limit is reached, the tool will stop returning new results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_total_results")]
        public double? MaxTotalResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerToolOpenRouterParameters" /> class.
        /// </summary>
        /// <param name="maxResults">
        /// Maximum number of search results to return per search call. Defaults to 5.
        /// </param>
        /// <param name="maxTotalResults">
        /// Maximum total number of search results across all search calls in a single request. Once this limit is reached, the tool will stop returning new results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchServerToolOpenRouterParameters(
            double? maxResults,
            double? maxTotalResults)
        {
            this.MaxResults = maxResults;
            this.MaxTotalResults = maxTotalResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerToolOpenRouterParameters" /> class.
        /// </summary>
        public WebSearchServerToolOpenRouterParameters()
        {
        }
    }
}