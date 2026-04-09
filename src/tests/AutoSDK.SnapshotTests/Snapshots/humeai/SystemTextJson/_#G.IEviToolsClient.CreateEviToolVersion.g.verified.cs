//HintName: G.IEviToolsClient.CreateEviToolVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IEviToolsClient
    {
        /// <summary>
        /// Create an EVI tool version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnUserDefinedTool> CreateEviToolVersionAsync(
            string id,

            global::G.PostedUserDefinedToolVersion request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an EVI tool version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="fallbackContent"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnUserDefinedTool> CreateEviToolVersionAsync(
            string id,
            string parameters,
            string? versionDescription = default,
            string? description = default,
            string? fallbackContent = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}