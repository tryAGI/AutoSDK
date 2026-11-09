//HintName: G.IApi.ShowPetsByIdsLabel.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Info for several pets, label style<br/>
        /// An array path parameter in the OpenAPI label style with explode, which renders as `.a.b` rather than a comma-joined list.
        /// </summary>
        /// <param name="petIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Pet>> ShowPetsByIdsLabelAsync(
            global::System.Collections.Generic.IList<string> petIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Info for several pets, label style<br/>
        /// An array path parameter in the OpenAPI label style with explode, which renders as `.a.b` rather than a comma-joined list.
        /// </summary>
        /// <param name="petIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Pet>>> ShowPetsByIdsLabelAsResponseAsync(
            global::System.Collections.Generic.IList<string> petIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}