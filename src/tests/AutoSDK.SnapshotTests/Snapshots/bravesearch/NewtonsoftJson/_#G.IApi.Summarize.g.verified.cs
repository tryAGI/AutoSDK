//HintName: G.IApi.Summarize.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Summarizer<br/>
        /// Get an AI-generated summary for a search query.<br/>
        /// Requires a summarizer key obtained from the web search endpoint<br/>
        /// (pass summary=true to web search first). The key is found in the<br/>
        /// web search response under the summarizer field.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="entityInfo">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizerSearchResult> SummarizeAsync(
            string key,
            bool? entityInfo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}