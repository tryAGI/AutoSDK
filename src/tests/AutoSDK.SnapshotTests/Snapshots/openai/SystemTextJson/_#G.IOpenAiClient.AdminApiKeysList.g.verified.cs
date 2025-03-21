//HintName: G.IOpenAiClient.AdminApiKeysList.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List organization API keys<br/>
        /// Retrieve a paginated list of organization admin API keys.
        /// </summary>
        /// <param name="after">
        /// Return keys with IDs that come after this ID in the pagination order.
        /// </param>
        /// <param name="order">
        /// Order results by creation time, ascending or descending.<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="limit">
        /// Maximum number of keys to return.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyList> AdminApiKeysListAsync(
            string? after = default,
            global::G.AdminApiKeysListOrder? order = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}