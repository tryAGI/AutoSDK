//HintName: G.ITeamsClient.TeamsListForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List teams for the authenticated user<br/>
        /// List all of the teams across all of the organizations to which the authenticated<br/>
        /// user belongs.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user`, `repo`, or `read:org` scope to use this endpoint.<br/>
        /// When using a fine-grained personal access token, the resource owner of the token must be a single organization, and the response will only include the teams from that organization.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TeamFull>> TeamsListForAuthenticatedUserAsync(
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}