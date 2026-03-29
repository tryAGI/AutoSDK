//HintName: G.IApiKeysClient.GetKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyObjectList> GetKeysAsync(
            int? pageSize = default,
            int? currentPage = default,
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}