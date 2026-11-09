//HintName: G.IApi.ShowPetsByIds.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Info for several pets at once<br/>
        /// An array-typed path parameter, serialized with the OpenAPI simple style: the items are joined with commas.
        /// </summary>
        /// <param name="petIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Pet>> ShowPetsByIdsAsync(
            global::System.Collections.Generic.IList<string> petIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Info for several pets at once<br/>
        /// An array-typed path parameter, serialized with the OpenAPI simple style: the items are joined with commas.
        /// </summary>
        /// <param name="petIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Pet>>> ShowPetsByIdsAsResponseAsync(
            global::System.Collections.Generic.IList<string> petIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}