//HintName: G.IApi.GetContents.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Contents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/contents' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "urls": ["https://arxiv.org/abs/2307.06435"],<br/>
        ///     "text": true<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GetContentsResponse> GetContentsAsync(

            global::G.AllOf<global::G.GetContentsRequest2, global::G.ContentsRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Contents
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetContentsResponse> GetContentsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}