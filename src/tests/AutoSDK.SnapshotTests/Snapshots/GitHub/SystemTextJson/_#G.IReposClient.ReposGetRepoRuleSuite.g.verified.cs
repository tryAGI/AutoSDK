//HintName: G.IReposClient.ReposGetRepoRuleSuite.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get a repository rule suite<br/>
        /// Gets information about a suite of rule evaluations from within a repository.<br/>
        /// For more information, see "[Managing rulesets for a repository](https://docs.github.com/repositories/configuring-branches-and-merges-in-your-repository/managing-rulesets/managing-rulesets-for-a-repository#viewing-insights-for-rulesets)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ruleSuiteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RuleSuite2> ReposGetRepoRuleSuiteAsync(
            string owner,
            string repo,
            int ruleSuiteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}