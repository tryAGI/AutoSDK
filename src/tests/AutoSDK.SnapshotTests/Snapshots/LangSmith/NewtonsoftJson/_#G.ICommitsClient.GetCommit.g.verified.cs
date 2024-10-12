//HintName: G.ICommitsClient.GetCommit.g.cs
#nullable enable

namespace G
{
    public partial interface ICommitsClient
    {
        /// <summary>
        /// Get Commit<br/>
        /// Download a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commit"></param>
        /// <param name="getExamples">
        /// Default Value: false
        /// </param>
        /// <param name="isView">
        /// Default Value: false
        /// </param>
        /// <param name="includeModel">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CommitManifestResponse> GetCommitAsync(
            string owner,
            string repo,
            string commit,
            bool? getExamples = false,
            bool? isView = false,
            bool? includeModel = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}