//HintName: G.IReposClient.CreateRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create Repo<br/>
        /// Create a repo.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateRepoResponse> CreateRepoAsync(
            global::G.CreateRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Repo<br/>
        /// Create a repo.
        /// </summary>
        /// <param name="repoHandle"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="isPublic"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateRepoResponse> CreateRepoAsync(
            string repoHandle,
            bool isPublic,
            global::G.AnyOf<string, object>? description = default,
            global::G.AnyOf<string, object>? readme = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}