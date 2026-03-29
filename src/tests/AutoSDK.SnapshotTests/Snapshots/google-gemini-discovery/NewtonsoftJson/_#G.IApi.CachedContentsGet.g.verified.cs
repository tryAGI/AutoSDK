//HintName: G.IApi.CachedContentsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Reads CachedContent resource.
        /// </summary>
        /// <param name="cachedContentsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CachedContent> CachedContentsGetAsync(
            string cachedContentsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}