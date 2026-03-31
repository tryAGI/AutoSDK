//HintName: G.IApiKeysClient.DeleteApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete API key<br/>
        /// Delete a specific API key by its ID.<br/>
        /// Args:<br/>
        ///     api_key_id: The ID of the API key to delete.<br/>
        /// Returns:<br/>
        ///     ApiKeyDeleted: The response containing the details of the deleted API key.
        /// </summary>
        /// <param name="apiKeyId">
        /// The ID of the API key to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyDeleted> DeleteApiKeyAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}