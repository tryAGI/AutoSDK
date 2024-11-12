//HintName: G.IReposClient.ReposGetReleaseByTag.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get a release by tag name<br/>
        /// Get a published release with the specified tag.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Release> ReposGetReleaseByTagAsync(
            string owner,
            string repo,
            string tag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}