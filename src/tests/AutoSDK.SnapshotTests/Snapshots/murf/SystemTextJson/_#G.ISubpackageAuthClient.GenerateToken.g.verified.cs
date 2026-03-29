//HintName: G.ISubpackageAuthClient.GenerateToken.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageAuthClient
    {
        /// <summary>
        /// Generate auth token<br/>
        /// Generates an auth token for authenticating your requests
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AuthTokenResponse> GenerateTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}