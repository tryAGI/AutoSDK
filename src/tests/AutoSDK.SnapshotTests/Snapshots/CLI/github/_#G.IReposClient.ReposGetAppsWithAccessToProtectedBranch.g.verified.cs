﻿//HintName: G.IReposClient.ReposGetAppsWithAccessToProtectedBranch.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get apps with access to the protected branch<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Lists the GitHub Apps that have push access to this branch. Only GitHub Apps that are installed on the repository and that have been granted write access to the repository contents can be added as authorized actors on a protected branch.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Integration>> ReposGetAppsWithAccessToProtectedBranchAsync(
            string owner,
            string repo,
            string branch,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}