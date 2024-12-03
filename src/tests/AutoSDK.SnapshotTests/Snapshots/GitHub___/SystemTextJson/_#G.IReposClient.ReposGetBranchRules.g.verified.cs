//HintName: G.IReposClient.ReposGetBranchRules.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get rules for a branch<br/>
        /// Returns all active rules that apply to the specified branch. The branch does not need to exist; rules that would apply<br/>
        /// to a branch with that name will be returned. All active rules that apply will be returned, regardless of the level<br/>
        /// at which they are configured (e.g. repository or organization). Rules in rulesets with "evaluate" or "disabled"<br/>
        /// enforcement statuses are not returned.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RepositoryRuleDetailed>> ReposGetBranchRulesAsync(
            string owner,
            string repo,
            string branch,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}