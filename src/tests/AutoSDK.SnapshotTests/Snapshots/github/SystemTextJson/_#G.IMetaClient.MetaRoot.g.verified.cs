//HintName: G.IMetaClient.MetaRoot.g.cs
#nullable enable

namespace G
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// GitHub API Root<br/>
        /// Get Hypermedia links to resources accessible in GitHub's REST API
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Root> MetaRootAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}