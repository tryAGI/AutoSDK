//HintName: G.IConnectedAccountsClient.PatchConnectedAccountsByNanoIdStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Enable or disable a connected account<br/>
        /// Updates the status of a connected account to either enabled (active) or disabled (inactive). Disabled accounts cannot be used for API calls but remain in the database.
        /// </summary>
        /// <param name="nanoId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchConnectedAccountsByNanoIdStatusResponse> PatchConnectedAccountsByNanoIdStatusAsync(
            string nanoId,

            global::G.PatchConnectedAccountsByNanoIdStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable or disable a connected account<br/>
        /// Updates the status of a connected account to either enabled (active) or disabled (inactive). Disabled accounts cannot be used for API calls but remain in the database.
        /// </summary>
        /// <param name="nanoId"></param>
        /// <param name="enabled">
        /// Set to true to enable the account or false to disable it
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchConnectedAccountsByNanoIdStatusResponse> PatchConnectedAccountsByNanoIdStatusAsync(
            string nanoId,
            bool enabled,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}