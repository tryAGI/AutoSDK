//HintName: G.IAliasesClient.GetCollectionsAliases.g.cs
#nullable enable

namespace G
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// List collections aliases<br/>
        /// Get list of all existing collections aliases
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCollectionsAliasesResponse> GetCollectionsAliasesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}