//HintName: G.IOrgsClient.OrgsListPendingInvitations.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List pending organization invitations<br/>
        /// The return hash contains a `role` field which refers to the Organization<br/>
        /// Invitation role and will be one of the following values: `direct_member`, `admin`,<br/>
        /// `billing_manager`, or `hiring_manager`. If the invitee is not a GitHub<br/>
        /// member, the `login` field in the return hash will be `null`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="role">
        /// Default Value: all
        /// </param>
        /// <param name="invitationSource">
        /// Default Value: all
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrganizationInvitation>> OrgsListPendingInvitationsAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::G.OrgsListPendingInvitationsRole? role = default,
            global::G.OrgsListPendingInvitationsInvitationSource? invitationSource = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}