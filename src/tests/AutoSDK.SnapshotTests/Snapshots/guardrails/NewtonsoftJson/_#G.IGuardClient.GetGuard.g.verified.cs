//HintName: G.IGuardClient.GetGuard.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardClient
    {
        /// <summary>
        /// Fetches a specific Guard
        /// </summary>
        /// <param name="guardName"></param>
        /// <param name="asOf"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Guard> GetGuardAsync(
            string guardName,
            global::System.DateTime? asOf = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}