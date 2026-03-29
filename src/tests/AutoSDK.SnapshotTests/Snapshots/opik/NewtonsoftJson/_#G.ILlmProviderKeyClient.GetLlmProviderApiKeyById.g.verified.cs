//HintName: G.ILlmProviderKeyClient.GetLlmProviderApiKeyById.g.cs
#nullable enable

namespace G
{
    public partial interface ILlmProviderKeyClient
    {
        /// <summary>
        /// Get LLM Provider's ApiKey by id<br/>
        /// Get LLM Provider's ApiKey by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProviderApiKeyPublic> GetLlmProviderApiKeyByIdAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}