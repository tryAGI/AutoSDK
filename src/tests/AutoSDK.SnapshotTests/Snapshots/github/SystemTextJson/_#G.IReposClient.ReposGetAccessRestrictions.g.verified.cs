//HintName: G.IReposClient.ReposGetAccessRestrictions.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get access restrictions<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Lists who has access to this protected branch.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Users, apps, and teams `restrictions` are only available for organization-owned repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BranchRestrictionPolicy> ReposGetAccessRestrictionsAsync(
            string owner,
            string repo,
            string branch,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}