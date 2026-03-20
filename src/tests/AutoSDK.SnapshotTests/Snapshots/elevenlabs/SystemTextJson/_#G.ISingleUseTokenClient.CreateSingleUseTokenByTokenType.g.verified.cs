//HintName: G.ISingleUseTokenClient.CreateSingleUseTokenByTokenType.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleUseTokenClient
    {

        /// <summary>
        /// Create Single Use Token<br/>
        /// Generate a time limited single-use token with embedded authentication for frontend clients.
        /// </summary>
        /// <param name="tokenType"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SingleUseTokenResponseModel> CreateSingleUseTokenByTokenTypeAsync(
            global::G.SingleUseTokenType tokenType,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}