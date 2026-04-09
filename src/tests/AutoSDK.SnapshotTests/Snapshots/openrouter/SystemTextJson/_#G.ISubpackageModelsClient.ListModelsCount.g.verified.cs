//HintName: G.ISubpackageModelsClient.ListModelsCount.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageModelsClient
    {
        /// <summary>
        /// Get total count of available models
        /// </summary>
        /// <param name="outputModalities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsCountResponse> ListModelsCountAsync(
            string? outputModalities = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}