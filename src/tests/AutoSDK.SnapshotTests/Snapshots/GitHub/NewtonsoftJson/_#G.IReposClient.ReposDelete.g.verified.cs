//HintName: G.IReposClient.ReposDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete a repository<br/>
        /// Deleting a repository requires admin access.<br/>
        /// If an organization owner has configured the organization to prevent members from deleting organization-owned<br/>
        /// repositories, you will get a `403 Forbidden` response.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `delete_repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReposDeleteAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}