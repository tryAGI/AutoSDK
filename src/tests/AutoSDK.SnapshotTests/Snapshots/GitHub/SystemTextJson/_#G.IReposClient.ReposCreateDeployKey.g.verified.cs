//HintName: G.IReposClient.ReposCreateDeployKey.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a deploy key<br/>
        /// You can create a read-only deploy key.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeployKey> ReposCreateDeployKeyAsync(
            string owner,
            string repo,
            global::G.ReposCreateDeployKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a deploy key<br/>
        /// You can create a read-only deploy key.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="title">
        /// A name for the key.
        /// </param>
        /// <param name="key">
        /// The contents of the key.
        /// </param>
        /// <param name="readOnly">
        /// If `true`, the key will only be able to read repository contents. Otherwise, the key will be able to read and write.  <br/>
        ///   <br/>
        /// Deploy keys with write access can perform the same actions as an organization member with admin access, or a collaborator on a personal repository. For more information, see "[Repository permission levels for an organization](https://docs.github.com/articles/repository-permission-levels-for-an-organization/)" and "[Permission levels for a user account repository](https://docs.github.com/articles/permission-levels-for-a-user-account-repository/)."
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeployKey> ReposCreateDeployKeyAsync(
            string owner,
            string repo,
            string key,
            string? title = default,
            bool? readOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}