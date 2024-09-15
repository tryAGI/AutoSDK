//HintName: G.IUsersClient.GetConnectionKey.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Returns current connection key.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Guid> GetConnectionKeyAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}