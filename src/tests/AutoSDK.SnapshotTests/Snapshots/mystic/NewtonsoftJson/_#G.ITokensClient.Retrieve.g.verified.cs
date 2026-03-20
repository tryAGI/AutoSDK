//HintName: G.ITokensClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve an API Bearer token for an authenticated user.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TokenGet> RetrieveAsync(
            string tokenId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}