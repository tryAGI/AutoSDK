//HintName: G.ILoginClient.Validate2FactorCustom.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Validate Two-Factor Authentication<br/>
        /// Validates two-factor authentication credentials and returns user data.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="authToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> Validate2FactorCustomAsync(
            string username,
            string authToken,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}