//HintName: G.IUsersClient.GetConnectionKey.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get Connection Key<br/>
        /// Returns the current connection key.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Guid> GetConnectionKeyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}