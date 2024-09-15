//HintName: G.IReposClient.ReposGetAllTopics.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get all repository topics
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Topic> ReposGetAllTopicsAsync(
            string owner,
            string repo,
            int page = 1,
            int perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}