//HintName: G.ILikesClient.LikeRepo.g.cs
#nullable enable

namespace G
{
    public partial interface ILikesClient
    {
        /// <summary>
        /// Like Repo<br/>
        /// Like a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LikeRepoResponse> LikeRepoAsync(
            string owner,
            string repo,
            global::G.LikeRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Like Repo<br/>
        /// Like a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="like"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LikeRepoResponse> LikeRepoAsync(
            string owner,
            string repo,
            bool like,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}