//HintName: G.IActionsClient.ActionsDeleteActionsCacheByKey.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Delete GitHub Actions caches for a repository (using a cache key)<br/>
        /// Deletes one or more GitHub Actions caches for a repository, using a complete cache key. By default, all caches that match the provided key are deleted, but you can optionally provide a Git ref to restrict deletions to caches that match both the provided key and the Git ref.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="key"></param>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsCacheList> ActionsDeleteActionsCacheByKeyAsync(
            string owner,
            string repo,
            string key,
            string? @ref = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}