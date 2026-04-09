//HintName: G.IVariationClient.CreateVariationNoBG.g.cs
#nullable enable

namespace G
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Create no background<br/>
        /// This endpoint will create a no background variation of the provided image ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVariationNoBGResponse> CreateVariationNoBGAsync(

            global::G.CreateVariationNoBGRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create no background<br/>
        /// This endpoint will create a no background variation of the provided image ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isVariation"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVariationNoBGResponse> CreateVariationNoBGAsync(
            string id,
            bool? isVariation = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}