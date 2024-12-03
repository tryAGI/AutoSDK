//HintName: G.IReposClient.ReposDeleteRepoRuleset.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete a repository ruleset<br/>
        /// Delete a ruleset for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposDeleteRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}