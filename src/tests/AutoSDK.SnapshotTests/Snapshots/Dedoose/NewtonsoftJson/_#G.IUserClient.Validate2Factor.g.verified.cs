//HintName: G.IUserClient.Validate2Factor.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Validate2Factor<br/>
        /// Validate2Factor
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> Validate2FactorAsync(
            global::G.Validate2FactorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Validate2Factor<br/>
        /// Validate2Factor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="connectionKey"></param>
        /// <param name="encryptedAuthToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> Validate2FactorAsync(
            string username,
            global::System.Guid connectionKey,
            string encryptedAuthToken,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}