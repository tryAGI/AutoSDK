//HintName: G.IReposClient.ReposListBranches.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List branches
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="protected"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ShortBranch>> ReposListBranchesAsync(
            string owner,
            string repo,
            bool? @protected = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}