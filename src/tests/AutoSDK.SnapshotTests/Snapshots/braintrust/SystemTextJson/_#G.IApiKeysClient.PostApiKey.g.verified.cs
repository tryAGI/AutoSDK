//HintName: G.IApiKeysClient.PostApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create api_key<br/>
        /// Create a new api_key. It is possible to have multiple API keys with the same name. There is no de-duplication
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateApiKeyOutput> PostApiKeyAsync(

            global::G.PostApiKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create api_key<br/>
        /// Create a new api_key. It is possible to have multiple API keys with the same name. There is no de-duplication
        /// </summary>
        /// <param name="name">
        /// Name of the api key. Does not have to be unique
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the API key belongs in.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateApiKeyOutput> PostApiKeyAsync(
            string name,
            string? orgName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}