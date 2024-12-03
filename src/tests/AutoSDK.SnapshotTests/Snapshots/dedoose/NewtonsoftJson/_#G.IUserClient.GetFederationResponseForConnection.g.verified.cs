//HintName: G.IUserClient.GetFederationResponseForConnection.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// GetFederationResponseForConnection<br/>
        /// GetFederationResponseForConnection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFederationResponseForConnectionAsync(
            global::G.GetFederationResponseForConnectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetFederationResponseForConnection<br/>
        /// GetFederationResponseForConnection
        /// </summary>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetFederationResponseForConnectionAsync(
            global::System.Guid connectionKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}