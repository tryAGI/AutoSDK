//HintName: G.IReposClient.ReposGetRepoRulesets.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get all repository rulesets<br/>
        /// Get all the rulesets for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="includesParents">
        /// Default Value: true
        /// </param>
        /// <param name="targets">
        /// Example: branch,tag,push
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RepositoryRuleset>> ReposGetRepoRulesetsAsync(
            string owner,
            string repo,
            int? perPage = default,
            int? page = default,
            bool? includesParents = default,
            string? targets = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}