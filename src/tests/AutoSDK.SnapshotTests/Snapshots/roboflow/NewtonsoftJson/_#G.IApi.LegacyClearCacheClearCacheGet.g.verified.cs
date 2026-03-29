//HintName: G.IApi.LegacyClearCacheClearCacheGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Legacy Clear Cache<br/>
        /// Clears the model cache.<br/>
        /// This endpoint provides a way to clear the cache of loaded models.<br/>
        /// Returns:<br/>
        ///     str: A string indicating that the cache has been cleared.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LegacyClearCacheClearCacheGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}