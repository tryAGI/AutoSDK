//HintName: G.IOrgsClient.OrgsListInvitationTeams.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List organization invitation teams<br/>
        /// List all teams associated with an invitation. In order to see invitations in an organization, the authenticated user must be an organization owner.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="invitationId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Team>> OrgsListInvitationTeamsAsync(
            string org,
            int invitationId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}