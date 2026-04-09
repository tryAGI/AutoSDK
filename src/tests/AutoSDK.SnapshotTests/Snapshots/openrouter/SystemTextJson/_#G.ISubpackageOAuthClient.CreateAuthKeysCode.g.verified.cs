//HintName: G.ISubpackageOAuthClient.CreateAuthKeysCode.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageOAuthClient
    {
        /// <summary>
        /// Create authorization code<br/>
        /// Create an authorization code for the PKCE flow to generate a user-controlled API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OAuthCreateAuthKeysCodeResponse200> CreateAuthKeysCodeAsync(

            global::G.CreateAuthKeysCodeRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create authorization code<br/>
        /// Create an authorization code for the PKCE flow to generate a user-controlled API key
        /// </summary>
        /// <param name="callbackUrl">
        /// The callback URL to redirect to after authorization. Note, only https URLs on ports 443 and 3000 are allowed.
        /// </param>
        /// <param name="codeChallenge">
        /// PKCE code challenge for enhanced security
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge
        /// </param>
        /// <param name="limit">
        /// Credit limit for the API key to be created
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration time for the API key to be created
        /// </param>
        /// <param name="keyLabel">
        /// Optional custom label for the API key. Defaults to the app name if not provided.
        /// </param>
        /// <param name="usageLimitType">
        /// Optional credit limit reset interval. When set, the credit limit resets on this interval.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OAuthCreateAuthKeysCodeResponse200> CreateAuthKeysCodeAsync(
            string callbackUrl,
            string? codeChallenge = default,
            global::G.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod? codeChallengeMethod = default,
            double? limit = default,
            global::System.DateTime? expiresAt = default,
            string? keyLabel = default,
            global::G.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType? usageLimitType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}