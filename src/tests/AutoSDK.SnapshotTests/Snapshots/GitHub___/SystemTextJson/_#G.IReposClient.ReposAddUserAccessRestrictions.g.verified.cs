//HintName: G.IReposClient.ReposAddUserAccessRestrictions.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Add user access restrictions<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Grants the specified people push access for this branch.<br/>
        /// | Type    | Description                                                                                                                   |<br/>
        /// | ------- | ----------------------------------------------------------------------------------------------------------------------------- |<br/>
        /// | `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SimpleUser>> ReposAddUserAccessRestrictionsAsync(
            string owner,
            string repo,
            string branch,
            global::G.ReposAddUserAccessRestrictionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add user access restrictions<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Grants the specified people push access for this branch.<br/>
        /// | Type    | Description                                                                                                                   |<br/>
        /// | ------- | ----------------------------------------------------------------------------------------------------------------------------- |<br/>
        /// | `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="users">
        /// The username for users
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SimpleUser>> ReposAddUserAccessRestrictionsAsync(
            string owner,
            string repo,
            string branch,
            global::System.Collections.Generic.IList<string> users,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}