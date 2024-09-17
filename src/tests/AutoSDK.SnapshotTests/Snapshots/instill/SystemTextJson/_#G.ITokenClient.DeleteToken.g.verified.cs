//HintName: G.ITokenClient.DeleteToken.g.cs
#nullable enable

namespace G
{
    public partial interface ITokenClient
    {
        /// <summary>
        /// Delete an API token<br/>
        /// Deletes an API token.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteTokenResponse> DeleteTokenAsync(
            string tokenId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}