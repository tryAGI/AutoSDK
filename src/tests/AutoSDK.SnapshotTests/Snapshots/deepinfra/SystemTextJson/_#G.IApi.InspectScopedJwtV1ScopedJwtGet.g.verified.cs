//HintName: G.IApi.InspectScopedJwtV1ScopedJwtGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Inspect Scoped Jwt
        /// </summary>
        /// <param name="jwtoken"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InspectScopedJWTOut> InspectScopedJwtV1ScopedJwtGetAsync(
            string jwtoken,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}