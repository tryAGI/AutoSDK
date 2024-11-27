//HintName: G.IUserClient.RegisterConnection.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// RegisterConnection<br/>
        /// RegisterConnection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> RegisterConnectionAsync(
            global::G.RegisterConnectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// RegisterConnection<br/>
        /// RegisterConnection
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> RegisterConnectionAsync(
            global::System.Guid userId,
            global::System.Guid connectionKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}