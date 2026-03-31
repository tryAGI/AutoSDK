//HintName: G.IApiKeysClient.CreateApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create API key<br/>
        /// Create a new API key.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating the API key.<br/>
        /// Returns:<br/>
        ///     ApiKeyCreated: The response containing the details of the created API key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyCreated> CreateApiKeyAsync(

            global::G.ApiKeyCreateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API key<br/>
        /// Create a new API key.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating the API key.<br/>
        /// Returns:<br/>
        ///     ApiKeyCreated: The response containing the details of the created API key.
        /// </summary>
        /// <param name="name">
        /// A name/description for the API key<br/>
        /// Default Value: API Key
        /// </param>
        /// <param name="scope">
        /// The scope of the API key
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration datetime
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyCreated> CreateApiKeyAsync(
            string? name = default,
            global::System.Collections.Generic.IList<global::G.Scope>? scope = default,
            global::System.DateTime? expiresAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}