//HintName: G.IApi.Answer.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Generate an answer from search results<br/>
        /// Performs a search based on the query and generates either a direct answer or a detailed summary with citations, depending on the query type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/answer' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "query": "What is the latest valuation of SpaceX?",<br/>
        ///     "text": true<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.AnswerResult, global::G.AnswerResponse2>> AnswerAsync(

            global::G.AnswerRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an answer from search results<br/>
        /// Performs a search based on the query and generates either a direct answer or a detailed summary with citations, depending on the query type.
        /// </summary>
        /// <param name="query">
        /// The question or query to answer.<br/>
        /// Example: What is the latest valuation of SpaceX?
        /// </param>
        /// <param name="text">
        /// If true, the response includes full text content in the search results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.AnswerResult, global::G.AnswerResponse2>> AnswerAsync(
            string query,
            bool? text = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}