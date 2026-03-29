//HintName: G.IConfigsClient.UpdateConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Update a config
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateConfigResponse> UpdateConfigAsync(
            string slug,

            global::G.UpdateConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a config
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="config"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateConfigResponse> UpdateConfigAsync(
            string slug,
            string? name = default,
            global::G.UpdateConfigRequestConfig? config = default,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}