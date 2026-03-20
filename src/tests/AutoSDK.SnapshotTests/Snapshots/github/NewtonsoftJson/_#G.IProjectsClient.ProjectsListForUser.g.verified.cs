//HintName: G.IProjectsClient.ProjectsListForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List user projects<br/>
        /// Lists projects for a user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Project>> ProjectsListForUserAsync(
            string username,
            global::G.ProjectsListForUserState? state = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}