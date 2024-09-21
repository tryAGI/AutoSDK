//HintName: G.IManageClient.DeleteSingleApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Delete an API key.
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteSingleApiKeyAsync(
            string apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}