//HintName: G.IManageClient.CreateApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Creates an API key.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostApiKeyResponse> CreateApiKeyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}