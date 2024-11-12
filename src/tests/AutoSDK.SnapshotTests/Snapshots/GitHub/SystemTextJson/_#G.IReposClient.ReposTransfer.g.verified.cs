//HintName: G.IReposClient.ReposTransfer.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Transfer a repository<br/>
        /// A transfer request will need to be accepted by the new owner when transferring a personal repository to another user. The response will contain the original `owner`, and the transfer will continue asynchronously. For more details on the requirements to transfer personal and organization-owned repositories, see [about repository transfers](https://docs.github.com/articles/about-repository-transfers/).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MinimalRepository> ReposTransferAsync(
            string owner,
            string repo,
            global::G.ReposTransferRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Transfer a repository<br/>
        /// A transfer request will need to be accepted by the new owner when transferring a personal repository to another user. The response will contain the original `owner`, and the transfer will continue asynchronously. For more details on the requirements to transfer personal and organization-owned repositories, see [about repository transfers](https://docs.github.com/articles/about-repository-transfers/).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="newOwner">
        /// The username or organization name the repository will be transferred to.
        /// </param>
        /// <param name="newName">
        /// The new name to be given to the repository.
        /// </param>
        /// <param name="teamIds">
        /// ID of the team or teams to add to the repository. Teams can only be added to organization-owned repositories.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MinimalRepository> ReposTransferAsync(
            string owner,
            string repo,
            string newOwner,
            string? newName = default,
            global::System.Collections.Generic.IList<int>? teamIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}