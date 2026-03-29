//HintName: G.IResearchClient.StartDeepResearch.g.cs
#nullable enable

namespace G
{
    public partial interface IResearchClient
    {
        /// <summary>
        /// Start a deep research operation on a query
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartDeepResearchResponse> StartDeepResearchAsync(

            global::G.StartDeepResearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a deep research operation on a query
        /// </summary>
        /// <param name="query">
        /// The query to research
        /// </param>
        /// <param name="maxDepth">
        /// Maximum depth of research iterations<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="timeLimit">
        /// Time limit in seconds<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="maxUrls">
        /// Maximum number of URLs to analyze<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="analysisPrompt">
        /// The prompt to use for the final analysis. Useful to format the final analysis markdown in a specific way.
        /// </param>
        /// <param name="systemPrompt">
        /// The system prompt to use for the research agent. Useful to steer the research agent to a specific direction.
        /// </param>
        /// <param name="formats"></param>
        /// <param name="jsonOptions">
        /// Options for JSON output
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartDeepResearchResponse> StartDeepResearchAsync(
            string query,
            int? maxDepth = default,
            int? timeLimit = default,
            int? maxUrls = default,
            string? analysisPrompt = default,
            string? systemPrompt = default,
            global::System.Collections.Generic.IList<global::G.StartDeepResearchRequestFormat>? formats = default,
            global::G.StartDeepResearchRequestJsonOptions? jsonOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}