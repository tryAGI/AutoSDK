//HintName: G.IApiKeyClient.GetPersonalAccessTokens.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// Get Personal Access Tokens<br/>
        /// Get the current users PATs for this tenant
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.APIKeyGetResponse>> GetPersonalAccessTokensAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}