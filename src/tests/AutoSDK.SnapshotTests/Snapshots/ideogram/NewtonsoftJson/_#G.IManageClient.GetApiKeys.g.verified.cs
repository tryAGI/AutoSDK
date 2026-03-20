//HintName: G.IManageClient.GetApiKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve current API keys and their respective data.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetApiKeysResponse> GetApiKeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}