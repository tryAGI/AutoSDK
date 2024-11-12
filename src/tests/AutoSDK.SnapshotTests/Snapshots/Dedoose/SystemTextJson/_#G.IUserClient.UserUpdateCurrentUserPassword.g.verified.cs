//HintName: G.IUserClient.UserUpdateCurrentUserPassword.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// UpdateCurrentUserPassword.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UserUpdateCurrentUserPasswordAsync(
            string? token = default,
            global::System.Guid? userId = default,
            string? encryptedPass = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}