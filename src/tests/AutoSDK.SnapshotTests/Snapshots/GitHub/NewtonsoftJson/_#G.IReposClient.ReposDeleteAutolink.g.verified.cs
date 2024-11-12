//HintName: G.IReposClient.ReposDeleteAutolink.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete an autolink reference from a repository<br/>
        /// This deletes a single autolink reference by ID that was configured for the given repository.<br/>
        /// Information about autolinks are only available to repository administrators.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="autolinkId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReposDeleteAutolinkAsync(
            string owner,
            string repo,
            int autolinkId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}