//HintName: G.IApplicationClientsClient.CreateAppClient.g.cs
#nullable enable

namespace G
{
    public partial interface IApplicationClientsClient
    {
        /// <summary>
        /// Create an App Client<br/>
        /// An App Client is used for OAuth 2.0 authentication when calling Vectara APIs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppClient> CreateAppClientAsync(
            global::G.CreateAppClientRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an App Client<br/>
        /// An App Client is used for OAuth 2.0 authentication when calling Vectara APIs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppClient> CreateAppClientAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}