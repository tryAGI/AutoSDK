//HintName: G.IApplicationClientsClient.ListAppClient.g.cs
#nullable enable

namespace G
{
    public partial interface IApplicationClientsClient
    {
        /// <summary>
        /// List App Clients
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="filter"></param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListAppClientsResponse> ListAppClientAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = 10,
            string? filter = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}