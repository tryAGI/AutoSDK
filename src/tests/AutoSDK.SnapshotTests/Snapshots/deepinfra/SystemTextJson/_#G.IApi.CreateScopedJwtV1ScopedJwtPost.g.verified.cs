//HintName: G.IApi.CreateScopedJwtV1ScopedJwtPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        ///  Create Scoped Jwt
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScopedJWTOut> CreateScopedJwtV1ScopedJwtPostAsync(
            global::G.ScopedJWTIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        ///  Create Scoped Jwt
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="apiTokenName"></param>
        /// <param name="models">
        /// allow inference only to the specified model names
        /// </param>
        /// <param name="expiresDelta">
        /// how many seconds in the future should the token be valid for
        /// </param>
        /// <param name="expiresAt">
        /// unix timestamp when the token should expire
        /// </param>
        /// <param name="spendingLimit">
        /// only allow spending that much USD until the token becomes invalid
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScopedJWTOut> CreateScopedJwtV1ScopedJwtPostAsync(
            string apiTokenName,
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<string>? models = default,
            int? expiresDelta = default,
            int? expiresAt = default,
            double? spendingLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}