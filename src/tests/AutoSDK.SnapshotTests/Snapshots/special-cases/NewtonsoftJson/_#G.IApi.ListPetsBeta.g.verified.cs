//HintName: G.IApi.ListPetsBeta.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List all pets (beta)<br/>
        /// A spec cannot declare two operations on the same path and method, so the beta variant is keyed by a query string and states its real request path with x-autosdk-path.
        /// </summary>
        /// <param name="xBetaFeatures"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Pet>> ListPetsBetaAsync(
            global::System.Collections.Generic.IList<string>? xBetaFeatures = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all pets (beta)<br/>
        /// A spec cannot declare two operations on the same path and method, so the beta variant is keyed by a query string and states its real request path with x-autosdk-path.
        /// </summary>
        /// <param name="xBetaFeatures"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Pet>>> ListPetsBetaAsResponseAsync(
            global::System.Collections.Generic.IList<string>? xBetaFeatures = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}