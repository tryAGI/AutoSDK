//HintName: G.IMetaClient.MetaGetAllVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get all API versions<br/>
        /// Get all supported GitHub API versions.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.DateTime>> MetaGetAllVersionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}