//HintName: G.IApplicationClientsClient.GetAppClient.g.cs
#nullable enable

namespace G
{
    public partial interface IApplicationClientsClient
    {
        /// <summary>
        /// Get an App Client
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="appClientId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppClient> GetAppClientAsync(
            string appClientId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}