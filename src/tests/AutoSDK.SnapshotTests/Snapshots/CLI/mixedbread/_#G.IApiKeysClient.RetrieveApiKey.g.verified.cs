//HintName: G.IApiKeysClient.RetrieveApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Get API key details<br/>
        /// Retrieve details of a specific API key by its ID.<br/>
        /// Args:<br/>
        ///     api_key_id: The ID of the API key to retrieve.<br/>
        /// Returns:<br/>
        ///     ApiKey: The response containing the API key details.
        /// </summary>
        /// <param name="apiKeyId">
        /// The ID of the API key to retrieve
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> RetrieveApiKeyAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}