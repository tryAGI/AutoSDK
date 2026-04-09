//HintName: G.IModelsClient.ListModels.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Available Models<br/>
        /// Lists the currently available models that can be used through Portkey, and provides basic information about each one.
        /// </summary>
        /// <param name="aiService"></param>
        /// <param name="provider"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="sort">
        /// Default Value: name
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListModelsResponse> ListModelsAsync(
            string? aiService = default,
            string? provider = default,
            int? limit = default,
            int? offset = default,
            global::G.ListModelsSort? sort = default,
            global::G.ListModelsOrder? order = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}