//HintName: G.ISubpackageOAuthClient.ExchangeAuthCodeForApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageOAuthClient
    {
        /// <summary>
        /// Exchange authorization code for API key<br/>
        /// Exchange an authorization code from the PKCE flow for a user-controlled API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OAuthExchangeAuthCodeForAPIKeyResponse200> ExchangeAuthCodeForApiKeyAsync(

            global::G.ExchangeAuthCodeForApiKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchange authorization code for API key<br/>
        /// Exchange an authorization code from the PKCE flow for a user-controlled API key
        /// </summary>
        /// <param name="code">
        /// The authorization code received from the OAuth redirect
        /// </param>
        /// <param name="codeVerifier">
        /// The code verifier if code_challenge was used in the authorization request
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OAuthExchangeAuthCodeForAPIKeyResponse200> ExchangeAuthCodeForApiKeyAsync(
            string code,
            string? codeVerifier = default,
            global::G.OneOf<global::G.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>? codeChallengeMethod = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}