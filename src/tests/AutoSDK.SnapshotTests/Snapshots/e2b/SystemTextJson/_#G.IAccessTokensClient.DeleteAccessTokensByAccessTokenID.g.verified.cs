//HintName: G.IAccessTokensClient.DeleteAccessTokensByAccessTokenID.g.cs
#nullable enable

namespace G
{
    public partial interface IAccessTokensClient
    {
        /// <summary>
        /// Delete an access token
        /// </summary>
        /// <param name="accessTokenID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAccessTokensByAccessTokenIDAsync(
            string accessTokenID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}