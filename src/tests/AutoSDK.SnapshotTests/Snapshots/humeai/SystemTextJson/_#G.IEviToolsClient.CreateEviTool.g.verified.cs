//HintName: G.IEviToolsClient.CreateEviTool.g.cs
#nullable enable

namespace G
{
    public partial interface IEviToolsClient
    {
        /// <summary>
        /// Create an EVI tool
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnUserDefinedTool> CreateEviToolAsync(

            global::G.PostedUserDefinedTool request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an EVI tool
        /// </summary>
        /// <param name="name"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="fallbackContent"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnUserDefinedTool> CreateEviToolAsync(
            string name,
            string parameters,
            string? versionDescription = default,
            string? description = default,
            string? fallbackContent = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}