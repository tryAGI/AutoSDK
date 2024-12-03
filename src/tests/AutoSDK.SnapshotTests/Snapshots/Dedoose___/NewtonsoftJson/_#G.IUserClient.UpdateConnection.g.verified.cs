//HintName: G.IUserClient.UpdateConnection.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// UpdateConnection<br/>
        /// UpdateConnection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> UpdateConnectionAsync(
            global::G.UpdateConnectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateConnection<br/>
        /// UpdateConnection
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="connectionKey"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> UpdateConnectionAsync(
            global::System.Guid? userId,
            global::System.Guid connectionKey,
            global::System.Guid? projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}