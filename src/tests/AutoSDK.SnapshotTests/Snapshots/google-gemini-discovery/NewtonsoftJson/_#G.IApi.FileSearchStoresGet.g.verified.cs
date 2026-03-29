//HintName: G.IApi.FileSearchStoresGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets information about a specific `FileSearchStore`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileSearchStore> FileSearchStoresGetAsync(
            string fileSearchStoresId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}