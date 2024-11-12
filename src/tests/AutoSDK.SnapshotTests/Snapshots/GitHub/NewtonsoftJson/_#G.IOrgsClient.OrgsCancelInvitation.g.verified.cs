//HintName: G.IOrgsClient.OrgsCancelInvitation.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Cancel an organization invitation<br/>
        /// Cancel an organization invitation. In order to cancel an organization invitation, the authenticated user must be an organization owner.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications).
        /// </summary>
        /// <param name="org"></param>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task OrgsCancelInvitationAsync(
            string org,
            int invitationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}