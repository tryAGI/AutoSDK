//HintName: G.ISubpackageModelsClient.GetModels.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageModelsClient
    {
        /// <summary>
        /// List all models and their properties
        /// </summary>
        /// <param name="category">
        /// Filter models by use case category
        /// </param>
        /// <param name="supportedParameters"></param>
        /// <param name="outputModalities"></param>
        /// <param name="useRss"></param>
        /// <param name="useRssChatLinks"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsListResponse> GetModelsAsync(
            global::G.ModelsGetParametersCategory? category = default,
            string? supportedParameters = default,
            string? outputModalities = default,
            string? useRss = default,
            string? useRssChatLinks = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}