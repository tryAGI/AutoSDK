//HintName: G.IUserClient.UserValidate2Factor.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Validate2Factor.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <param name="connectionKey"></param>
        /// <param name="encryptedAuthToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> UserValidate2FactorAsync(
            string? token = default,
            string? username = default,
            global::System.Guid? connectionKey = default,
            string? encryptedAuthToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}