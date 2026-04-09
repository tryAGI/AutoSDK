//HintName: G.IApi.FindSimilar.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Find similar links<br/>
        /// Find similar links to the link provided. Optionally get contents.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/findSimilar' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "url": "https://arxiv.org/abs/2307.06435",<br/>
        ///     "text": true<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.FindSimilarResponse> FindSimilarAsync(

            global::G.AllOf<global::G.FindSimilarRequest2, global::G.CommonRequest> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find similar links<br/>
        /// Find similar links to the link provided. Optionally get contents.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FindSimilarResponse> FindSimilarAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}