//HintName: G.IApi.ShowPetsByIdsMatrix.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Info for several pets, matrix style<br/>
        /// An array path parameter in the OpenAPI matrix style without explode, which renders as `;petIds=a,b`.
        /// </summary>
        /// <param name="petIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Pet>> ShowPetsByIdsMatrixAsync(
            global::System.Collections.Generic.IList<string> petIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Info for several pets, matrix style<br/>
        /// An array path parameter in the OpenAPI matrix style without explode, which renders as `;petIds=a,b`.
        /// </summary>
        /// <param name="petIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Pet>>> ShowPetsByIdsMatrixAsResponseAsync(
            global::System.Collections.Generic.IList<string> petIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}