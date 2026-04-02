//HintName: G.IAdminApiClient.AdminGetDeveloperKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminApiClient
    {
        /// <summary>
        /// Get all developer keys as an admin
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ApiKey>> AdminGetDeveloperKeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all developer keys as an admin
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.ApiKey>>> AdminGetDeveloperKeysAsResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}