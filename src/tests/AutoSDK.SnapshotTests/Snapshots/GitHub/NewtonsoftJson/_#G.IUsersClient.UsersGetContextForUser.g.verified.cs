//HintName: G.IUsersClient.UsersGetContextForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get contextual information for a user<br/>
        /// Provides hovercard information. You can find out more about someone in relation to their pull requests, issues, repositories, and organizations.<br/>
        ///   The `subject_type` and `subject_id` parameters provide context for the person's hovercard, which returns more information than without the parameters. For example, if you wanted to find out more about `octocat` who owns the `Spoon-Knife` repository, you would use a `subject_type` value of `repository` and a `subject_id` value of `1300192` (the ID of the `Spoon-Knife` repository).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="subjectType"></param>
        /// <param name="subjectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Hovercard> UsersGetContextForUserAsync(
            string username,
            global::G.UsersGetContextForUserSubjectType? subjectType = default,
            string? subjectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}