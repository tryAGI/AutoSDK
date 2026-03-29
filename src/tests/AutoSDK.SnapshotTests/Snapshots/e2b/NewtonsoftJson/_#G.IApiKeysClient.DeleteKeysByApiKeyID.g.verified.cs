//HintName: G.IApiKeysClient.DeleteKeysByApiKeyID.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete a team API key
        /// </summary>
        /// <param name="apiKeyID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteKeysByApiKeyIDAsync(
            string apiKeyID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}