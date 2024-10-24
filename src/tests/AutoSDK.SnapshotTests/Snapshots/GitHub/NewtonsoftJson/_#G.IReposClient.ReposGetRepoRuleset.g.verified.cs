//HintName: G.IReposClient.ReposGetRepoRuleset.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get a repository ruleset<br/>
        /// Get a ruleset for a repository.<br/>
        /// **Note:** To prevent leaking sensitive information, the `bypass_actors` property is only returned if the user<br/>
        /// making the API request has write access to the ruleset.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="includesParents">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositoryRuleset> ReposGetRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            bool? includesParents = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}