//HintName: G.ILoginClient.Validate2Factor.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Validates 2 factor.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <param name="authToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> Validate2FactorAsync(
            string? token = default,
            string? username = default,
            string? authToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}