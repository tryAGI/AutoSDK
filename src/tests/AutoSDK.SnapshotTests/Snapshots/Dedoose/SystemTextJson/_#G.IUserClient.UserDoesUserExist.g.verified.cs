//HintName: G.IUserClient.UserDoesUserExist.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// DoesUserExist.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> UserDoesUserExistAsync(
            string? username = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}