//HintName: G.IOpenAiClient.AdminApiKeysGet.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve a single organization API key<br/>
        /// Get details for a specific organization API key by its ID.
        /// </summary>
        /// <param name="keyId">
        /// The ID of the API key.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminApiKey> AdminApiKeysGetAsync(
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}