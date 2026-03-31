//HintName: G.IApi.AnswerAsStream.g.cs
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
        global::System.Collections.Generic.IAsyncEnumerable<global::G.AnswerResponse3> AnswerAsStreamAsync(

            global::G.AnswerRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.AnswerResponse3> AnswerAsStreamAsync(
            string query,
            bool? text = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}