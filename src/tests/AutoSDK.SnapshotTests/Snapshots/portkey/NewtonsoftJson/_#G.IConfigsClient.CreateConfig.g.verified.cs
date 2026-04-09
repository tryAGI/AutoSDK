//HintName: G.IConfigsClient.CreateConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Create a config
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateConfigResponse> CreateConfigAsync(

            global::G.CreateConfigRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a config
        /// </summary>
        /// <param name="name"></param>
        /// <param name="config"></param>
        /// <param name="isDefault"></param>
        /// <param name="workspaceId">
        /// optional, when using organisation admin API keys
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateConfigResponse> CreateConfigAsync(
            string? name = default,
            object? config = default,
            int? isDefault = default,
            global::System.Guid? workspaceId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}