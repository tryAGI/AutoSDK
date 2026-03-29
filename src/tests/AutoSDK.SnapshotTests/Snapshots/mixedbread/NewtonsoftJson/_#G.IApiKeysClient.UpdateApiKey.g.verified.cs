//HintName: G.IApiKeysClient.UpdateApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Update API key<br/>
        /// Update a specific API key by its ID.<br/>
        /// Args:<br/>
        ///     api_key_id: The ID of the API key to update.<br/>
        ///     params: The parameters to update.<br/>
        /// Returns:<br/>
        ///     ApiKey: The updated API key details.
        /// </summary>
        /// <param name="apiKeyId">
        /// The ID of the API key to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> UpdateApiKeyAsync(
            global::System.Guid apiKeyId,

            global::G.ApiKeyUpdateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update API key<br/>
        /// Update a specific API key by its ID.<br/>
        /// Args:<br/>
        ///     api_key_id: The ID of the API key to update.<br/>
        ///     params: The parameters to update.<br/>
        /// Returns:<br/>
        ///     ApiKey: The updated API key details.
        /// </summary>
        /// <param name="apiKeyId">
        /// The ID of the API key to update
        /// </param>
        /// <param name="name">
        /// A name/description for the API key
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration datetime
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> UpdateApiKeyAsync(
            global::System.Guid apiKeyId,
            string? name = default,
            global::System.DateTime? expiresAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}