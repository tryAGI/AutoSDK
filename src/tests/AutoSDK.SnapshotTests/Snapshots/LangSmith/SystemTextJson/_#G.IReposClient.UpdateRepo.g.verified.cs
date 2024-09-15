//HintName: G.IReposClient.UpdateRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Update Repo<br/>
        /// Update a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateRepoResponse> UpdateRepoAsync(
            string owner,
            string repo,
            global::G.UpdateRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Repo<br/>
        /// Update a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="tags"></param>
        /// <param name="isPublic"></param>
        /// <param name="isArchived"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateRepoResponse> UpdateRepoAsync(
            string owner,
            string repo,
            global::G.AnyOf<string, object>? description = default,
            global::G.AnyOf<string, object>? readme = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::G.AnyOf<bool?, object>? isPublic = default,
            global::G.AnyOf<bool?, object>? isArchived = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}