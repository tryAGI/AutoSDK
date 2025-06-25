//HintName: G.IReposClient.ReposGetAutolink.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get an autolink reference of a repository<br/>
        /// This returns a single autolink reference by ID that was configured for the given repository.<br/>
        /// Information about autolinks are only available to repository administrators.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="autolinkId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Autolink> ReposGetAutolinkAsync(
            string owner,
            string repo,
            int autolinkId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}