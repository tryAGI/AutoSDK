//HintName: G.IReposClient.ReposGetOrgRuleset.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get an organization repository ruleset<br/>
        /// Get a repository ruleset for an organization.<br/>
        /// **Note:** To prevent leaking sensitive information, the `bypass_actors` property is only returned if the user<br/>
        /// making the API request has write access to the ruleset.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="rulesetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositoryRuleset> ReposGetOrgRulesetAsync(
            string org,
            int rulesetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}