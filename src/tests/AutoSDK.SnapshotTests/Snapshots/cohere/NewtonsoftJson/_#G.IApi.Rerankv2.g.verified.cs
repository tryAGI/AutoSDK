//HintName: G.IApi.Rerankv2.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Rerank V2 API<br/>
        /// This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Rerankv2Response> Rerankv2Async(
            global::G.Rerankv2Request request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Rerank V2 API<br/>
        /// This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// The identifier of the model to use, eg `rerank-v3.5`.
        /// </param>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="documents">
        /// A list of texts that will be compared to the `query`.<br/>
        /// For optimal performance we recommend against sending more than 1,000 documents in a single request.<br/>
        /// **Note**: long documents will automatically be truncated to the value of `max_tokens_per_doc`.<br/>
        /// **Note**: structured data should be formatted as YAML strings for best performance.
        /// </param>
        /// <param name="topN">
        /// Limits the number of returned rerank results to the specified value. If not passed, all the rerank results will be returned.
        /// </param>
        /// <param name="maxTokensPerDoc">
        /// Defaults to `4096`. Long documents will be automatically truncated to the specified number of tokens.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Rerankv2Response> Rerankv2Async(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            string? xClientName = default,
            int? topN = default,
            int? maxTokensPerDoc = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}