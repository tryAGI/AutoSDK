//HintName: G.IOpenAiClient.AdminApiKeysCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Create an organization admin API key<br/>
        /// Create a new admin-level API key for the organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminApiKey> AdminApiKeysCreateAsync(
            global::G.AdminApiKeysCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an organization admin API key<br/>
        /// Create a new admin-level API key for the organization.
        /// </summary>
        /// <param name="name">
        /// Example: New Admin Key
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminApiKey> AdminApiKeysCreateAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}