//HintName: G.IOrgsClient.OrgsCreateInvitation.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create an organization invitation<br/>
        /// Invite people to an organization by using their GitHub user ID or their email address. In order to create invitations in an organization, the authenticated user must be an organization owner.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"<br/>
        /// and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationInvitation> OrgsCreateInvitationAsync(
            string org,
            global::G.OrgsCreateInvitationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an organization invitation<br/>
        /// Invite people to an organization by using their GitHub user ID or their email address. In order to create invitations in an organization, the authenticated user must be an organization owner.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"<br/>
        /// and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="inviteeId">
        /// **Required unless you provide `email`**. GitHub user ID for the person you are inviting.
        /// </param>
        /// <param name="email">
        /// **Required unless you provide `invitee_id`**. Email address of the person you are inviting, which can be an existing GitHub user.
        /// </param>
        /// <param name="role">
        /// The role for the new member. <br/>
        ///  * `admin` - Organization owners with full administrative rights to the organization and complete access to all repositories and teams.  <br/>
        ///  * `direct_member` - Non-owner organization members with ability to see other members and join teams by invitation.  <br/>
        ///  * `billing_manager` - Non-owner organization members with ability to manage the billing settings of your organization. <br/>
        ///  * `reinstate` - The previous role assigned to the invitee before they were removed from your organization. Can be one of the roles listed above. Only works if the invitee was previously part of your organization.<br/>
        /// Default Value: direct_member
        /// </param>
        /// <param name="teamIds">
        /// Specify IDs for the teams you want to invite new members to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationInvitation> OrgsCreateInvitationAsync(
            string org,
            int? inviteeId = default,
            string? email = default,
            global::G.OrgsCreateInvitationRequestRole? role = default,
            global::System.Collections.Generic.IList<int>? teamIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}