//HintName: G.IOrgsClient.OrgsSetMembershipForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Set organization membership for a user<br/>
        /// Only authenticated organization owners can add a member to the organization or update the member's role.<br/>
        /// *   If the authenticated user is _adding_ a member to the organization, the invited user will receive an email inviting them to the organization. The user's [membership status](https://docs.github.com/rest/orgs/members#get-organization-membership-for-a-user) will be `pending` until they accept the invitation.<br/>
        ///     <br/>
        /// *   Authenticated users can _update_ a user's membership by passing the `role` parameter. If the authenticated user changes a member's role to `admin`, the affected user will receive an email notifying them that they've been made an organization owner. If the authenticated user changes an owner's role to `member`, no email will be sent.<br/>
        /// **Rate limits**<br/>
        /// To prevent abuse, organization owners are limited to creating 50 organization invitations for an organization within a 24 hour period. If the organization is more than one month old or on a paid plan, the limit is 500 invitations per 24 hour period.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgMembership> OrgsSetMembershipForUserAsync(
            string org,
            string username,
            global::G.OrgsSetMembershipForUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set organization membership for a user<br/>
        /// Only authenticated organization owners can add a member to the organization or update the member's role.<br/>
        /// *   If the authenticated user is _adding_ a member to the organization, the invited user will receive an email inviting them to the organization. The user's [membership status](https://docs.github.com/rest/orgs/members#get-organization-membership-for-a-user) will be `pending` until they accept the invitation.<br/>
        ///     <br/>
        /// *   Authenticated users can _update_ a user's membership by passing the `role` parameter. If the authenticated user changes a member's role to `admin`, the affected user will receive an email notifying them that they've been made an organization owner. If the authenticated user changes an owner's role to `member`, no email will be sent.<br/>
        /// **Rate limits**<br/>
        /// To prevent abuse, organization owners are limited to creating 50 organization invitations for an organization within a 24 hour period. If the organization is more than one month old or on a paid plan, the limit is 500 invitations per 24 hour period.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="role">
        /// The role to give the user in the organization. Can be one of:  <br/>
        ///  * `admin` - The user will become an owner of the organization.  <br/>
        ///  * `member` - The user will become a non-owner member of the organization.<br/>
        /// Default Value: member
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgMembership> OrgsSetMembershipForUserAsync(
            string org,
            string username,
            global::G.OrgsSetMembershipForUserRequestRole? role = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}