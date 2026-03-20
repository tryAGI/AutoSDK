//HintName: G.IGitClient.GitGetTree.g.cs
#nullable enable

namespace G
{
    public partial interface IGitClient
    {
        /// <summary>
        /// Get a tree<br/>
        /// Returns a single tree using the SHA1 value or ref name for that tree.<br/>
        /// If `truncated` is `true` in the response then the number of items in the `tree` array exceeded our maximum limit. If you need to fetch more items, use the non-recursive method of fetching trees, and fetch one sub-tree at a time.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The limit for the `tree` array is 100,000 entries with a maximum size of 7 MB when using the `recursive` parameter.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="treeSha"></param>
        /// <param name="recursive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GitTree> GitGetTreeAsync(
            string owner,
            string repo,
            string treeSha,
            string? recursive = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}